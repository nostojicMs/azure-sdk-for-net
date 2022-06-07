// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Configuration request object. </summary>
    public partial class ConfigurationsContent
    {
        /// <summary> Initializes a new instance of ConfigurationsContent. </summary>
        /// <param name="configurationFilters"> Holds details about product hierarchy information and filterable property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationFilters"/> is null. </exception>
        public ConfigurationsContent(IEnumerable<ConfigurationFilters> configurationFilters)
        {
            if (configurationFilters == null)
            {
                throw new ArgumentNullException(nameof(configurationFilters));
            }

            ConfigurationFilters = configurationFilters.ToList();
        }

        /// <summary> Holds details about product hierarchy information and filterable property. </summary>
        public IList<ConfigurationFilters> ConfigurationFilters { get; }
        /// <summary> Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing subscription details. </summary>
        public CustomerSubscriptionDetails CustomerSubscriptionDetails { get; set; }
    }
}
