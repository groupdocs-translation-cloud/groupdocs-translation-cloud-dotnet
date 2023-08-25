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
    /// AutoPostRequest
    /// </summary>
    [DataContract(Name = "_auto_post_request")]
    public partial class AutoPostRequest : IEquatable<AutoPostRequest>, IValidatableObject
    {
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
            /// Enum Doc for value: Doc
            /// </summary>
            [EnumMember(Value = "Doc")]
            Doc = 2,

            /// <summary>
            /// Enum Docx for value: Docx
            /// </summary>
            [EnumMember(Value = "Docx")]
            Docx = 3,

            /// <summary>
            /// Enum Docm for value: Docm
            /// </summary>
            [EnumMember(Value = "Docm")]
            Docm = 4,

            /// <summary>
            /// Enum Xls for value: Xls
            /// </summary>
            [EnumMember(Value = "Xls")]
            Xls = 5,

            /// <summary>
            /// Enum Xlsx for value: Xlsx
            /// </summary>
            [EnumMember(Value = "Xlsx")]
            Xlsx = 6,

            /// <summary>
            /// Enum Xlsm for value: Xlsm
            /// </summary>
            [EnumMember(Value = "Xlsm")]
            Xlsm = 7,

            /// <summary>
            /// Enum Ppt for value: Ppt
            /// </summary>
            [EnumMember(Value = "Ppt")]
            Ppt = 8,

            /// <summary>
            /// Enum Pptx for value: Pptx
            /// </summary>
            [EnumMember(Value = "Pptx")]
            Pptx = 9,

            /// <summary>
            /// Enum Pptm for value: Pptm
            /// </summary>
            [EnumMember(Value = "Pptm")]
            Pptm = 10,

            /// <summary>
            /// Enum Txt for value: Txt
            /// </summary>
            [EnumMember(Value = "Txt")]
            Txt = 11,

            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 12,

            /// <summary>
            /// Enum Md for value: Md
            /// </summary>
            [EnumMember(Value = "Md")]
            Md = 13,

            /// <summary>
            /// Enum Resx for value: Resx
            /// </summary>
            [EnumMember(Value = "Resx")]
            Resx = 14,

            /// <summary>
            /// Enum Html for value: Html
            /// </summary>
            [EnumMember(Value = "Html")]
            Html = 15,

            /// <summary>
            /// Enum Rtf for value: Rtf
            /// </summary>
            [EnumMember(Value = "Rtf")]
            Rtf = 16,

            /// <summary>
            /// Enum Odt for value: Odt
            /// </summary>
            [EnumMember(Value = "Odt")]
            Odt = 17,

            /// <summary>
            /// Enum Ods for value: Ods
            /// </summary>
            [EnumMember(Value = "Ods")]
            Ods = 18,

            /// <summary>
            /// Enum Odp for value: Odp
            /// </summary>
            [EnumMember(Value = "Odp")]
            Odp = 19,

            /// <summary>
            /// Enum Csv for value: Csv
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv = 20,

            /// <summary>
            /// Enum Tsv for value: Tsv
            /// </summary>
            [EnumMember(Value = "Tsv")]
            Tsv = 21

        }


        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "Format", IsRequired = true, EmitDefaultValue = true)]
        public FormatEnum Format { get; set; }
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
        [DataMember(Name = "SavingMode", EmitDefaultValue = false)]
        public SavingModeEnum? SavingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoPostRequest" /> class.
        /// </summary>
        /// <param name="format">format (required) (default to FormatEnum.Unknown).</param>
        /// <param name="outputFormat">outputFormat (required).</param>
        /// <param name="masters">masters (default to false).</param>
        /// <param name="formatting">formatting (default to true).</param>
        /// <param name="route">route.</param>
        /// <param name="separator">separator.</param>
        /// <param name="elements">elements.</param>
        /// <param name="ranges">ranges.</param>
        /// <param name="shortCodeList">shortCodeList.</param>
        /// <param name="frontMatterList">frontMatterList.</param>
        /// <param name="sourceLanguage">sourceLanguage (required) (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">targetLanguages (required).</param>
        /// <param name="file">file.</param>
        /// <param name="originalFileName">originalFileName.</param>
        /// <param name="url">url.</param>
        /// <param name="origin">origin.</param>
        /// <param name="savingMode">savingMode.</param>
        public AutoPostRequest(FormatEnum format = FormatEnum.Unknown, string outputFormat = default(string), bool masters = false, bool formatting = true, string route = default(string), string separator = default(string), List<int> elements = default(List<int>), Dictionary<string, WorksheetData> ranges = default(Dictionary<string, WorksheetData>), Dictionary<string, List<List<string>>> shortCodeList = default(Dictionary<string, List<List<string>>>), List<List<string>> frontMatterList = default(List<List<string>>), string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), byte[] file = default(byte[]), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?))
        {
            this.Format = format;
            // to ensure "outputFormat" is required (not null)
            if (outputFormat == null)
            {
                throw new ArgumentNullException("outputFormat is a required property for AutoPostRequest and cannot be null");
            }
            this.OutputFormat = outputFormat;
            // to ensure "sourceLanguage" is required (not null)
            if (sourceLanguage == null)
            {
                throw new ArgumentNullException("sourceLanguage is a required property for AutoPostRequest and cannot be null");
            }
            this.SourceLanguage = sourceLanguage;
            // to ensure "targetLanguages" is required (not null)
            if (targetLanguages == null)
            {
                throw new ArgumentNullException("targetLanguages is a required property for AutoPostRequest and cannot be null");
            }
            this.TargetLanguages = targetLanguages;
            this.Masters = masters;
            this.Formatting = formatting;
            this.Route = route;
            this.Separator = separator;
            this.Elements = elements;
            this.Ranges = ranges;
            this.ShortCodeList = shortCodeList;
            this.FrontMatterList = frontMatterList;
            this.File = file;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.Origin = origin;
            this.SavingMode = savingMode;
        }

        /// <summary>
        /// Gets or Sets OutputFormat
        /// </summary>
        [DataMember(Name = "OutputFormat", IsRequired = true, EmitDefaultValue = true)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Gets or Sets Masters
        /// </summary>
        [DataMember(Name = "Masters", EmitDefaultValue = true)]
        public bool Masters { get; set; }

        /// <summary>
        /// Gets or Sets Formatting
        /// </summary>
        [DataMember(Name = "Formatting", EmitDefaultValue = true)]
        public bool Formatting { get; set; }

        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        [DataMember(Name = "Route", EmitDefaultValue = false)]
        public string Route { get; set; }

        /// <summary>
        /// Gets or Sets Separator
        /// </summary>
        [DataMember(Name = "Separator", EmitDefaultValue = false)]
        public string Separator { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "Elements", EmitDefaultValue = false)]
        public List<int> Elements { get; set; }

        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name = "Ranges", EmitDefaultValue = false)]
        public Dictionary<string, WorksheetData> Ranges { get; set; }

        /// <summary>
        /// Gets or Sets ShortCodeList
        /// </summary>
        [DataMember(Name = "ShortCodeList", EmitDefaultValue = false)]
        public Dictionary<string, List<List<string>>> ShortCodeList { get; set; }

        /// <summary>
        /// Gets or Sets FrontMatterList
        /// </summary>
        [DataMember(Name = "FrontMatterList", EmitDefaultValue = false)]
        public List<List<string>> FrontMatterList { get; set; }

        /// <summary>
        /// Gets or Sets SourceLanguage
        /// </summary>
        [DataMember(Name = "SourceLanguage", IsRequired = true, EmitDefaultValue = true)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// Gets or Sets TargetLanguages
        /// </summary>
        [DataMember(Name = "TargetLanguages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TargetLanguages { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "File", EmitDefaultValue = false)]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [DataMember(Name = "OriginalFileName", EmitDefaultValue = false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "Url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "Origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoPostRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  Masters: ").Append(Masters).Append("\n");
            sb.Append("  Formatting: ").Append(Formatting).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Separator: ").Append(Separator).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  ShortCodeList: ").Append(ShortCodeList).Append("\n");
            sb.Append("  FrontMatterList: ").Append(FrontMatterList).Append("\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
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
            return this.Equals(input as AutoPostRequest);
        }

        /// <summary>
        /// Returns true if AutoPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.OutputFormat == input.OutputFormat ||
                    (this.OutputFormat != null &&
                    this.OutputFormat.Equals(input.OutputFormat))
                ) && 
                (
                    this.Masters == input.Masters ||
                    this.Masters.Equals(input.Masters)
                ) && 
                (
                    this.Formatting == input.Formatting ||
                    this.Formatting.Equals(input.Formatting)
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
                ) && 
                (
                    this.Separator == input.Separator ||
                    (this.Separator != null &&
                    this.Separator.Equals(input.Separator))
                ) && 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
                ) && 
                (
                    this.Ranges == input.Ranges ||
                    this.Ranges != null &&
                    input.Ranges != null &&
                    this.Ranges.SequenceEqual(input.Ranges)
                ) && 
                (
                    this.ShortCodeList == input.ShortCodeList ||
                    this.ShortCodeList != null &&
                    input.ShortCodeList != null &&
                    this.ShortCodeList.SequenceEqual(input.ShortCodeList)
                ) && 
                (
                    this.FrontMatterList == input.FrontMatterList ||
                    this.FrontMatterList != null &&
                    input.FrontMatterList != null &&
                    this.FrontMatterList.SequenceEqual(input.FrontMatterList)
                ) && 
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
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.OutputFormat != null)
                {
                    hashCode = (hashCode * 59) + this.OutputFormat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Masters.GetHashCode();
                hashCode = (hashCode * 59) + this.Formatting.GetHashCode();
                if (this.Route != null)
                {
                    hashCode = (hashCode * 59) + this.Route.GetHashCode();
                }
                if (this.Separator != null)
                {
                    hashCode = (hashCode * 59) + this.Separator.GetHashCode();
                }
                if (this.Elements != null)
                {
                    hashCode = (hashCode * 59) + this.Elements.GetHashCode();
                }
                if (this.Ranges != null)
                {
                    hashCode = (hashCode * 59) + this.Ranges.GetHashCode();
                }
                if (this.ShortCodeList != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCodeList.GetHashCode();
                }
                if (this.FrontMatterList != null)
                {
                    hashCode = (hashCode * 59) + this.FrontMatterList.GetHashCode();
                }
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
