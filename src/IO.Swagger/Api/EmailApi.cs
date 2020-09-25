/* 
 * Transactional API
 *
 * # Introduction    This API is a service provided by [E-goi](www.e-goi.com) to send transactional messages.    Transactional Messaging is a 1-to-1 communication channel, usually from an organization directed to a specific consumer.   They can be triggered by:    * __Actions__ - The consumer interacts with the organization (ie.: online shopping);  * __Time__ - The consumer's actions are time-bounded by the organization (ie.: period of inactivity).    Because of the nature of these messages,   it is expected that the consumer is interested in the content of these messages.   Therefore, they have a different treatment from marketing messages, and have a higher acceptance and opening rate.    >DISCLAIMER  >  >Please notice that this platform is more delicate in regards to the nature and processing of its messages.  >  >It should NOT be used as a mean of mass marketing, scams, phishing or overall unruly behaviour.   >  >Failure to comply may lead to limitation of use and even termination of account.    ***
 *
 * OpenAPI spec version: V2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IEmailApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send an Email Message
        /// </summary>
        /// <remarks>
        /// Send an email message to a recipient
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>List&lt;SendMessageIdResponse&gt;</returns>
        List<SendMessageIdResponse> SendEmailMessages (List<Object> body = null);

        /// <summary>
        /// Send an Email Message
        /// </summary>
        /// <remarks>
        /// Send an email message to a recipient
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>ApiResponse of List&lt;SendMessageIdResponse&gt;</returns>
        ApiResponse<List<SendMessageIdResponse>> SendEmailMessagesWithHttpInfo (List<Object> body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send an Email Message
        /// </summary>
        /// <remarks>
        /// Send an email message to a recipient
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>Task of List&lt;SendMessageIdResponse&gt;</returns>
        System.Threading.Tasks.Task<List<SendMessageIdResponse>> SendEmailMessagesAsync (List<Object> body = null);

        /// <summary>
        /// Send an Email Message
        /// </summary>
        /// <remarks>
        /// Send an email message to a recipient
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SendMessageIdResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SendMessageIdResponse>>> SendEmailMessagesAsyncWithHttpInfo (List<Object> body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class EmailApi : IEmailApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class
        /// </summary>
        /// <returns></returns>
        public EmailApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Send an Email Message Send an email message to a recipient
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>List&lt;SendMessageIdResponse&gt;</returns>
        public List<SendMessageIdResponse> SendEmailMessages (List<Object> body = null)
        {
             ApiResponse<List<SendMessageIdResponse>> localVarResponse = SendEmailMessagesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an Email Message Send an email message to a recipient
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>ApiResponse of List&lt;SendMessageIdResponse&gt;</returns>
        public ApiResponse< List<SendMessageIdResponse> > SendEmailMessagesWithHttpInfo (List<Object> body = null)
        {

            var localVarPath = "/v2/email/messages/action/send";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (ApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarHeaderParams["ApiKey"] = this.Configuration.GetApiKeyWithPrefix("ApiKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendEmailMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SendMessageIdResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SendMessageIdResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SendMessageIdResponse>)));
        }

        /// <summary>
        /// Send an Email Message Send an email message to a recipient
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>Task of List&lt;SendMessageIdResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<SendMessageIdResponse>> SendEmailMessagesAsync (List<Object> body = null)
        {
             ApiResponse<List<SendMessageIdResponse>> localVarResponse = await SendEmailMessagesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an Email Message Send an email message to a recipient
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">default response (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SendMessageIdResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SendMessageIdResponse>>> SendEmailMessagesAsyncWithHttpInfo (List<Object> body = null)
        {

            var localVarPath = "/v2/email/messages/action/send";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (ApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarHeaderParams["ApiKey"] = this.Configuration.GetApiKeyWithPrefix("ApiKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendEmailMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SendMessageIdResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SendMessageIdResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SendMessageIdResponse>)));
        }

    }
}
