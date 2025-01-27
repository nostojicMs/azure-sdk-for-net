// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Base resource under Microsoft.DataProtection provider namespace. </summary>
    public partial class ResourceGuardProtectedObjectData : ResourceData
    {
        /// <summary> Initializes a new instance of ResourceGuardProtectedObjectData. </summary>
        internal ResourceGuardProtectedObjectData()
        {
        }

        /// <summary> Initializes a new instance of ResourceGuardProtectedObjectData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        internal ResourceGuardProtectedObjectData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData) : base(id, name, resourceType, systemData)
        {
        }
    }
}
