﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Snippet:Azure_Communication_JobRouter_Tests_Samples_UsingStatements
using Azure.Communication.JobRouter;
#endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_UsingStatements
using Azure.Communication.JobRouter.Tests.Infrastructure;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.Samples
{
    public class Sample1_KeyConcepts : SamplesBase<RouterTestEnvironment>
    {
        [Test]
        public void BasicScenario()
        {
            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateClient

            var routerClient = new RouterClient(Environment.GetEnvironmentVariable("AZURE_COMMUNICATION_SERVICE_CONNECTION_STRING"));

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateClient

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateDistributionPolicyLongestIdleTTL1D
            var distributionPolicy = routerClient.CreateDistributionPolicy(
                id: "distribution-policy-1",
                offerTtlSeconds: 24 * 60 * 60,
                mode: new LongestIdleMode()
            );
            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateDistributionPolicyLongestIdleTTL1D

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateQueue
            var queue = routerClient.CreateQueue(
                id: "queue-1",
                distributionPolicyId: distributionPolicy.Value.Id
            );
            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateQueue

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateJobDirectQAssign
            var job = routerClient.CreateJob(
                id: "jobId-2",
                channelId: "my-channel",
                queueId: queue.Value.Id,
                new CreateJobOptions()
                {
                    ChannelReference = "12345",
                    Priority = 1,
                    RequestedWorkerSelectors = new List<WorkerSelector>
                    {
                        new WorkerSelector("Some-Skill", LabelOperator.GreaterThan, 10)
                    },
                });
            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_CreateJobDirectQAssign

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_RegisterWorker
            var worker = routerClient.CreateWorker(
                id: "worker-1",
                totalCapacity: 1,
                new CreateWorkerOptions()
                {
                    QueueIds = new[] { queue.Value.Id },
                    Labels = new LabelCollection()
                    {
                        ["Some-Skill"] = 11
                    },
                    ChannelConfigurations = new Dictionary<string, ChannelConfiguration>()
                    {
                        ["my-channel"] = new ChannelConfiguration(1)
                    },
                    AvailableForOffers = true,
                }
            );
            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_RegisterWorker

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_QueryWorker
            var result = routerClient.GetWorker(worker.Value.Id);
            foreach (var offer in result.Value.Offers)
            {
                Console.WriteLine($"Worker {worker.Value.Id} has an active offer for job {offer.JobId}");
            }
            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_QueryWorker

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_AcceptOffer

            // fetching the offer id
            var jobOffer = result.Value.Offers.FirstOrDefault(x => x.JobId == job.Value.Id);

            // accepting the offer sent to `worker-1`
            var acceptJobOfferResult = routerClient.AcceptJobOffer(worker.Value.Id, jobOffer!.Id);

            Console.WriteLine($"Offer: {jobOffer.Id} sent to worker: {worker.Value.Id} has been accepted");
            Console.WriteLine($"Job has been assigned to worker: {worker.Value.Id} with assignment: {acceptJobOfferResult.Value.AssignmentId}");

            // verify job assignment is populated when querying job
            var updatedJob = routerClient.GetJob(job.Value.Id);
            Console.WriteLine($"Job assignment has been successful: {updatedJob.Value.JobStatus == JobStatus.Assigned && updatedJob.Value.Assignments.ContainsKey(acceptJobOfferResult.Value.AssignmentId)}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_AcceptOffer

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_CompleteJob

            var completeJob = routerClient.CompleteJob(
                jobId: job.Value.Id,
                assignmentId: acceptJobOfferResult.Value.AssignmentId,
                options: new CompleteJobOptions() // this is optional
                {
                    Note = $"Job has been completed by {worker.Value.Id} at {DateTimeOffset.UtcNow}"
                });

            Console.WriteLine($"Job has been successfully completed: {completeJob.GetRawResponse().Status == 200}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_CompleteJob

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_CloseJob

            var closeJob = routerClient.CloseJob(
                jobId: job.Value.Id,
                assignmentId: acceptJobOfferResult.Value.AssignmentId,
                options: new CloseJobOptions()  // this is optional
                {
                    Note = $"Job has been closed by {worker.Value.Id} at {DateTimeOffset.UtcNow}"
                });
            Console.WriteLine($"Job has been successfully closed: {closeJob.GetRawResponse().Status == 200}");

            /*
            // Optionally, a job can also be set up to be marked as closed in the future.
            var closeJobInFuture = routerClient.CloseJob(
                jobId: job.Value.Id,
                assignmentId: acceptJobOfferResult.Value.AssignmentId,
                options: new CloseJobOptions()  // this is optional
                {
                    CloseTime = DateTimeOffset.UtcNow.AddSeconds(2), // this will mark the job as closed after 2 seconds
                    Note = $"Job has been marked to close in the future by {worker.Value.Id} at {DateTimeOffset.UtcNow}"
                });
            Console.WriteLine($"Job has been marked to close: {closeJob.GetRawResponse().Status == 202}"); // You'll received a 202 in that case

            await Task.Delay(TimeSpan.FromSeconds(2));
            */

            updatedJob = routerClient.GetJob(job.Value.Id);
            Console.WriteLine($"Updated job status: {updatedJob.Value.JobStatus == JobStatus.Closed}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_CloseJob
        }
    }
}
