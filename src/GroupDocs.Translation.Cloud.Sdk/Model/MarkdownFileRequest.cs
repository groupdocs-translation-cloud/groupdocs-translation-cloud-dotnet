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
    /// Request for markdown files or markdown files with Hugo syntax
    /// </summary>
    [DataContract(Name = "MarkdownFileRequest")]
    public partial class MarkdownFileRequest : IValidatableObject
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
        /// Initializes a new instance of the <see cref="MarkdownFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarkdownFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownFileRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">Language of original file (required) (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">List of target languages (required).</param>
        /// <param name="file">File as byte array.</param>
        /// <param name="originalFileName">Type in the file name. If null will be as request ID..</param>
        /// <param name="url">Link to file for translation. Ignore, if \&quot;file\&quot; property not null.</param>
        /// <param name="origin">Url or name of application using this SDK. Not required..</param>
        /// <param name="savingMode">Toggle file saving mode for storage.  Is Files by default..</param>
        /// <param name="outputFormat">output file format (required).</param>
        /// <param name="shortCodeList">Dictionary of short code names and parameters names to translate.</param>
        /// <param name="frontMatterList">List of lists of frontmatter paths.</param>
        public MarkdownFileRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), byte[] file = default(byte[]), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), string outputFormat = default(string), Dictionary<string, List<string>> shortCodeList = default(Dictionary<string, List<string>>), List<List<string>> frontMatterList = default(List<List<string>>))
        {
            // to ensure "sourceLanguage" is required (not null)
            if (sourceLanguage == null)
            {
                throw new ArgumentNullException("sourceLanguage is a required property for MarkdownFileRequest and cannot be null");
            }
            this.SourceLanguage = sourceLanguage;
            // to ensure "targetLanguages" is required (not null)
            if (targetLanguages == null)
            {
                throw new ArgumentNullException("targetLanguages is a required property for MarkdownFileRequest and cannot be null");
            }
            this.TargetLanguages = targetLanguages;
            // to ensure "outputFormat" is required (not null)
            if (outputFormat == null)
            {
                throw new ArgumentNullException("outputFormat is a required property for MarkdownFileRequest and cannot be null");
            }
            this.OutputFormat = outputFormat;
            this.File = file;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.Origin = origin;
            this.SavingMode = savingMode;
            this.ShortCodeList = shortCodeList;
            this.FrontMatterList = frontMatterList;
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
        [DataMember(Name = "outputFormat", IsRequired = true, EmitDefaultValue = true)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Dictionary of short code names and parameters names to translate
        /// </summary>
        /// <value>Dictionary of short code names and parameters names to translate</value>
        [DataMember(Name = "shortCodeList", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> ShortCodeList { get; set; }

        /// <summary>
        /// List of lists of frontmatter paths
        /// </summary>
        /// <value>List of lists of frontmatter paths</value>
        [DataMember(Name = "frontMatterList", EmitDefaultValue = true)]
        public List<List<string>> FrontMatterList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarkdownFileRequest {\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  ShortCodeList: ").Append(ShortCodeList).Append("\n");
            sb.Append("  FrontMatterList: ").Append(FrontMatterList).Append("\n");
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
