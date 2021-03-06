// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ComputeOperationListResult
    {
        internal static ComputeOperationListResult DeserializeComputeOperationListResult(JsonElement element)
        {
            IReadOnlyList<ComputeOperationValue> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeOperationValue> array = new List<ComputeOperationValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ComputeOperationValue.DeserializeComputeOperationValue(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new ComputeOperationListResult(value);
        }
    }
}
