// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ThroughputSettingsPropertiesResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Throughput))
            {
                writer.WritePropertyName("throughput");
                writer.WriteNumberValue(Throughput.Value);
            }
            if (Optional.IsDefined(AutoscaleSettings))
            {
                writer.WritePropertyName("autoscaleSettings");
                writer.WriteObjectValue(AutoscaleSettings);
            }
            writer.WriteEndObject();
        }

        internal static ThroughputSettingsPropertiesResource DeserializeThroughputSettingsPropertiesResource(JsonElement element)
        {
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            Optional<int> throughput = default;
            Optional<AutoscaleSettingsResource> autoscaleSettings = default;
            Optional<string> minimumThroughput = default;
            Optional<string> offerReplacePending = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("throughput"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettingsResource.DeserializeAutoscaleSettingsResource(property.Value);
                    continue;
                }
                if (property.NameEquals("minimumThroughput"))
                {
                    minimumThroughput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerReplacePending"))
                {
                    offerReplacePending = property.Value.GetString();
                    continue;
                }
            }
            return new ThroughputSettingsPropertiesResource(Optional.ToNullable(throughput), autoscaleSettings.Value, minimumThroughput.Value, offerReplacePending.Value, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }
    }
}
