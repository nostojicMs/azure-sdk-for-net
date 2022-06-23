// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class AzureFileVolume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("shareName");
            writer.WriteStringValue(ShareName);
            if (Optional.IsDefined(ReadOnly))
            {
                writer.WritePropertyName("readOnly");
                writer.WriteBooleanValue(ReadOnly.Value);
            }
            writer.WritePropertyName("storageAccountName");
            writer.WriteStringValue(StorageAccountName);
            if (Optional.IsDefined(StorageAccountKey))
            {
                writer.WritePropertyName("storageAccountKey");
                writer.WriteStringValue(StorageAccountKey);
            }
            writer.WriteEndObject();
        }

        internal static AzureFileVolume DeserializeAzureFileVolume(JsonElement element)
        {
            string shareName = default;
            Optional<bool> readOnly = default;
            string storageAccountName = default;
            Optional<string> storageAccountKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareName"))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageAccountName"))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountKey"))
                {
                    storageAccountKey = property.Value.GetString();
                    continue;
                }
            }
            return new AzureFileVolume(shareName, Optional.ToNullable(readOnly), storageAccountName, storageAccountKey.Value);
        }
    }
}
