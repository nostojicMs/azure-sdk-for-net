// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SlotConfigNamesResource data model. </summary>
    public partial class SlotConfigNamesResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of SlotConfigNamesResourceData. </summary>
        public SlotConfigNamesResourceData()
        {
            ConnectionStringNames = new ChangeTrackingList<string>();
            AppSettingNames = new ChangeTrackingList<string>();
            AzureStorageConfigNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SlotConfigNamesResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="connectionStringNames"> List of connection string names. </param>
        /// <param name="appSettingNames"> List of application settings names. </param>
        /// <param name="azureStorageConfigNames"> List of external Azure storage account identifiers. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SlotConfigNamesResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<string> connectionStringNames, IList<string> appSettingNames, IList<string> azureStorageConfigNames, string kind) : base(id, name, resourceType, systemData)
        {
            ConnectionStringNames = connectionStringNames;
            AppSettingNames = appSettingNames;
            AzureStorageConfigNames = azureStorageConfigNames;
            Kind = kind;
        }

        /// <summary> List of connection string names. </summary>
        public IList<string> ConnectionStringNames { get; }
        /// <summary> List of application settings names. </summary>
        public IList<string> AppSettingNames { get; }
        /// <summary> List of external Azure storage account identifiers. </summary>
        public IList<string> AzureStorageConfigNames { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
