// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment resource payload
    /// </summary>
    public partial class DeploymentResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentResource class.
        /// </summary>
        public DeploymentResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="properties">Properties of the Deployment
        /// resource</param>
        /// <param name="sku">Sku of the Deployment resource</param>
        public DeploymentResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), DeploymentResourceProperties properties = default(DeploymentResourceProperties), Sku sku = default(Sku))
            : base(id, name, type, systemData)
        {
            Properties = properties;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the Deployment resource
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentResourceProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets sku of the Deployment resource
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
