// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class RenewPropertiesResponse
    {
        internal static RenewPropertiesResponse DeserializeRenewPropertiesResponse(JsonElement element)
        {
            Optional<PurchaseRequestContent> purchaseProperties = default;
            Optional<RenewPropertiesResponsePricingCurrencyTotal> pricingCurrencyTotal = default;
            Optional<RenewPropertiesResponseBillingCurrencyTotal> billingCurrencyTotal = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purchaseProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    purchaseProperties = PurchaseRequestContent.DeserializePurchaseRequestContent(property.Value);
                    continue;
                }
                if (property.NameEquals("pricingCurrencyTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pricingCurrencyTotal = RenewPropertiesResponsePricingCurrencyTotal.DeserializeRenewPropertiesResponsePricingCurrencyTotal(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingCurrencyTotal = RenewPropertiesResponseBillingCurrencyTotal.DeserializeRenewPropertiesResponseBillingCurrencyTotal(property.Value);
                    continue;
                }
            }
            return new RenewPropertiesResponse(purchaseProperties.Value, pricingCurrencyTotal.Value, billingCurrencyTotal.Value);
        }
    }
}
