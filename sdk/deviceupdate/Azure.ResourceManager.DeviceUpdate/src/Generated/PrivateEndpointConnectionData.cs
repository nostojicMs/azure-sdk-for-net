// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing the PrivateEndpointConnection data model. </summary>
    public partial class PrivateEndpointConnectionData : Models.Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        public PrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal PrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, SubResource privateEndpoint, PrivateLinkServiceConnectionState privateLinkServiceConnectionState, PrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, type, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource of private end point. </summary>
        public SubResource PrivateEndpoint { get; set; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public PrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
