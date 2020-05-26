// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the Network Security Groups effective on a network interface
    /// </summary>
    public partial class EffectiveNetworkSecurityGroups
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroups
        /// class.
        /// </summary>
        public EffectiveNetworkSecurityGroups()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroups
        /// class.
        /// </summary>
        /// <param name="networkInterface">The Azure resource ID of the network
        /// interface</param>
        /// <param name="networkSecurityGroups">The Network Security Groups
        /// effective on the network interface</param>
        public EffectiveNetworkSecurityGroups(string networkInterface = default(string), IList<string> networkSecurityGroups = default(IList<string>))
        {
            NetworkInterface = networkInterface;
            NetworkSecurityGroups = networkSecurityGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure resource ID of the network interface
        /// </summary>
        [JsonProperty(PropertyName = "networkInterface")]
        public string NetworkInterface { get; set; }

        /// <summary>
        /// Gets or sets the Network Security Groups effective on the network
        /// interface
        /// </summary>
        [JsonProperty(PropertyName = "networkSecurityGroups")]
        public IList<string> NetworkSecurityGroups { get; set; }

    }
}
