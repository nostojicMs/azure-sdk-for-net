// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class DatabaseColumnData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnType))
            {
                writer.WritePropertyName("columnType");
                writer.WriteStringValue(ColumnType.Value.ToString());
            }
            if (Optional.IsDefined(TemporalType))
            {
                writer.WritePropertyName("temporalType");
                writer.WriteStringValue(TemporalType.Value.ToString());
            }
            if (Optional.IsDefined(MemoryOptimized))
            {
                writer.WritePropertyName("memoryOptimized");
                writer.WriteBooleanValue(MemoryOptimized.Value);
            }
            if (Optional.IsDefined(IsComputed))
            {
                writer.WritePropertyName("isComputed");
                writer.WriteBooleanValue(IsComputed.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DatabaseColumnData DeserializeDatabaseColumnData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ColumnDataType> columnType = default;
            Optional<TableTemporalType> temporalType = default;
            Optional<bool> memoryOptimized = default;
            Optional<bool> isComputed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("columnType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            columnType = new ColumnDataType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("temporalType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            temporalType = new TableTemporalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("memoryOptimized"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            memoryOptimized = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isComputed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isComputed = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DatabaseColumnData(id, name, type, systemData.Value, Optional.ToNullable(columnType), Optional.ToNullable(temporalType), Optional.ToNullable(memoryOptimized), Optional.ToNullable(isComputed));
        }
    }
}
