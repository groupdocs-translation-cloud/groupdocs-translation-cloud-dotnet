// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HugoResponse.cs">
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


using System;
namespace GroupDocs.Translation.Cloud.SDK.NET.Model
{
    using System;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class HugoResponse
    {
        /// <summary>
        /// "ok" if parsing was successful, "error" if error occured
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// If file was parsed correctly or text of error
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Structure of front matter syntax
        /// </summary>
        [JsonProperty("frontmatter")]
        public Dictionary<int, List<List<string>>> FrontMatter { get; set; }

        /// <summary>
        /// Structure of short code syntax
        /// </summary>
        [JsonProperty("shortcode")]
        public Dictionary<int, List<List<string>>> ShortCodes { get; set; }

    }
}

