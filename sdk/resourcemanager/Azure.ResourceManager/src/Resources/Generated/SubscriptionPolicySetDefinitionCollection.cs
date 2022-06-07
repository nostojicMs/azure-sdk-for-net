// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionPolicySetDefinitionResource" /> and their operations.
    /// Each <see cref="SubscriptionPolicySetDefinitionResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionPolicySetDefinitionCollection" /> instance call the GetSubscriptionPolicySetDefinitions method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionPolicySetDefinitionCollection : ArmCollection, IEnumerable<SubscriptionPolicySetDefinitionResource>, IAsyncEnumerable<SubscriptionPolicySetDefinitionResource>
    {
        private readonly ClientDiagnostics _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicySetDefinitionCollection"/> class for mocking. </summary>
        protected SubscriptionPolicySetDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicySetDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionPolicySetDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", SubscriptionPolicySetDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionPolicySetDefinitionResource.ResourceType, out string subscriptionPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation creates or updates a policy set definition in the given subscription with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to create. </param>
        /// <param name="data"> The policy set definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionPolicySetDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policySetDefinitionName, PolicySetDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, policySetDefinitionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<SubscriptionPolicySetDefinitionResource>(Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation creates or updates a policy set definition in the given subscription with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to create. </param>
        /// <param name="data"> The policy set definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionPolicySetDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string policySetDefinitionName, PolicySetDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.CreateOrUpdate(Id.SubscriptionId, policySetDefinitionName, data, cancellationToken);
                var operation = new ResourcesArmOperation<SubscriptionPolicySetDefinitionResource>(Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy set definition in the given subscription with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_Get
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionPolicySetDefinitionResource>> GetAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.GetAsync(Id.SubscriptionId, policySetDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy set definition in the given subscription with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_Get
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<SubscriptionPolicySetDefinitionResource> Get(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.Get(Id.SubscriptionId, policySetDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a list of all the policy set definitions in a given subscription that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy set definitions associated with the subscription, including those that apply directly or from management groups that contain the given subscription. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given subscription. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn and Custom. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions
        /// Operation Id: PolicySetDefinitions_List
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionPolicySetDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionPolicySetDefinitionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionPolicySetDefinitionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.ListAsync(Id.SubscriptionId, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionPolicySetDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionPolicySetDefinitionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionPolicySetDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// This operation retrieves a list of all the policy set definitions in a given subscription that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy set definitions associated with the subscription, including those that apply directly or from management groups that contain the given subscription. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given subscription. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn and Custom. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions
        /// Operation Id: PolicySetDefinitions_List
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionPolicySetDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionPolicySetDefinitionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<SubscriptionPolicySetDefinitionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.List(Id.SubscriptionId, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionPolicySetDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionPolicySetDefinitionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionPolicySetDefinitionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_Get
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.GetAsync(Id.SubscriptionId, policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_Get
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.Get(Id.SubscriptionId, policySetDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionPolicySetDefinitionResource> IEnumerable<SubscriptionPolicySetDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionPolicySetDefinitionResource> IAsyncEnumerable<SubscriptionPolicySetDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
