// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CacheExpirationActionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("cacheBehavior");
            writer.WriteStringValue(CacheBehavior.ToString());
            writer.WritePropertyName("cacheType");
            writer.WriteStringValue(CacheType.ToString());
            if (Optional.IsDefined(CacheDuration))
            {
                if (CacheDuration != null)
                {
                    writer.WritePropertyName("cacheDuration");
                    writer.WriteStringValue(CacheDuration.Value, "c");
                }
                else
                {
                    writer.WriteNull("cacheDuration");
                }
            }
            writer.WriteEndObject();
        }

        internal static CacheExpirationActionProperties DeserializeCacheExpirationActionProperties(JsonElement element)
        {
            CacheExpirationActionType typeName = default;
            CacheBehaviorSettings cacheBehavior = default;
            CacheLevel cacheType = default;
            Optional<TimeSpan?> cacheDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new CacheExpirationActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheBehavior"))
                {
                    cacheBehavior = new CacheBehaviorSettings(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheType"))
                {
                    cacheType = new CacheLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cacheDuration = null;
                        continue;
                    }
                    cacheDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
            }
            return new CacheExpirationActionProperties(typeName, cacheBehavior, cacheType, Optional.ToNullable(cacheDuration));
        }
    }
}
