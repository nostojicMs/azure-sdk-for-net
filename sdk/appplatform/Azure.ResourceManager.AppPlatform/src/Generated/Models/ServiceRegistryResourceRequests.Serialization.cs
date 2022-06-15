// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ServiceRegistryResourceRequests
    {
        internal static ServiceRegistryResourceRequests DeserializeServiceRegistryResourceRequests(JsonElement element)
        {
            Optional<string> cpu = default;
            Optional<string> memory = default;
            Optional<int> instanceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"))
                {
                    memory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new ServiceRegistryResourceRequests(cpu.Value, memory.Value, Optional.ToNullable(instanceCount));
        }
    }
}
