// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This resource defines the range of IP addresses from which addresses
    /// are  allocated for nodes within a subnet.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IpPool : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IpPool class.
        /// </summary>
        public IpPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpPool class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="startIpAddress">The starting IP address.</param>
        /// <param name="endIpAddress">The ending IP address.</param>
        /// <param name="addressPrefix">The address prefix.</param>
        /// <param name="numberOfIpAddresses">The total number of IP
        /// addresses.</param>
        /// <param name="numberOfAllocatedIpAddresses">The number of currently
        /// allocated IP addresses.</param>
        /// <param name="numberOfIpAddressesInTransition">The current number of
        /// IP addresses in transition.</param>
        public IpPool(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string startIpAddress = default(string), string endIpAddress = default(string), string addressPrefix = default(string), long? numberOfIpAddresses = default(long?), long? numberOfAllocatedIpAddresses = default(long?), long? numberOfIpAddressesInTransition = default(long?))
            : base(id, name, type, location, tags)
        {
            StartIpAddress = startIpAddress;
            EndIpAddress = endIpAddress;
            AddressPrefix = addressPrefix;
            NumberOfIpAddresses = numberOfIpAddresses;
            NumberOfAllocatedIpAddresses = numberOfAllocatedIpAddresses;
            NumberOfIpAddressesInTransition = numberOfIpAddressesInTransition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the starting IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startIpAddress")]
        public string StartIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the ending IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endIpAddress")]
        public string EndIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the total number of IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfIpAddresses")]
        public long? NumberOfIpAddresses { get; set; }

        /// <summary>
        /// Gets or sets the number of currently allocated IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfAllocatedIpAddresses")]
        public long? NumberOfAllocatedIpAddresses { get; set; }

        /// <summary>
        /// Gets or sets the current number of IP addresses in transition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfIpAddressesInTransition")]
        public long? NumberOfIpAddressesInTransition { get; set; }

    }
}
