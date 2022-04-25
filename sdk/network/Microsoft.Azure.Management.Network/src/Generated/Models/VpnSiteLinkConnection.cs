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
    /// VpnSiteLinkConnection Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VpnSiteLinkConnection : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VpnSiteLinkConnection class.
        /// </summary>
        public VpnSiteLinkConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnSiteLinkConnection class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="vpnSiteLink">Id of the connected vpn site
        /// link.</param>
        /// <param name="routingWeight">Routing weight for vpn
        /// connection.</param>
        /// <param name="vpnLinkConnectionMode">Vpn link connection mode.
        /// Possible values include: 'Default', 'ResponderOnly',
        /// 'InitiatorOnly'</param>
        /// <param name="connectionStatus">The connection status. Possible
        /// values include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'</param>
        /// <param name="vpnConnectionProtocolType">Connection protocol used
        /// for this connection. Possible values include: 'IKEv2',
        /// 'IKEv1'</param>
        /// <param name="ingressBytesTransferred">Ingress bytes
        /// transferred.</param>
        /// <param name="egressBytesTransferred">Egress bytes
        /// transferred.</param>
        /// <param name="connectionBandwidth">Expected bandwidth in
        /// MBPS.</param>
        /// <param name="sharedKey">SharedKey for the vpn connection.</param>
        /// <param name="enableBgp">EnableBgp flag.</param>
        /// <param
        /// name="vpnGatewayCustomBgpAddresses">vpnGatewayCustomBgpAddresses
        /// used by this connection.</param>
        /// <param name="usePolicyBasedTrafficSelectors">Enable policy-based
        /// traffic selectors.</param>
        /// <param name="ipsecPolicies">The IPSec Policies to be considered by
        /// this connection.</param>
        /// <param name="enableRateLimiting">EnableBgp flag.</param>
        /// <param name="useLocalAzureIpAddress">Use local azure ip to initiate
        /// connection.</param>
        /// <param name="provisioningState">The provisioning state of the VPN
        /// site link connection resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="ingressNatRules">List of ingress NatRules.</param>
        /// <param name="egressNatRules">List of egress NatRules.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Resource type.</param>
        public VpnSiteLinkConnection(string id = default(string), SubResource vpnSiteLink = default(SubResource), int? routingWeight = default(int?), string vpnLinkConnectionMode = default(string), string connectionStatus = default(string), string vpnConnectionProtocolType = default(string), long? ingressBytesTransferred = default(long?), long? egressBytesTransferred = default(long?), int? connectionBandwidth = default(int?), string sharedKey = default(string), bool? enableBgp = default(bool?), IList<GatewayCustomBgpIpAddressIpConfiguration> vpnGatewayCustomBgpAddresses = default(IList<GatewayCustomBgpIpAddressIpConfiguration>), bool? usePolicyBasedTrafficSelectors = default(bool?), IList<IpsecPolicy> ipsecPolicies = default(IList<IpsecPolicy>), bool? enableRateLimiting = default(bool?), bool? useLocalAzureIpAddress = default(bool?), string provisioningState = default(string), IList<SubResource> ingressNatRules = default(IList<SubResource>), IList<SubResource> egressNatRules = default(IList<SubResource>), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            VpnSiteLink = vpnSiteLink;
            RoutingWeight = routingWeight;
            VpnLinkConnectionMode = vpnLinkConnectionMode;
            ConnectionStatus = connectionStatus;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            ConnectionBandwidth = connectionBandwidth;
            SharedKey = sharedKey;
            EnableBgp = enableBgp;
            VpnGatewayCustomBgpAddresses = vpnGatewayCustomBgpAddresses;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            EnableRateLimiting = enableRateLimiting;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            ProvisioningState = provisioningState;
            IngressNatRules = ingressNatRules;
            EgressNatRules = egressNatRules;
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
        /// Gets or sets id of the connected vpn site link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnSiteLink")]
        public SubResource VpnSiteLink { get; set; }

        /// <summary>
        /// Gets or sets routing weight for vpn connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets vpn link connection mode. Possible values include:
        /// 'Default', 'ResponderOnly', 'InitiatorOnly'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnLinkConnectionMode")]
        public string VpnLinkConnectionMode { get; set; }

        /// <summary>
        /// Gets or sets the connection status. Possible values include:
        /// 'Unknown', 'Connecting', 'Connected', 'NotConnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or sets connection protocol used for this connection. Possible
        /// values include: 'IKEv2', 'IKEv1'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnConnectionProtocolType")]
        public string VpnConnectionProtocolType { get; set; }

        /// <summary>
        /// Gets ingress bytes transferred.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets egress bytes transferred.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets or sets expected bandwidth in MBPS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionBandwidth")]
        public int? ConnectionBandwidth { get; set; }

        /// <summary>
        /// Gets or sets sharedKey for the vpn connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets vpnGatewayCustomBgpAddresses used by this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayCustomBgpAddresses")]
        public IList<GatewayCustomBgpIpAddressIpConfiguration> VpnGatewayCustomBgpAddresses { get; set; }

        /// <summary>
        /// Gets or sets enable policy-based traffic selectors.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usePolicyBasedTrafficSelectors")]
        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        /// <summary>
        /// Gets or sets the IPSec Policies to be considered by this
        /// connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsecPolicies")]
        public IList<IpsecPolicy> IpsecPolicies { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableRateLimiting")]
        public bool? EnableRateLimiting { get; set; }

        /// <summary>
        /// Gets or sets use local azure ip to initiate connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.useLocalAzureIpAddress")]
        public bool? UseLocalAzureIpAddress { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VPN site link connection
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets list of ingress NatRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressNatRules")]
        public IList<SubResource> IngressNatRules { get; set; }

        /// <summary>
        /// Gets or sets list of egress NatRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressNatRules")]
        public IList<SubResource> EgressNatRules { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
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
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
