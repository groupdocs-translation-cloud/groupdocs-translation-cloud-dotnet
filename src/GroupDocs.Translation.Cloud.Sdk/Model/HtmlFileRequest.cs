/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 24.3.0
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
    /// Request for HTML files
    /// </summary>
    [DataContract(Name = "HtmlFileRequest")]
    public partial class HtmlFileRequest : IEquatable<HtmlFileRequest>, IValidatableObject
    {
        /// <summary>
        /// Toggle file saving mode for storage.  Is Files by default.
        /// </summary>
        /// <value>Toggle file saving mode for storage.  Is Files by default.</value>
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
        /// Toggle file saving mode for storage.  Is Files by default.
        /// </summary>
        /// <value>Toggle file saving mode for storage.  Is Files by default.</value>
        [DataMember(Name = "savingMode", EmitDefaultValue = false)]
        public SavingModeEnum? SavingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlFileRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">Language of original file (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">List of target languages.</param>
        /// <param name="file">File as byte array.</param>
        /// <param name="originalFileName">Type in the file name. If null will be as request ID..</param>
        /// <param name="url">Link to file for translation. Ignore, if \&quot;file\&quot; property not null.</param>
        /// <param name="origin">Url or name of application using this SDK. Not required..</param>
        /// <param name="savingMode">Toggle file saving mode for storage.  Is Files by default..</param>
        /// <param name="outputFormat">output file format.</param>
        public HtmlFileRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), byte[] file = default(byte[]), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), string outputFormat = default(string))
        {
            // use default value if no "sourceLanguage" provided
            this.SourceLanguage = sourceLanguage ?? @"en";
            this.TargetLanguages = targetLanguages;
            this.File = file;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.Origin = origin;
            this.SavingMode = savingMode;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Language of original file
        /// </summary>
        /// <value>Language of original file</value>
        [DataMember(Name = "sourceLanguage", EmitDefaultValue = false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// List of target languages
        /// </summary>
        /// <value>List of target languages</value>
        [DataMember(Name = "targetLanguages", EmitDefaultValue = false)]
        public List<string> TargetLanguages { get; set; }

        /// <summary>
        /// File as byte array
        /// </summary>
        /// <value>File as byte array</value>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public byte[] File { get; set; }

        /// <summary>
        /// Type in the file name. If null will be as request ID.
        /// </summary>
        /// <value>Type in the file name. If null will be as request ID.</value>
        [DataMember(Name = "originalFileName", EmitDefaultValue = true)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Link to file for translation. Ignore, if \&quot;file\&quot; property not null
        /// </summary>
        /// <value>Link to file for translation. Ignore, if \&quot;file\&quot; property not null</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Url or name of application using this SDK. Not required.
        /// </summary>
        /// <value>Url or name of application using this SDK. Not required.</value>
        [DataMember(Name = "origin", EmitDefaultValue = true)]
        public string Origin { get; set; }

        /// <summary>
        /// output file format
        /// </summary>
        /// <value>output file format</value>
        [DataMember(Name = "outputFormat", EmitDefaultValue = false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HtmlFileRequest {\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
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
            return this.Equals(input as HtmlFileRequest);
        }

        /// <summary>
        /// Returns true if HtmlFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlFileRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceLanguage == input.SourceLanguage ||
                    (this.SourceLanguage != null &&
                    this.SourceLanguage.Equals(input.SourceLanguage))
                ) && 
                (
                    this.TargetLanguages == input.TargetLanguages ||
                    this.TargetLanguages != null &&
                    input.TargetLanguages != null &&
                    this.TargetLanguages.SequenceEqual(input.TargetLanguages)
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.OriginalFileName == input.OriginalFileName ||
                    (this.OriginalFileName != null &&
                    this.OriginalFileName.Equals(input.OriginalFileName))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.SavingMode == input.SavingMode ||
                    this.SavingMode.Equals(input.SavingMode)
                ) && 
                (
                    this.OutputFormat == input.OutputFormat ||
                    (this.OutputFormat != null &&
                    this.OutputFormat.Equals(input.OutputFormat))
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
                if (this.SourceLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.SourceLanguage.GetHashCode();
                }
                if (this.TargetLanguages != null)
                {
                    hashCode = (hashCode * 59) + this.TargetLanguages.GetHashCode();
                }
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                if (this.OriginalFileName != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalFileName.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SavingMode.GetHashCode();
                if (this.OutputFormat != null)
                {
                    hashCode = (hashCode * 59) + this.OutputFormat.GetHashCode();
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
            // SourceLanguage (string) minLength
            if (this.SourceLanguage != null && this.SourceLanguage.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceLanguage, length must be greater than 1.", new [] { "SourceLanguage" });
            }

            // OutputFormat (string) minLength
            if (this.OutputFormat != null && this.OutputFormat.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutputFormat, length must be greater than 1.", new [] { "OutputFormat" });
            }

            yield break;
        }
    }

}
