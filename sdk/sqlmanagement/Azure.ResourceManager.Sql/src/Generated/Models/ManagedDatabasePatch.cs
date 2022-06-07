// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An managed database update. </summary>
    public partial class ManagedDatabasePatch
    {
        /// <summary> Initializes a new instance of ManagedDatabasePatch. </summary>
        public ManagedDatabasePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Collation of the managed database. </summary>
        public string Collation { get; set; }
        /// <summary> Status of the database. </summary>
        public ManagedDatabaseStatus? Status { get; }
        /// <summary> Creation date of the database. </summary>
        public DateTimeOffset? CreationOn { get; }
        /// <summary> Earliest restore point in time for point in time restore. </summary>
        public DateTimeOffset? EarliestRestorePoint { get; }
        /// <summary> Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        public DateTimeOffset? RestorePointInOn { get; set; }
        /// <summary> Geo paired region. </summary>
        public string DefaultSecondaryLocation { get; }
        /// <summary> Collation of the metadata catalog. </summary>
        public CatalogCollationType? CatalogCollation { get; set; }
        /// <summary> Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required). </summary>
        public ManagedDatabaseCreateMode? CreateMode { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored. </summary>
        public Uri StorageContainerUri { get; set; }
        /// <summary> The resource identifier of the source database associated with create operation of this database. </summary>
        public string SourceDatabaseId { get; set; }
        /// <summary> The restorable dropped database resource id to restore when creating this database. </summary>
        public string RestorableDroppedDatabaseId { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token. </summary>
        public string StorageContainerSasToken { get; set; }
        /// <summary> Instance Failover Group resource identifier that this managed database belongs to. </summary>
        public string FailoverGroupId { get; }
        /// <summary> The resource identifier of the recoverable database associated with create operation of this database. </summary>
        public string RecoverableDatabaseId { get; set; }
        /// <summary> The name of the Long Term Retention backup to be used for restore of this managed database. </summary>
        public string LongTermRetentionBackupResourceId { get; set; }
        /// <summary> Whether to auto complete restore of this managed database. </summary>
        public bool? AutoCompleteRestore { get; set; }
        /// <summary> Last backup file name for restore of this managed database. </summary>
        public string LastBackupName { get; set; }
    }
}
