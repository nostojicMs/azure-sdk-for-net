// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The ExpandedProperties. </summary>
    public partial class ExpandedProperties
    {
        /// <summary> Initializes a new instance of ExpandedProperties. </summary>
        internal ExpandedProperties()
        {
        }

        /// <summary> Initializes a new instance of ExpandedProperties. </summary>
        /// <param name="scope"> Details of the resource scope. </param>
        /// <param name="roleDefinition"> Details of role definition. </param>
        /// <param name="principal"> Details of the principal. </param>
        internal ExpandedProperties(ExpandedPropertiesScope scope, ExpandedPropertiesRoleDefinition roleDefinition, ExpandedPropertiesPrincipal principal)
        {
            Scope = scope;
            RoleDefinition = roleDefinition;
            Principal = principal;
        }

        /// <summary> Details of the resource scope. </summary>
        public ExpandedPropertiesScope Scope { get; }
        /// <summary> Details of role definition. </summary>
        public ExpandedPropertiesRoleDefinition RoleDefinition { get; }
        /// <summary> Details of the principal. </summary>
        public ExpandedPropertiesPrincipal Principal { get; }
    }
}
