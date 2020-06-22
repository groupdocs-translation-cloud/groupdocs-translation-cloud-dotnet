// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileInfo.cs">
//   Copyright (c) 2020 GroupDocs.Translation for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Translation.Cloud.SDK.NET.Model
{
    using System.Text;
    using Newtonsoft.Json;
    /// <summary>
    /// Represents information about file.
    /// </summary>

    public class FileInfo
    {
        /// <summary>
        /// Name of the file
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Path to folder containing file
        /// </summary>
        [JsonProperty("folder")]
        public string Folder { get; set; }

        /// <summary>
        /// Storage where file is uploaded
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// "docx" if Word document, "xlsx" if Excel workbook
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Path to save translated file
        /// </summary>
        [JsonProperty("savepath")]
        public string SavePath { get; set; }

        /// <summary>
        /// Path to save translated file
        /// </summary>
        [JsonProperty("savefile")]
        public string SaveFile { get; set; }

        /// <summary>
        /// Language pair to translate
        /// </summary>
        [JsonProperty("pair")]
        public string Pair { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileInfo {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Folder: ").Append(this.Folder).Append("\n");
            sb.Append("  Storage: ").Append(this.Storage).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  SavePath: ").Append(this.SavePath).Append("\n");
            sb.Append("  SaveFile: ").Append(this.SaveFile).Append("\n");
            sb.Append("  Pair: ").Append(this.Pair).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        } 
    }
}
