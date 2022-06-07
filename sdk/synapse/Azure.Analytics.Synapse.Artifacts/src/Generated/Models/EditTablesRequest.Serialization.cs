// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(EditTablesRequestConverter))]
    public partial class EditTablesRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LinkTables))
            {
                writer.WritePropertyName("linkTables");
                writer.WriteStartArray();
                foreach (var item in LinkTables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EditTablesRequest DeserializeEditTablesRequest(JsonElement element)
        {
            Optional<IList<LinkTableRequest>> linkTables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkTables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LinkTableRequest> array = new List<LinkTableRequest>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkTableRequest.DeserializeLinkTableRequest(item));
                    }
                    linkTables = array;
                    continue;
                }
            }
            return new EditTablesRequest(Optional.ToList(linkTables));
        }

        internal partial class EditTablesRequestConverter : JsonConverter<EditTablesRequest>
        {
            public override void Write(Utf8JsonWriter writer, EditTablesRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EditTablesRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEditTablesRequest(document.RootElement);
            }
        }
    }
}
