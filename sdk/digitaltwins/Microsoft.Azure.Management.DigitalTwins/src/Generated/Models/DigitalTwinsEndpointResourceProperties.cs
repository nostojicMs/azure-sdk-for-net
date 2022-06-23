// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties related to Digital Twins Endpoint
    /// </summary>
    public partial class DigitalTwinsEndpointResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DigitalTwinsEndpointResourceProperties class.
        /// </summary>
        public DigitalTwinsEndpointResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DigitalTwinsEndpointResourceProperties class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Provisioning', 'Deleting', 'Updating',
        /// 'Succeeded', 'Failed', 'Canceled', 'Deleted', 'Warning',
        /// 'Suspending', 'Restoring', 'Moving', 'Disabled'</param>
        /// <param name="createdTime">Time when the Endpoint was added to
        /// DigitalTwinsInstance.</param>
        /// <param name="authenticationType">Specifies the authentication type
        /// being used for connecting to the endpoint. Defaults to 'KeyBased'.
        /// If 'KeyBased' is selected, a connection string must be specified
        /// (at least the primary connection string). If 'IdentityBased' is
        /// select, the endpointUri and entityPath properties must be
        /// specified. Possible values include: 'KeyBased',
        /// 'IdentityBased'</param>
        /// <param name="deadLetterSecret">Dead letter storage secret for
        /// key-based authentication. Will be obfuscated during read.</param>
        /// <param name="deadLetterUri">Dead letter storage URL for
        /// identity-based authentication.</param>
        public DigitalTwinsEndpointResourceProperties(string provisioningState = default(string), System.DateTime? createdTime = default(System.DateTime?), string authenticationType = default(string), string deadLetterSecret = default(string), string deadLetterUri = default(string))
        {
            ProvisioningState = provisioningState;
            CreatedTime = createdTime;
            AuthenticationType = authenticationType;
            DeadLetterSecret = deadLetterSecret;
            DeadLetterUri = deadLetterUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state. Possible values include:
        /// 'Provisioning', 'Deleting', 'Updating', 'Succeeded', 'Failed',
        /// 'Canceled', 'Deleted', 'Warning', 'Suspending', 'Restoring',
        /// 'Moving', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets time when the Endpoint was added to DigitalTwinsInstance.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets or sets specifies the authentication type being used for
        /// connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased'
        /// is selected, a connection string must be specified (at least the
        /// primary connection string). If 'IdentityBased' is select, the
        /// endpointUri and entityPath properties must be specified. Possible
        /// values include: 'KeyBased', 'IdentityBased'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets dead letter storage secret for key-based
        /// authentication. Will be obfuscated during read.
        /// </summary>
        [JsonProperty(PropertyName = "deadLetterSecret")]
        public string DeadLetterSecret { get; set; }

        /// <summary>
        /// Gets or sets dead letter storage URL for identity-based
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "deadLetterUri")]
        public string DeadLetterUri { get; set; }

    }
}
