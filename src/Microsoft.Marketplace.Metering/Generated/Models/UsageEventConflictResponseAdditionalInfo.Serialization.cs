// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Marketplace.Metering.Models
{
    public partial class UsageEventConflictResponseAdditionalInfo
    {
        internal static UsageEventConflictResponseAdditionalInfo DeserializeUsageEventConflictResponseAdditionalInfo(JsonElement element)
        {
            Optional<UsageEventOkResponse> acceptedMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acceptedMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    acceptedMessage = UsageEventOkResponse.DeserializeUsageEventOkResponse(property.Value);
                    continue;
                }
            }
            return new UsageEventConflictResponseAdditionalInfo(acceptedMessage.Value);
        }
    }
}