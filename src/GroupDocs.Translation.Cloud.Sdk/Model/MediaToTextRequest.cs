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
    /// MediaToTextRequest
    /// </summary>
    [DataContract(Name = "MediaToTextRequest")]
    public partial class MediaToTextRequest : IValidatableObject
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
            /// Enum Mp3 for value: Mp3
            /// </summary>
            [EnumMember(Value = "Mp3")]
            Mp3,

            /// <summary>
            /// Enum Wav for value: Wav
            /// </summary>
            [EnumMember(Value = "Wav")]
            Wav,

            /// <summary>
            /// Enum Flac for value: Flac
            /// </summary>
            [EnumMember(Value = "Flac")]
            Flac,

            /// <summary>
            /// Enum M4a for value: M4a
            /// </summary>
            [EnumMember(Value = "M4a")]
            M4a,

            /// <summary>
            /// Enum Aac for value: Aac
            /// </summary>
            [EnumMember(Value = "Aac")]
            Aac,

            /// <summary>
            /// Enum Wma for value: Wma
            /// </summary>
            [EnumMember(Value = "Wma")]
            Wma,

            /// <summary>
            /// Enum Flv for value: Flv
            /// </summary>
            [EnumMember(Value = "Flv")]
            Flv,

            /// <summary>
            /// Enum Mkv for value: Mkv
            /// </summary>
            [EnumMember(Value = "Mkv")]
            Mkv,

            /// <summary>
            /// Enum Webm for value: Webm
            /// </summary>
            [EnumMember(Value = "Webm")]
            Webm,

            /// <summary>
            /// Enum Avi for value: Avi
            /// </summary>
            [EnumMember(Value = "Avi")]
            Avi,

            /// <summary>
            /// Enum Mov for value: Mov
            /// </summary>
            [EnumMember(Value = "Mov")]
            Mov,

            /// <summary>
            /// Enum Wmv for value: Wmv
            /// </summary>
            [EnumMember(Value = "Wmv")]
            Wmv,

            /// <summary>
            /// Enum Rm for value: Rm
            /// </summary>
            [EnumMember(Value = "Rm")]
            Rm,

            /// <summary>
            /// Enum Mpg for value: Mpg
            /// </summary>
            [EnumMember(Value = "Mpg")]
            Mpg
        }


        /// <summary>
        /// Input file format
        /// </summary>
        /// <value>Input file format</value>
        /// <example>Unknown</example>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaToTextRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaToTextRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaToTextRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">Language of original file (required) (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">List of target languages (required).</param>
        /// <param name="originalFileName">Type in the file name. If null will be as request ID..</param>
        /// <param name="url">Link to file for translation. Ignore, if \&quot;file\&quot; property not null.</param>
        /// <param name="origin">Url or name of application using this SDK. Not required..</param>
        /// <param name="savingMode">Toggle file saving mode for storage.  Is Files by default..</param>
        /// <param name="source">Language of original file (required) (default to &quot;en&quot;).</param>
        /// <param name="targets">List of target languages (required).</param>
        /// <param name="format">Input file format (required) (default to FormatEnum.Mp3).</param>
        /// <param name="fragments">Time fragments that require translation.</param>
        /// <param name="route">endpoints route.</param>
        public MediaToTextRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), string source = @"en", List<string> targets = default(List<string>), FormatEnum format = FormatEnum.Mp3, List<string> fragments = default(List<string>), string route = default(string))
        {
            // to ensure "sourceLanguage" is required (not null)
            if (sourceLanguage == null)
            {
                throw new ArgumentNullException("sourceLanguage is a required property for MediaToTextRequest and cannot be null");
            }
            this.SourceLanguage = sourceLanguage;
            // to ensure "targetLanguages" is required (not null)
            if (targetLanguages == null)
            {
                throw new ArgumentNullException("targetLanguages is a required property for MediaToTextRequest and cannot be null");
            }
            this.TargetLanguages = targetLanguages;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for MediaToTextRequest and cannot be null");
            }
            this.Source = source;
            // to ensure "targets" is required (not null)
            if (targets == null)
            {
                throw new ArgumentNullException("targets is a required property for MediaToTextRequest and cannot be null");
            }
            this.Targets = targets;
            this.Format = format;
            this.OriginalFileName = originalFileName;
            this.Url = url;
            this.Origin = origin;
            this.SavingMode = savingMode;
            this.Fragments = fragments;
            this.Route = route;
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
        /// Url or name of application using this SDK. Not required.
        /// </summary>
        /// <value>Url or name of application using this SDK. Not required.</value>
        [DataMember(Name = "origin", EmitDefaultValue = true)]
        public string Origin { get; set; }

        /// <summary>
        /// Language of original file
        /// </summary>
        /// <value>Language of original file</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// List of target languages
        /// </summary>
        /// <value>List of target languages</value>
        [DataMember(Name = "targets", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Targets { get; set; }

        /// <summary>
        /// Time fragments that require translation
        /// </summary>
        /// <value>Time fragments that require translation</value>
        [DataMember(Name = "fragments", EmitDefaultValue = true)]
        public List<string> Fragments { get; set; }

        /// <summary>
        /// endpoints route
        /// </summary>
        /// <value>endpoints route</value>
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MediaToTextRequest {\n");
            sb.Append("  SourceLanguage: ").Append(SourceLanguage).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  SavingMode: ").Append(SavingMode).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Fragments: ").Append(Fragments).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
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

            // Source (string) minLength
            if (this.Source != null && this.Source.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Source, length must be greater than 1.", new [] { "Source" });
            }

            yield break;
        }
    }

}
