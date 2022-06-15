// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class DeploymentInstance
    {
        internal static DeploymentInstance DeserializeDeploymentInstance(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> status = default;
            Optional<string> reason = default;
            Optional<string> discoveryStatus = default;
            Optional<string> startTime = default;
            Optional<string> zone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryStatus"))
                {
                    discoveryStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zone"))
                {
                    zone = property.Value.GetString();
                    continue;
                }
            }
            return new DeploymentInstance(name.Value, status.Value, reason.Value, discoveryStatus.Value, startTime.Value, zone.Value);
        }
    }
}
