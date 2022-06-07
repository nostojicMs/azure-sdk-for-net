// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityLinkingTaskResult
    {
        internal static EntityLinkingTaskResult DeserializeEntityLinkingTaskResult(JsonElement element)
        {
            EntityLinkingResult results = default;
            AnalyzeTextTaskResultsKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = EntityLinkingResult.DeserializeEntityLinkingResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
            }
            return new EntityLinkingTaskResult(kind, results);
        }
    }
}
