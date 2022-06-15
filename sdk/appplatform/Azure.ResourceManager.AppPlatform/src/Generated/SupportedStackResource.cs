// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing a SupportedStackResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SupportedStackResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSupportedStackResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppBuildServiceResource" /> using the GetSupportedStackResource method.
    /// </summary>
    public partial class SupportedStackResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportedStackResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string stackName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supportedStackResourceBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _supportedStackResourceBuildServiceRestClient;
        private readonly SupportedStackResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SupportedStackResource"/> class for mocking. </summary>
        protected SupportedStackResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SupportedStackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportedStackResource(ArmClient client, SupportedStackResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupportedStackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportedStackResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportedStackResourceBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supportedStackResourceBuildServiceApiVersion);
            _supportedStackResourceBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportedStackResourceBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/buildServices/supportedStacks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportedStackResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the supported stack resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}
        /// Operation Id: BuildService_GetSupportedStack
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportedStackResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResource.Get");
            scope.Start();
            try
            {
                var response = await _supportedStackResourceBuildServiceRestClient.GetSupportedStackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the supported stack resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}
        /// Operation Id: BuildService_GetSupportedStack
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportedStackResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResource.Get");
            scope.Start();
            try
            {
                var response = _supportedStackResourceBuildServiceRestClient.GetSupportedStack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
