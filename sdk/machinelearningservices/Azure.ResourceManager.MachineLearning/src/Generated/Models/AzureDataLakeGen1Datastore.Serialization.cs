// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AzureDataLakeGen1Datastore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
            {
                writer.WritePropertyName("serviceDataAccessAuthIdentity");
                writer.WriteStringValue(ServiceDataAccessAuthIdentity.Value.ToString());
            }
            writer.WritePropertyName("storeName");
            writer.WriteStringValue(StoreName);
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(Credentials);
            writer.WritePropertyName("datastoreType");
            writer.WriteStringValue(DatastoreType.ToString());
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties");
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags");
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WriteEndObject();
        }

        internal static AzureDataLakeGen1Datastore DeserializeAzureDataLakeGen1Datastore(JsonElement element)
        {
            Optional<ServiceDataAccessAuthIdentity> serviceDataAccessAuthIdentity = default;
            string storeName = default;
            DatastoreCredentials credentials = default;
            DatastoreType datastoreType = default;
            Optional<bool> isDefault = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceDataAccessAuthIdentity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serviceDataAccessAuthIdentity = new ServiceDataAccessAuthIdentity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storeName"))
                {
                    storeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    credentials = DatastoreCredentials.DeserializeDatastoreCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("datastoreType"))
                {
                    datastoreType = new DatastoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDefault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new AzureDataLakeGen1Datastore(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), credentials, datastoreType, Optional.ToNullable(isDefault), Optional.ToNullable(serviceDataAccessAuthIdentity), storeName);
        }
    }
}
