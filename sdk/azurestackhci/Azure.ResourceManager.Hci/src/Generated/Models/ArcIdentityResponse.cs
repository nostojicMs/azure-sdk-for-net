// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> ArcIdentity details. </summary>
    public partial class ArcIdentityResponse
    {
        /// <summary> Initializes a new instance of ArcIdentityResponse. </summary>
        internal ArcIdentityResponse()
        {
        }

        /// <summary> Initializes a new instance of ArcIdentityResponse. </summary>
        /// <param name="arcApplicationClientId"></param>
        /// <param name="arcApplicationTenantId"></param>
        /// <param name="arcServicePrincipalObjectId"></param>
        /// <param name="arcApplicationObjectId"></param>
        internal ArcIdentityResponse(string arcApplicationClientId, string arcApplicationTenantId, string arcServicePrincipalObjectId, string arcApplicationObjectId)
        {
            ArcApplicationClientId = arcApplicationClientId;
            ArcApplicationTenantId = arcApplicationTenantId;
            ArcServicePrincipalObjectId = arcServicePrincipalObjectId;
            ArcApplicationObjectId = arcApplicationObjectId;
        }

        /// <summary> Gets the arc application client id. </summary>
        public string ArcApplicationClientId { get; }
        /// <summary> Gets the arc application tenant id. </summary>
        public string ArcApplicationTenantId { get; }
        /// <summary> Gets the arc service principal object id. </summary>
        public string ArcServicePrincipalObjectId { get; }
        /// <summary> Gets the arc application object id. </summary>
        public string ArcApplicationObjectId { get; }
    }
}
