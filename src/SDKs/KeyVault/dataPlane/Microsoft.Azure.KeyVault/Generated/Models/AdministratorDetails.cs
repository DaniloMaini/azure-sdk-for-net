// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the organization administrator of the certificate issuer.
    /// </summary>
    public partial class AdministratorDetails
    {
        /// <summary>
        /// Initializes a new instance of the AdministratorDetails class.
        /// </summary>
        public AdministratorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdministratorDetails class.
        /// </summary>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        /// <param name="emailAddress">Email addresss.</param>
        /// <param name="phone">Phone number.</param>
        public AdministratorDetails(string firstName = default(string), string lastName = default(string), string emailAddress = default(string), string phone = default(string))
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Phone = phone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets email addresss.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

    }
}
