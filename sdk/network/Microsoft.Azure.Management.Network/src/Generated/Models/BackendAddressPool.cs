// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Pool of backend IP addresses.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackendAddressPool : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the BackendAddressPool class.
        /// </summary>
        public BackendAddressPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendAddressPool class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="location">The location of the backend address
        /// pool.</param>
        /// <param name="tunnelInterfaces">An array of gateway load balancer
        /// tunnel interfaces.</param>
        /// <param name="loadBalancerBackendAddresses">An array of backend
        /// addresses.</param>
        /// <param name="backendIPConfigurations">An array of references to IP
        /// addresses defined in network interfaces.</param>
        /// <param name="loadBalancingRules">An array of references to load
        /// balancing rules that use this backend address pool.</param>
        /// <param name="outboundRule">A reference to an outbound rule that
        /// uses this backend address pool.</param>
        /// <param name="outboundRules">An array of references to outbound
        /// rules that use this backend address pool.</param>
        /// <param name="inboundNatRules">An array of references to inbound NAT
        /// rules that use this backend address pool.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// backend address pool resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="drainPeriodInSeconds">Amount of seconds Load Balancer
        /// waits for before sending RESET to client and backend
        /// address.</param>
        /// <param name="name">The name of the resource that is unique within
        /// the set of backend address pools used by the load balancer. This
        /// name can be used to access the resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public BackendAddressPool(string id = default(string), string location = default(string), IList<GatewayLoadBalancerTunnelInterface> tunnelInterfaces = default(IList<GatewayLoadBalancerTunnelInterface>), IList<LoadBalancerBackendAddress> loadBalancerBackendAddresses = default(IList<LoadBalancerBackendAddress>), IList<NetworkInterfaceIPConfiguration> backendIPConfigurations = default(IList<NetworkInterfaceIPConfiguration>), IList<SubResource> loadBalancingRules = default(IList<SubResource>), SubResource outboundRule = default(SubResource), IList<SubResource> outboundRules = default(IList<SubResource>), IList<SubResource> inboundNatRules = default(IList<SubResource>), string provisioningState = default(string), int? drainPeriodInSeconds = default(int?), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Location = location;
            TunnelInterfaces = tunnelInterfaces;
            LoadBalancerBackendAddresses = loadBalancerBackendAddresses;
            BackendIPConfigurations = backendIPConfigurations;
            LoadBalancingRules = loadBalancingRules;
            OutboundRule = outboundRule;
            OutboundRules = outboundRules;
            InboundNatRules = inboundNatRules;
            ProvisioningState = provisioningState;
            DrainPeriodInSeconds = drainPeriodInSeconds;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the backend address pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets an array of gateway load balancer tunnel interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tunnelInterfaces")]
        public IList<GatewayLoadBalancerTunnelInterface> TunnelInterfaces { get; set; }

        /// <summary>
        /// Gets or sets an array of backend addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerBackendAddresses")]
        public IList<LoadBalancerBackendAddress> LoadBalancerBackendAddresses { get; set; }

        /// <summary>
        /// Gets an array of references to IP addresses defined in network
        /// interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendIPConfigurations")]
        public IList<NetworkInterfaceIPConfiguration> BackendIPConfigurations { get; private set; }

        /// <summary>
        /// Gets an array of references to load balancing rules that use this
        /// backend address pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<SubResource> LoadBalancingRules { get; private set; }

        /// <summary>
        /// Gets a reference to an outbound rule that uses this backend address
        /// pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundRule")]
        public SubResource OutboundRule { get; private set; }

        /// <summary>
        /// Gets an array of references to outbound rules that use this backend
        /// address pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundRules")]
        public IList<SubResource> OutboundRules { get; private set; }

        /// <summary>
        /// Gets an array of references to inbound NAT rules that use this
        /// backend address pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatRules")]
        public IList<SubResource> InboundNatRules { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the backend address pool resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets amount of seconds Load Balancer waits for before
        /// sending RESET to client and backend address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.drainPeriodInSeconds")]
        public int? DrainPeriodInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within the set
        /// of backend address pools used by the load balancer. This name can
        /// be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
