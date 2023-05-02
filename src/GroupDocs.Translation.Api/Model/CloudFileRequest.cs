/*
 * GroupDocs.Translation.ApiGateway.Web
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = GroupDocs.Translation.Api.Client.OpenAPIDateConverter;

namespace GroupDocs.Translation.Api.Model
{
    /// <summary>
    /// CloudFileRequest
    /// </summary>
    [DataContract(Name = "CloudFileRequest")]
    public partial class CloudFileRequest : IEquatable<CloudFileRequest>, IValidatableObject
    {
        /// <summary>
        /// Toggle files saving mode
        /// </summary>
        /// <value>Toggle files saving mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SavingModeEnum
        {
            /// <summary>
            /// Enum Files for value: Files
            /// </summary>
            [EnumMember(Value = "Files")]
            Files = 1,

            /// <summary>
            /// Enum Archive for value: Archive
            /// </summary>
            [EnumMember(Value = "Archive")]
            Archive = 2,

            /// <summary>
            /// Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")]
            Both = 3

        }


        /// <summary>
        /// Toggle files saving mode
        /// </summary>
        /// <value>Toggle files saving mode</value>
        [DataMember(Name = "savingMode", EmitDefaultValue = false)]
        public SavingModeEnum? SavingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudFileRequest" /> class.
        /// </summary>
        /// <param name="format">\&quot;doc(x|m)\&quot; if Word document, \&quot;xls(x|m)\&quot; if Excel workbook.</param>
        /// <param name="outformat">output file format.</param>
        /// <param name="requestId">id of request.</param>
        /// <param name="ids">Language pairs to translate.</param>
        /// <param name="url">Link to file for translation.</param>
        /// <param name="masters">If translate master slides.</param>
        /// <param name="origin">for analysis only.</param>
        /// <param name="elements">List of slides to translate.</param>
        /// <param name="originalName">Original name of file.</param>
        /// <param name="savingMode">Toggle files saving mode.</param>
        /// <param name="details">Details of the requests. Using for e2e tracking.</param>
        /// <param name="formatting">If document&#39;s formatting should be preserved, default true.</param>
        public CloudFileRequest(string format = default(string), string outformat = default(string), string requestId = default(string), List<int> ids = default(List<int>), string url = default(string), bool masters = default(bool), string origin = default(string), List<int> elements = default(List<int>), string originalName = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), Dictionary<string, string> details = default(Dictionary<string, string>), bool formatting = default(bool))
        {
            this.Format = format;
            this.Outformat = outformat;
            this.RequestId = requestId;
            this.Ids = ids;
            this.Url = url;
            this.Masters = masters;
            this.Origin = origin;
            this.Elements = elements;
            this.OriginalName = originalName;
            this.SavingMode = savingMode;
            this.Details = details;
            this.Formatting = formatting;
        }

        /// <summary>
        /// \&quot;doc(x|m)\&quot; if Word document, \&quot;xls(x|m)\&quot; if Excel workbook
        /// </summary>
        /// <value>\&quot;doc(x|m)\&quot; if Word document, \&quot;xls(x|m)\&quot; if Excel workbook</value>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// output file format
        /// </summary>
        /// <value>output file format</value>
        [DataMember(Name = "outformat", EmitDefaultValue = true)]
        public string Outformat { get; set; }

        /// <summary>
        /// id of request
        /// </summary>
        /// <value>id of request</value>
        [DataMember(Name = "request_id", EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Language pairs to translate
        /// </summary>
        /// <value>Language pairs to translate</value>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Link to file for translation
        /// </summary>
        /// <value>Link to file for translation</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// If translate master slides
        /// </summary>
        /// <value>If translate master slides</value>
        [DataMember(Name = "masters", EmitDefaultValue = true)]
        public bool Masters { get; set; }

        /// <summary>
        /// for analysis only
        /// </summary>
        /// <value>for analysis only</value>
        [DataMember(Name = "origin", EmitDefaultValue = true)]
        public string Origin { get; set; }

        /// <summary>
        /// List of slides to translate
        /// </summary>
        /// <value>List of slides to translate</value>
        [DataMember(Name = "elements", EmitDefaultValue = true)]
        public List<int> Elements { get; set; }

        /// <summary>
        /// Original name of file
        /// </summary>
        /// <value>Original name of file</value>
        [DataMember(Name = "originalName", EmitDefaultValue = true)]
        public string OriginalName { get; set; }

        /// <summary>
        /// Details of the requests. Using for e2e tracking
        /// </summary>
        /// <value>Details of the requests. Using for e2e tracking</value>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public Dictionary<string, string> Details { get; set; }

        /// <summary>
        /// If document&#39;s formatting should be preserved, default true
        /// </summary>
        /// <value>If document&#39;s formatting should be preserved, default true</value>
        [DataMember(Name = "formatting", EmitDefaultValue = true)]
        public bool Formatting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CloudFileRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Outformat: ").Append(Outformat).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Masters: ").Append(Masters).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Formatting: ").Append(Formatting).Append("\n");
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
            return this.Equals(input as CloudFileRequest);
        }

        /// <summary>
        /// Returns true if CloudFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudFileRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Outformat == input.Outformat ||
                    (this.Outformat != null &&
                    this.Outformat.Equals(input.Outformat))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Masters == input.Masters ||
                    this.Masters.Equals(input.Masters)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                ) && 
                (
                    this.SavingMode == input.SavingMode ||
                    this.SavingMode.Equals(input.SavingMode)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Formatting == input.Formatting ||
                    this.Formatting.Equals(input.Formatting)
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
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }
                if (this.Outformat != null)
                {
                    hashCode = (hashCode * 59) + this.Outformat.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Masters.GetHashCode();
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.Elements != null)
                {
                    hashCode = (hashCode * 59) + this.Elements.GetHashCode();
                }
                if (this.OriginalName != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SavingMode.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Formatting.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
