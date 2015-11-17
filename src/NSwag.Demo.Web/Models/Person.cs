﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NSwag.Demo.Web.Models
{
    /// <summary>The DTO class for a person.</summary>
    public class Person
    {
        /// <summary>Gets or sets the first name.</summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Car[] Cars { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ObjectType Type { get; set; }
    }
}