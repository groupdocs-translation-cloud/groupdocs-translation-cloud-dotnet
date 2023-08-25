/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.8.2
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
    /// CsvFileRequest
    /// </summary>
    [DataContract(Name = "CsvFileRequest")]
    public partial class CsvFileRequest : IEquatable<CsvFileRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines SavingMode
        /// </summary>
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
        /// Gets or Sets SavingMode
        /// </summary>
        [DataMember(Name = "savingMode", EmitDefaultValue = false)]
        public SavingModeEnum? SavingMode { get; set; }
        /// <summary>
        /// Defines Format
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Csv for value: Csv
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv = 2,

            /// <summary>
            /// Enum Tsv for value: Tsv
            /// </summary>
            [EnumMember(Value = "Tsv")]
            Tsv = 3

        }


        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CsvFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvFileRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">sourceLanguage (required) (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">targetLanguages (required).</param>
        /// <param name="file">file.</param>
        /// <param name="originalFileName">originalFileName.</param>
        /// <param name="url">url.</param>
        /// <param name="origin">origin.</param>
        /// <param name="savingMode">savingMode.</param>
        /// <param name="format">format (default to FormatEnum.Csv).</param>
        /// <param name="outFormat">outFormat (required).</param>
        /// <param name="separator">separator.</param>
        public CsvFileRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), byte[] file = default(byte[]), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), FormatEnum? format = FormatEnum.Csv, string outFormat = default(string), string separator = default(string))
        {
            // to ensure "sourceLanguage" is required (not null)
            if (sourceLanguage == null)
            {
                throw new ArgumentNullException("sourceLanguage is a required property for CsvFileRequest and cannot be null");
            }
            this.SourceLanguage = sourceLanguage;
            // to ensure "targetLanguages" is required (not null)
            if (targetLanguages == null)
            {
                throw new ArgumentNullException("targetLanguages is a required property for CsvFileRequest and cannot be null");
            }
            this.TargetLanguages = targetLanguages;
            // to ensure "outFormat" is required (not null)
            if (outFormat == null)
            {
                throw new ArgumentNullException("outFormat is a required property for CsvFileRequest and cannot be null");
            }
            this.OutFormat = outFormat;
            this.File = file;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.Origin = origin;
            this.SavingMode = savingMode;
            this.Format = format;
            this.Separator = separator;
        }

        /// <summary>
        /// Gets or Sets SourceLanguage
        /// </summary>
        [DataMember(Name = "sourceLanguage", IsRequired = true, EmitDefaultValue = true)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// Gets or Sets TargetLanguages
        /// </summary>
        [DataMember(Name = "targetLanguages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TargetLanguages { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [DataMember(Name = "originalFileName", EmitDefaultValue = true)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = true)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets OutFormat
        /// </summary>
        [DataMember(Name = "outFormat", IsRequired = true, EmitDefaultValue = true)]
        public string OutFormat { get; set; }

        /// <summary>
        /// Gets or Sets Separator
        /// </summary>
        [DataMember(Name = "separator", EmitDefaultValue = true)]
        public string Separator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CsvFileRequest {\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  OutFormat: ").Append(OutFormat).Append("\n");
            sb.Append("  Separator: ").Append(Separator).Append("\n");
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
            return this.Equals(input as CsvFileRequest);
        }

        /// <summary>
        /// Returns true if CsvFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CsvFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvFileRequest input)
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
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.OutFormat == input.OutFormat ||
                    (this.OutFormat != null &&
                    this.OutFormat.Equals(input.OutFormat))
                ) && 
                (
                    this.Separator == input.Separator ||
                    (this.Separator != null &&
                    this.Separator.Equals(input.Separator))
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
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.OutFormat != null)
                {
                    hashCode = (hashCode * 59) + this.OutFormat.GetHashCode();
                }
                if (this.Separator != null)
                {
                    hashCode = (hashCode * 59) + this.Separator.GetHashCode();
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

            // OutFormat (string) minLength
            if (this.OutFormat != null && this.OutFormat.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutFormat, length must be greater than 1.", new [] { "OutFormat" });
            }

            yield break;
        }
    }

}
