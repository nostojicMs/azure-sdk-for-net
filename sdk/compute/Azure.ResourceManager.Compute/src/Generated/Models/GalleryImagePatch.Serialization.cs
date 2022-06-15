// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImagePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula");
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri");
                writer.WriteStringValue(PrivacyStatementUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ReleaseNoteUri))
            {
                writer.WritePropertyName("releaseNoteUri");
                writer.WriteStringValue(ReleaseNoteUri.AbsoluteUri);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (Optional.IsDefined(OSState))
            {
                writer.WritePropertyName("osState");
                writer.WriteStringValue(OSState.Value.ToSerialString());
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier");
                writer.WriteObjectValue(Identifier);
            }
            if (Optional.IsDefined(Recommended))
            {
                writer.WritePropertyName("recommended");
                writer.WriteObjectValue(Recommended);
            }
            if (Optional.IsDefined(Disallowed))
            {
                writer.WritePropertyName("disallowed");
                writer.WriteObjectValue(Disallowed);
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan");
                writer.WriteObjectValue(PurchasePlan);
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features");
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture");
                writer.WriteStringValue(Architecture.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
