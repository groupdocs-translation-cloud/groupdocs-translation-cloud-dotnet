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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Client.Auth;

namespace GroupDocs.Translation.Cloud.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISwaggerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void SwaggerSpecGet(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SwaggerSpecGetWithHttpInfo(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISwaggerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SwaggerSpecGetAsync(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SwaggerSpecGetWithHttpInfoAsync(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISwaggerApi : ISwaggerApiSync, ISwaggerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SwaggerApi : ISwaggerApi
    {
        private GroupDocs.Translation.Cloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SwaggerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SwaggerApi(string basePath)
        {
            this.Configuration = GroupDocs.Translation.Cloud.Sdk.Client.Configuration.MergeConfigurations(
                GroupDocs.Translation.Cloud.Sdk.Client.GlobalConfiguration.Instance,
                new GroupDocs.Translation.Cloud.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new GroupDocs.Translation.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GroupDocs.Translation.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = GroupDocs.Translation.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SwaggerApi(GroupDocs.Translation.Cloud.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = GroupDocs.Translation.Cloud.Sdk.Client.Configuration.MergeConfigurations(
                GroupDocs.Translation.Cloud.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new GroupDocs.Translation.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GroupDocs.Translation.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = GroupDocs.Translation.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SwaggerApi(GroupDocs.Translation.Cloud.Sdk.Client.ISynchronousClient client, GroupDocs.Translation.Cloud.Sdk.Client.IAsynchronousClient asyncClient, GroupDocs.Translation.Cloud.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = GroupDocs.Translation.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public GroupDocs.Translation.Cloud.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public GroupDocs.Translation.Cloud.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public GroupDocs.Translation.Cloud.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public GroupDocs.Translation.Cloud.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void SwaggerSpecGet(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0)
        {
            SwaggerSpecGetWithHttpInfo(isYaml, serialaizeAsV2);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public GroupDocs.Translation.Cloud.Sdk.Client.ApiResponse<Object> SwaggerSpecGetWithHttpInfo(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0)
        {
            GroupDocs.Translation.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new GroupDocs.Translation.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (isYaml != null)
            {
                localVarRequestOptions.QueryParameters.Add(GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.ParameterToMultiMap("", "IsYaml", isYaml));
            }
            if (serialaizeAsV2 != null)
            {
                localVarRequestOptions.QueryParameters.Add(GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.ParameterToMultiMap("", "SerialaizeAsV2", serialaizeAsV2));
            }

            localVarRequestOptions.Operation = "SwaggerApi.SwaggerSpecGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/swagger/spec", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SwaggerSpecGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SwaggerSpecGetAsync(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await SwaggerSpecGetWithHttpInfoAsync(isYaml, serialaizeAsV2, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GroupDocs.Translation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isYaml"> (optional, default to false)</param>
        /// <param name="serialaizeAsV2"> (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<GroupDocs.Translation.Cloud.Sdk.Client.ApiResponse<Object>> SwaggerSpecGetWithHttpInfoAsync(bool? isYaml = default(bool?), bool? serialaizeAsV2 = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            GroupDocs.Translation.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new GroupDocs.Translation.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (isYaml != null)
            {
                localVarRequestOptions.QueryParameters.Add(GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.ParameterToMultiMap("", "IsYaml", isYaml));
            }
            if (serialaizeAsV2 != null)
            {
                localVarRequestOptions.QueryParameters.Add(GroupDocs.Translation.Cloud.Sdk.Client.ClientUtils.ParameterToMultiMap("", "SerialaizeAsV2", serialaizeAsV2));
            }

            localVarRequestOptions.Operation = "SwaggerApi.SwaggerSpecGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/swagger/spec", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SwaggerSpecGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
