/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.9.4
 * Contact: anton.perhunov@aspose.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GroupDocs.Translation.Cloud.Sdk.Client.OpenAPIDateConverter;

namespace GroupDocs.Translation.Cloud.Sdk.Model
{
    /// <summary>
    /// StringStringTuple
    /// </summary>
    [DataContract(Name = "StringStringTuple")]
    public partial class StringStringTuple : IEquatable<StringStringTuple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringStringTuple" /> class.
        /// </summary>
        /// <param name="item1">item1.</param>
        /// <param name="item2">item2.</param>
        public StringStringTuple(string item1 = default(string), string item2 = default(string))
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        /// <summary>
        /// Gets or Sets Item1
        /// </summary>
        [DataMember(Name = "item1", EmitDefaultValue = false)]
        public string Item1 { get; set; }

        /// <summary>
        /// Gets or Sets Item2
        /// </summary>
        [DataMember(Name = "item2", EmitDefaultValue = false)]
        public string Item2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StringStringTuple {\n");
            sb.Append("  Item1: ").Append(Item1).Append("\n");
            sb.Append("  Item2: ").Append(Item2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StringStringTuple);
        }

        /// <summary>
        /// Returns true if StringStringTuple instances are equal
        /// </summary>
        /// <param name="input">Instance of StringStringTuple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringStringTuple input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Item1 == input.Item1 ||
                    (this.Item1 != null &&
                    this.Item1.Equals(input.Item1))
                ) && 
                (
                    this.Item2 == input.Item2 ||
                    (this.Item2 != null &&
                    this.Item2.Equals(input.Item2))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Item1 != null)
                {
                    hashCode = (hashCode * 59) + this.Item1.GetHashCode();
                }
                if (this.Item2 != null)
                {
                    hashCode = (hashCode * 59) + this.Item2.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
