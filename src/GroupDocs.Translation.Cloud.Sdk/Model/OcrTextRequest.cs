/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.9.2
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
    /// OcrTextRequest
    /// </summary>
    [DataContract(Name = "OcrTextRequest")]
    public partial class OcrTextRequest : IEquatable<OcrTextRequest>, IValidatableObject
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
            /// Enum Bmp for value: Bmp
            /// </summary>
            [EnumMember(Value = "Bmp")]
            Bmp = 2,

            /// <summary>
            /// Enum Jpg for value: Jpg
            /// </summary>
            [EnumMember(Value = "Jpg")]
            Jpg = 3,

            /// <summary>
            /// Enum Png for value: Png
            /// </summary>
            [EnumMember(Value = "Png")]
            Png = 4,

            /// <summary>
            /// Enum Svg for value: Svg
            /// </summary>
            [EnumMember(Value = "Svg")]
            Svg = 5,

            /// <summary>
            /// Enum Gif for value: Gif
            /// </summary>
            [EnumMember(Value = "Gif")]
            Gif = 6,

            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 7

        }


        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrTextRequest" /> class.
        /// </summary>
        /// <param name="format">format (default to FormatEnum.Unknown).</param>
        /// <param name="source">source (default to &quot;en&quot;).</param>
        /// <param name="targets">targets.</param>
        /// <param name="file">file.</param>
        /// <param name="url">url.</param>
        /// <param name="rotate">rotate.</param>
        /// <param name="ishandwritten">ishandwritten.</param>
        /// <param name="origin">origin.</param>
        /// <param name="route">route.</param>
        public OcrTextRequest(FormatEnum? format = FormatEnum.Unknown, string source = @"en", List<string> targets = default(List<string>), byte[] file = default(byte[]), string url = default(string), int rotate = default(int), bool ishandwritten = default(bool), string origin = default(string), string route = default(string))
        {
            this.Format = format;
            // use default value if no "source" provided
            this.Source = source ?? @"en";
            this.Targets = targets;
            this.File = file;
            this.Url = url;
            this.Rotate = rotate;
            this.Ishandwritten = ishandwritten;
            this.Origin = origin;
            this.Route = route;
        }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Targets
        /// </summary>
        [DataMember(Name = "targets", EmitDefaultValue = false)]
        public List<string> Targets { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Rotate
        /// </summary>
        [DataMember(Name = "rotate", EmitDefaultValue = false)]
        public int Rotate { get; set; }

        /// <summary>
        /// Gets or Sets Ishandwritten
        /// </summary>
        [DataMember(Name = "ishandwritten", EmitDefaultValue = true)]
        public bool Ishandwritten { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = true)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OcrTextRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  Ishandwritten: ").Append(Ishandwritten).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OcrTextRequest);
        }

        /// <summary>
        /// Returns true if OcrTextRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrTextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrTextRequest input)
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
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Targets == input.Targets ||
                    this.Targets != null &&
                    input.Targets != null &&
                    this.Targets.SequenceEqual(input.Targets)
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Rotate == input.Rotate ||
                    this.Rotate.Equals(input.Rotate)
                ) && 
                (
                    this.Ishandwritten == input.Ishandwritten ||
                    this.Ishandwritten.Equals(input.Ishandwritten)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
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
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Targets != null)
                {
                    hashCode = (hashCode * 59) + this.Targets.GetHashCode();
                }
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rotate.GetHashCode();
                hashCode = (hashCode * 59) + this.Ishandwritten.GetHashCode();
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.Route != null)
                {
                    hashCode = (hashCode * 59) + this.Route.GetHashCode();
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
            // Source (string) minLength
            if (this.Source != null && this.Source.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be greater than 1.", new [] { "Source" });
            }

            yield break;
        }
    }

}