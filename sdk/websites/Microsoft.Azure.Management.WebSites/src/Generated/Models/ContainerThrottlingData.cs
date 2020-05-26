// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ContainerThrottlingData
    {
        /// <summary>
        /// Initializes a new instance of the ContainerThrottlingData class.
        /// </summary>
        public ContainerThrottlingData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerThrottlingData class.
        /// </summary>
        public ContainerThrottlingData(int? periods = default(int?), int? throttledPeriods = default(int?), int? throttledTime = default(int?))
        {
            Periods = periods;
            ThrottledPeriods = throttledPeriods;
            ThrottledTime = throttledTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "periods")]
        public int? Periods { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "throttledPeriods")]
        public int? ThrottledPeriods { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "throttledTime")]
        public int? ThrottledTime { get; set; }

    }
}
