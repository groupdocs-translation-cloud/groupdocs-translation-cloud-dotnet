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
    /// FileRequest
    /// </summary>
    [DataContract(Name = "FileRequest")]
    public partial class FileRequest : IEquatable<FileRequest>, IValidatableObject
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
            Tsv = 21,

            /// <summary>
            /// Enum Srt for value: Srt
            /// </summary>
            [EnumMember(Value = "Srt")]
            Srt = 22

        }


        /// <summary>
        /// Input file format
        /// </summary>
        /// <value>Input file format</value>
        /// <example>&quot;Unknown&quot;</example>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage">Language of original file (default to &quot;en&quot;).</param>
        /// <param name="targetLanguages">List of target languages.</param>
        /// <param name="file">File as byte array.</param>
        /// <param name="originalFileName">Type in the file name. If null will be as request ID..</param>
        /// <param name="url">Link to file for translation. Ignore, if \&quot;file\&quot; property not null.</param>
        /// <param name="origin">Url or name of application using this SDK. Not required..</param>
        /// <param name="savingMode">Toggle file saving mode for storage.  Is Files by default..</param>
        /// <param name="format">Input file format (default to FormatEnum.Unknown).</param>
        /// <param name="outputFormat">output file format.</param>
        /// <param name="masters">If translate master slides (default to false).</param>
        /// <param name="formatting">If document&#39;s formatting should be preserved, default true (default to true).</param>
        /// <param name="route">Endpoint route.</param>
        /// <param name="separator">Separator in files.</param>
        /// <param name="elements">List of slides to translate (1-based index). If not present, translate all elements (page, slide, worksheet).</param>
        /// <param name="ranges">Dictionary of ranges in Excel workbooks.</param>
        /// <param name="shortcodedict">Dictionary of short code names and parameters names to translate.</param>
        /// <param name="frontMatterList">Dictionary where key is zero-based front matter index and value is list of lists of front matter paths.</param>
        public FileRequest(string sourceLanguage = @"en", List<string> targetLanguages = default(List<string>), byte[] file = default(byte[]), string originalFileName = default(string), string url = default(string), string origin = default(string), SavingModeEnum? savingMode = default(SavingModeEnum?), FormatEnum? format = FormatEnum.Unknown, string outputFormat = default(string), bool masters = false, bool formatting = true, string route = default(string), string separator = default(string), List<int> elements = default(List<int>), Dictionary<string, WorksheetData> ranges = default(Dictionary<string, WorksheetData>), Dictionary<string, List<string>> shortcodedict = default(Dictionary<string, List<string>>), List<List<string>> frontMatterList = default(List<List<string>>))
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
            this.Formatting = formatting;
            this.Route = route;
            this.Separator = separator;
            this.Elements = elements;
            this.Ranges = ranges;
            this.Shortcodedict = shortcodedict;
            this.FrontMatterList = frontMatterList;
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
        /// If translate master slides
        /// </summary>
        /// <value>If translate master slides</value>
        [DataMember(Name = "masters", EmitDefaultValue = true)]
        public bool Masters { get; set; }

        /// <summary>
        /// If document&#39;s formatting should be preserved, default true
        /// </summary>
        /// <value>If document&#39;s formatting should be preserved, default true</value>
        [DataMember(Name = "formatting", EmitDefaultValue = true)]
        public bool Formatting { get; set; }

        /// <summary>
        /// Endpoint route
        /// </summary>
        /// <value>Endpoint route</value>
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// Separator in files
        /// </summary>
        /// <value>Separator in files</value>
        [DataMember(Name = "separator", EmitDefaultValue = true)]
        public string Separator { get; set; }

        /// <summary>
        /// List of slides to translate (1-based index). If not present, translate all elements (page, slide, worksheet)
        /// </summary>
        /// <value>List of slides to translate (1-based index). If not present, translate all elements (page, slide, worksheet)</value>
        [DataMember(Name = "elements", EmitDefaultValue = true)]
        public List<int> Elements { get; set; }

        /// <summary>
        /// Dictionary of ranges in Excel workbooks
        /// </summary>
        /// <value>Dictionary of ranges in Excel workbooks</value>
        [DataMember(Name = "ranges", EmitDefaultValue = true)]
        public Dictionary<string, WorksheetData> Ranges { get; set; }

        /// <summary>
        /// Dictionary of short code names and parameters names to translate
        /// </summary>
        /// <value>Dictionary of short code names and parameters names to translate</value>
        [DataMember(Name = "shortcodedict", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Shortcodedict { get; set; }

        /// <summary>
        /// Dictionary where key is zero-based front matter index and value is list of lists of front matter paths
        /// </summary>
        /// <value>Dictionary where key is zero-based front matter index and value is list of lists of front matter paths</value>
        [DataMember(Name = "frontMatterList", EmitDefaultValue = true)]
        public List<List<string>> FrontMatterList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileRequest {\n");
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
            sb.Append("  Formatting: ").Append(Formatting).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Separator: ").Append(Separator).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  Shortcodedict: ").Append(Shortcodedict).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileRequest);
        }

        /// <summary>
        /// Returns true if FileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileRequest input)
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
                    this.Shortcodedict == input.Shortcodedict ||
                    this.Shortcodedict != null &&
                    input.Shortcodedict != null &&
                    this.Shortcodedict.SequenceEqual(input.Shortcodedict)
                ) && 
                (
                    this.FrontMatterList == input.FrontMatterList ||
                    this.FrontMatterList != null &&
                    input.FrontMatterList != null &&
                    this.FrontMatterList.SequenceEqual(input.FrontMatterList)
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
                if (this.Shortcodedict != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcodedict.GetHashCode();
                }
                if (this.FrontMatterList != null)
                {
                    hashCode = (hashCode * 59) + this.FrontMatterList.GetHashCode();
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