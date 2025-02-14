/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 24.11.0
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
    /// Request for files with textual content (doc, docx, docm, rtf, odt, txt
    /// </summary>
    [DataContract(Name = "TextDocumentFileRequest")]
    public partial class TextDocumentFileRequest : IValidatableObject
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
        /// Input file format
        /// </summary>
        /// <value>Input file format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,

            /// <summary>
            /// Enum Doc for value: Doc
            /// </summary>
            [EnumMember(Value = "Doc")]
            Doc,

            /// <summary>
            /// Enum Docx for value: Docx
            /// </summary>
            [EnumMember(Value = "Docx")]
            Docx,

            /// <summary>
            /// Enum Docm for value: Docm
            /// </summary>
            [EnumMember(Value = "Docm")]
            Docm,

            /// <summary>
            /// Enum Txt for value: Txt
            /// </summary>
            [EnumMember(Value = "Txt")]
            Txt,

            /// <summary>
            /// Enum Rtf for value: Rtf
            /// </summary>
            [EnumMember(Value = "Rtf")]
            Rtf,

            /// <summary>
            /// Enum Odt for value: Odt
            /// </summary>
            [EnumMember(Value = "Odt")]
            Odt
        }


        /// <summary>
        /// Input file format
        /// </summary>
        /// <value>Input file format</value>
        /*
        <example>Unknown</example>
        */
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextDocumentFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextDocumentFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextDocumentFileRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">Language of original file (required) (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">List of target languages (required).</param>
        /// <param name="originalFileName">Type in the file name. If null will be as request ID..</param>
        /// <param name="url">Link to file for translation. Ignore, if \&quot;file\&quot; property not null.</param>
        /// <param name="savingMode">Toggle file saving mode for storage.  Is Files by default..</param>
        /// <param name="format">Input file format (required) (default to FormatEnum.Docx).</param>
        /// <param name="outputFormat">output file format (required).</param>
        /// <param name="preserveFormatting">If document&#39;s formatting should be preserved, default true (default to true).</param>
        /// <param name="origin">for analysis only.</param>
        /// <param name="pages">Choose pages for translation (1-based index). If not present, translate all pages.</param>
        public TextDocumentFileRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), string originalFileName = default(string), string url = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), FormatEnum format = FormatEnum.Docx, string outputFormat = default(string), bool preserveFormatting = true, string origin = default(string), List<int> pages = default(List<int>))
        {
            // to ensure "sourceLanguage" is required (not null)
            if (sourceLanguage == null)
            {
                throw new ArgumentNullException("sourceLanguage is a required property for TextDocumentFileRequest and cannot be null");
            }
            this.SourceLanguage = sourceLanguage;
            // to ensure "targetLanguages" is required (not null)
            if (targetLanguages == null)
            {
                throw new ArgumentNullException("targetLanguages is a required property for TextDocumentFileRequest and cannot be null");
            }
            this.TargetLanguages = targetLanguages;
            this.Format = format;
            // to ensure "outputFormat" is required (not null)
            if (outputFormat == null)
            {
                throw new ArgumentNullException("outputFormat is a required property for TextDocumentFileRequest and cannot be null");
            }
            this.OutputFormat = outputFormat;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.SavingMode = savingMode;
            this.PreserveFormatting = preserveFormatting;
            this.Origin = origin;
            this.Pages = pages;
        }

        /// <summary>
        /// Language of original file
        /// </summary>
        /// <value>Language of original file</value>
        [DataMember(Name = "sourceLanguage", IsRequired = true, EmitDefaultValue = true)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// List of target languages
        /// </summary>
        /// <value>List of target languages</value>
        [DataMember(Name = "targetLanguages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TargetLanguages { get; set; }

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
        /// output file format
        /// </summary>
        /// <value>output file format</value>
        [DataMember(Name = "outputFormat", IsRequired = true, EmitDefaultValue = true)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// If document&#39;s formatting should be preserved, default true
        /// </summary>
        /// <value>If document&#39;s formatting should be preserved, default true</value>
        [DataMember(Name = "preserveFormatting", EmitDefaultValue = true)]
        public bool PreserveFormatting { get; set; }

        /// <summary>
        /// for analysis only
        /// </summary>
        /// <value>for analysis only</value>
        [DataMember(Name = "origin", EmitDefaultValue = true)]
        public string Origin { get; set; }

        /// <summary>
        /// Choose pages for translation (1-based index). If not present, translate all pages
        /// </summary>
        /// <value>Choose pages for translation (1-based index). If not present, translate all pages</value>
        [DataMember(Name = "pages", EmitDefaultValue = true)]
        public List<int> Pages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextDocumentFileRequest {\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  PreserveFormatting: ").Append(PreserveFormatting).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // SourceLanguage (string) minLength
            if (this.SourceLanguage != null && this.SourceLanguage.Length < 1)
            {
                yield return new ValidationResult("Invalid value for SourceLanguage, length must be greater than 1.", new [] { "SourceLanguage" });
            }

            // OutputFormat (string) minLength
            if (this.OutputFormat != null && this.OutputFormat.Length < 1)
            {
                yield return new ValidationResult("Invalid value for OutputFormat, length must be greater than 1.", new [] { "OutputFormat" });
            }

            yield break;
        }
    }

}
