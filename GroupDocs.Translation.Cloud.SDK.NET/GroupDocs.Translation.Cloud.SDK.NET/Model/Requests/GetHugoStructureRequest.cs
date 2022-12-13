// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetHugoStructureRequest.cs">
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

namespace GroupDocs.Translation.Cloud.SDK.NET.Model.Requests
{
    /// <summary>
    /// Request model for parsing hugo structure operation.
    /// </summary>  
    public class GetHugoStructureRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHugoStructureRequest"/> class.
        /// </summary> 
        public GetHugoStructureRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHugoStructureRequest"/> class.
        /// </summary>
        /// <param name="UserRequest">String containing request to translate document</param>
        public GetHugoStructureRequest(string userRequest)
        {
            this.UserRequest = userRequest;
        }

        /// <summary>
        /// Name of the file to recognize
        /// </summary>  
        public string UserRequest { get; set; }
    }
}

