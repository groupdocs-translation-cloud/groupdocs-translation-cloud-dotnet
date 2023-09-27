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
    /// HealthCheckStatus
    /// </summary>
    [DataContract(Name = "HealthCheckStatus")]
    public partial class HealthCheckStatus : IEquatable<HealthCheckStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckStatus" /> class.
        /// </summary>
        /// <param name="kafkaDeliveryStatus">kafkaDeliveryStatus.</param>
        /// <param name="cloudStatus">cloudStatus.</param>
        public HealthCheckStatus(string kafkaDeliveryStatus = default(string), string cloudStatus = default(string))
        {
            this.KafkaDeliveryStatus = kafkaDeliveryStatus;
            this.CloudStatus = cloudStatus;
        }

        /// <summary>
        /// Gets or Sets KafkaDeliveryStatus
        /// </summary>
        [DataMember(Name = "kafkaDeliveryStatus", EmitDefaultValue = true)]
        public string KafkaDeliveryStatus { get; set; }

        /// <summary>
        /// Gets or Sets CloudStatus
        /// </summary>
        [DataMember(Name = "cloudStatus", EmitDefaultValue = true)]
        public string CloudStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HealthCheckStatus {\n");
            sb.Append("  KafkaDeliveryStatus: ").Append(KafkaDeliveryStatus).Append("\n");
            sb.Append("  CloudStatus: ").Append(CloudStatus).Append("\n");
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
            return this.Equals(input as HealthCheckStatus);
        }

        /// <summary>
        /// Returns true if HealthCheckStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthCheckStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthCheckStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KafkaDeliveryStatus == input.KafkaDeliveryStatus ||
                    (this.KafkaDeliveryStatus != null &&
                    this.KafkaDeliveryStatus.Equals(input.KafkaDeliveryStatus))
                ) && 
                (
                    this.CloudStatus == input.CloudStatus ||
                    (this.CloudStatus != null &&
                    this.CloudStatus.Equals(input.CloudStatus))
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
                if (this.KafkaDeliveryStatus != null)
                {
                    hashCode = (hashCode * 59) + this.KafkaDeliveryStatus.GetHashCode();
                }
                if (this.CloudStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CloudStatus.GetHashCode();
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
