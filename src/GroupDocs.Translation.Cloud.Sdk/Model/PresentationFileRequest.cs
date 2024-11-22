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
    /// Request for presentation files like ppt, pptx, pptm, odp
    /// </summary>
    [DataContract(Name = "PresentationFileRequest")]
    public partial class PresentationFileRequest : IValidatableObject
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
            /// Enum Ppt for value: Ppt
            /// </summary>
            [EnumMember(Value = "Ppt")]
            Ppt,

            /// <summary>
            /// Enum Pptx for value: Pptx
            /// </summary>
            [EnumMember(Value = "Pptx")]
            Pptx,

            /// <summary>
            /// Enum Pptm for value: Pptm
            /// </summary>
            [EnumMember(Value = "Pptm")]
            Pptm,

            /// <summary>
            /// Enum Odp for value: Odp
            /// </summary>
            [EnumMember(Value = "Odp")]
            Odp
        }


        /// <summary>
        /// Input file format
        /// </summary>
        /// <value>Input file format</value>
        /// <example>Unknown</example>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PresentationFileRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">Language of original file (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">List of target languages.</param>
        /// <param name="file">File as byte array.</param>
        /// <param name="originalFileName">Type in the file name. If null will be as request ID..</param>
        /// <param name="url">Link to file for translation. Ignore, if \&quot;file\&quot; property not null.</param>
        /// <param name="origin">Url or name of application using this SDK. Not required..</param>
        /// <param name="savingMode">Toggle file saving mode for storage.  Is Files by default..</param>
        /// <param name="format">Input file format (default to FormatEnum.Pptx).</param>
        /// <param name="outputFormat">Output file format.</param>
        /// <param name="masters">If translate master slides (default to false).</param>
        /// <param name="slides">List of slides to translate (1-based index). If not present, translate all slides.</param>
        public PresentationFileRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), byte[] file = default(byte[]), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), FormatEnum? format = FormatEnum.Pptx, string outputFormat = default(string), bool masters = false, List<int> slides = default(List<int>))
        {
            // use default value if no "sourceLanguage" provided
            this.SourceLanguage = sourceLanguage ?? @"en";
            this.TargetLanguages = targetLanguages;
            this.File = file;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.Origin = origin;
            this.SavingMode = savingMode;
            this.Format = format;
            this.OutputFormat = outputFormat;
            this.Masters = masters;
            this.Slides = slides;
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
        /// Output file format
        /// </summary>
        /// <value>Output file format</value>
        [DataMember(Name = "outputFormat", EmitDefaultValue = false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// If translate master slides
        /// </summary>
        /// <value>If translate master slides</value>
        [DataMember(Name = "masters", EmitDefaultValue = true)]
        public bool Masters { get; set; }

        /// <summary>
        /// List of slides to translate (1-based index). If not present, translate all slides
        /// </summary>
        /// <value>List of slides to translate (1-based index). If not present, translate all slides</value>
        [DataMember(Name = "slides", EmitDefaultValue = true)]
        public List<int> Slides { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PresentationFileRequest {\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  Masters: ").Append(Masters).Append("\n");
            sb.Append("  Slides: ").Append(Slides).Append("\n");
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
