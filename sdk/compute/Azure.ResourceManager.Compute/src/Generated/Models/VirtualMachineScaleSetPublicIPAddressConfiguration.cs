// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration. </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetPublicIPAddressConfiguration. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualMachineScaleSetPublicIPAddressConfiguration(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            IPTags = new ChangeTrackingList<VirtualMachineScaleSetIPTag>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetPublicIPAddressConfiguration. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <param name="sku"> Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the publicIP addresses . </param>
        /// <param name="ipTags"> The list of IP tags associated with the public IP address. </param>
        /// <param name="publicIPPrefix"> The PublicIPPrefix from which to allocate publicIP addresses. </param>
        /// <param name="publicIPAddressVersion"> Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;. </param>
        /// <param name="deleteOption"> Specify what happens to the public IP when the VM is deleted. </param>
        internal VirtualMachineScaleSetPublicIPAddressConfiguration(string name, PublicIPAddressSku sku, int? idleTimeoutInMinutes, VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings, IList<VirtualMachineScaleSetIPTag> ipTags, WritableSubResource publicIPPrefix, IPVersion? publicIPAddressVersion, DeleteOption? deleteOption)
        {
            Name = name;
            Sku = sku;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
            IPTags = ipTags;
            PublicIPPrefix = publicIPPrefix;
            PublicIPAddressVersion = publicIPAddressVersion;
            DeleteOption = deleteOption;
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible. </summary>
        public PublicIPAddressSku Sku { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The dns settings to be applied on the publicIP addresses . </summary>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public string DnsDomainNameLabel
        {
            get => DnsSettings is null ? default : DnsSettings.DomainNameLabel;
            set => DnsSettings = new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(value);
        }

        /// <summary> The list of IP tags associated with the public IP address. </summary>
        public IList<VirtualMachineScaleSetIPTag> IPTags { get; }
        /// <summary> The PublicIPPrefix from which to allocate publicIP addresses. </summary>
        internal WritableSubResource PublicIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPPrefixId
        {
            get => PublicIPPrefix is null ? default : PublicIPPrefix.Id;
            set
            {
                if (PublicIPPrefix is null)
                    PublicIPPrefix = new WritableSubResource();
                PublicIPPrefix.Id = value;
            }
        }

        /// <summary> Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;. </summary>
        public IPVersion? PublicIPAddressVersion { get; set; }
        /// <summary> Specify what happens to the public IP when the VM is deleted. </summary>
        public DeleteOption? DeleteOption { get; set; }
    }
}
