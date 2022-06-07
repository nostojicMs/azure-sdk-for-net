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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceOperationResource" /> and their operations.
    /// Each <see cref="ManagedInstanceOperationResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="ManagedInstanceOperationCollection" /> instance call the GetManagedInstanceOperations method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class ManagedInstanceOperationCollection : ArmCollection, IEnumerable<ManagedInstanceOperationResource>, IAsyncEnumerable<ManagedInstanceOperationResource>
    {
        private readonly ClientDiagnostics _managedInstanceOperationClientDiagnostics;
        private readonly ManagedInstanceRestOperations _managedInstanceOperationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceOperationCollection"/> class for mocking. </summary>
        protected ManagedInstanceOperationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceOperationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceOperationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceOperationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceOperationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceOperationResource.ResourceType, out string managedInstanceOperationApiVersion);
            _managedInstanceOperationRestClient = new ManagedInstanceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a management operation on a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// Operation Id: ManagedInstanceOperations_Get
        /// </summary>
        /// <param name="operationId"> The Uuid to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceOperationResource>> GetAsync(Guid operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceOperationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, operationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a management operation on a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// Operation Id: ManagedInstanceOperations_Get
        /// </summary>
        /// <param name="operationId"> The Uuid to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceOperationResource> Get(Guid operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceOperationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, operationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of operations performed on the managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations
        /// Operation Id: ManagedInstanceOperations_ListByManagedInstance
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceOperationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceOperationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceOperationRestClient.ListByManagedInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceOperationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceOperationRestClient.ListByManagedInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of operations performed on the managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations
        /// Operation Id: ManagedInstanceOperations_ListByManagedInstance
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceOperationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceOperationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceOperationRestClient.ListByManagedInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceOperationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceOperationRestClient.ListByManagedInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceOperationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// Operation Id: ManagedInstanceOperations_Get
        /// </summary>
        /// <param name="operationId"> The Uuid to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceOperationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// Operation Id: ManagedInstanceOperations_Get
        /// </summary>
        /// <param name="operationId"> The Uuid to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceOperationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, operationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceOperationResource> IEnumerable<ManagedInstanceOperationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceOperationResource> IAsyncEnumerable<ManagedInstanceOperationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
