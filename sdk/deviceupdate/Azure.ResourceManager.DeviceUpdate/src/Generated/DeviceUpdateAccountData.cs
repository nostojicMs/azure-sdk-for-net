// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing the DeviceUpdateAccount data model. </summary>
    public partial class DeviceUpdateAccountData : Models.TrackedResource
    {
        /// <summary> Initializes a new instance of DeviceUpdateAccountData. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public DeviceUpdateAccountData(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        /// <summary> Initializes a new instance of DeviceUpdateAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="hostName"> API host name. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for the container registry. </param>
        internal DeviceUpdateAccountData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, string location, ManagedServiceIdentity identity, ProvisioningState? provisioningState, string hostName, PublicNetworkAccess? publicNetworkAccess) : base(id, name, type, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            HostName = hostName;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> The type of identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> API host name. </summary>
        public string HostName { get; }
        /// <summary> Whether or not public network access is allowed for the container registry. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
