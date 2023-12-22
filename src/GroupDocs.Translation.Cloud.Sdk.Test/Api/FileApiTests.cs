/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.12.0
 * Contact: anton.perhunov@aspose.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Api;

namespace GroupDocs.Translation.Cloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing FileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FileApiTests : IDisposable
    {
        private FileApi instance;

        public FileApiTests()
        {
            instance = new FileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FileApi
            //Assert.IsType<FileApi>(instance);
        }

        /// <summary>
        /// Test FileUploadPost
        /// </summary>
        [Fact]
        public void FileUploadPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string format = null;
            //System.IO.Stream file = null;
            //var response = instance.FileUploadPost(format, file);
            //Assert.IsType<string>(response);
        }
    }
}
