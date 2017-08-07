// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    /// <summary>
    /// UserTopics operations.
    /// </summary>
    public partial class UserTopics : IServiceOperations<SocialPlusClient>, IUserTopics
    {
        /// <summary>
        /// Initializes a new instance of the UserTopics class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public UserTopics(SocialPlusClient client)
        {
            if (client == null) 
            {
                throw new ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the SocialPlusClient
        /// </summary>
        public SocialPlusClient Client { get; private set; }

        /// <summary>
        /// Get user topics sorted by creation time
        /// </summary>
        /// <param name='userHandle'>
        /// Handle of queried user
        /// </param>
        /// <param name='authorization'>
        /// Format is: "Scheme CredentialsList". Possible values are:
        /// 
        /// - Anon AK=AppKey
        /// 
        /// - SocialPlus TK=SessionToken
        /// 
        /// - Facebook AK=AppKey|TK=AccessToken
        /// 
        /// - Google AK=AppKey|TK=AccessToken
        /// 
        /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
        /// 
        /// - Microsoft AK=AppKey|TK=AccessToken
        /// 
        /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
        /// </param>
        /// <param name='cursor'>
        /// Current read cursor
        /// </param>
        /// <param name='limit'>
        /// Number of items to return
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<FeedResponseTopicView>> GetTopicsWithHttpMessagesAsync(string userHandle, string authorization, string cursor = default(string), int? limit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (userHandle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "userHandle");
            }
            if (authorization == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "authorization");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("userHandle", userHandle);
                tracingParameters.Add("cursor", cursor);
                tracingParameters.Add("limit", limit);
                tracingParameters.Add("authorization", authorization);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetTopics", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v0.7/users/{userHandle}/topics").ToString();
            _url = _url.Replace("{userHandle}", Uri.EscapeDataString(userHandle));
            List<string> _queryParameters = new List<string>();
            if (cursor != null)
            {
                _queryParameters.Add(string.Format("cursor={0}", Uri.EscapeDataString(cursor)));
            }
            if (limit != null)
            {
                _queryParameters.Add(string.Format("limit={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(limit, this.Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers
            if (authorization != null)
            {
                if (_httpRequest.Headers.Contains("Authorization"))
                {
                    _httpRequest.Headers.Remove("Authorization");
                }
                _httpRequest.Headers.TryAddWithoutValidation("Authorization", authorization);
            }
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 400 && (int)_statusCode != 401 && (int)_statusCode != 404 && (int)_statusCode != 500)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<FeedResponseTopicView>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<FeedResponseTopicView>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Get user topics sorted by popularity
        /// </summary>
        /// <param name='userHandle'>
        /// Handle of queried user
        /// </param>
        /// <param name='authorization'>
        /// Format is: "Scheme CredentialsList". Possible values are:
        /// 
        /// - Anon AK=AppKey
        /// 
        /// - SocialPlus TK=SessionToken
        /// 
        /// - Facebook AK=AppKey|TK=AccessToken
        /// 
        /// - Google AK=AppKey|TK=AccessToken
        /// 
        /// - Twitter AK=AppKey|RT=RequestToken|TK=AccessToken
        /// 
        /// - Microsoft AK=AppKey|TK=AccessToken
        /// 
        /// - AADS2S AK=AppKey|[UH=UserHandle]|TK=AADToken
        /// </param>
        /// <param name='cursor'>
        /// Current read cursor
        /// </param>
        /// <param name='limit'>
        /// Number of items to return
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<FeedResponseTopicView>> GetPopularTopicsWithHttpMessagesAsync(string userHandle, string authorization, int? cursor = default(int?), int? limit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (userHandle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "userHandle");
            }
            if (authorization == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "authorization");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("userHandle", userHandle);
                tracingParameters.Add("cursor", cursor);
                tracingParameters.Add("limit", limit);
                tracingParameters.Add("authorization", authorization);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetPopularTopics", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v0.7/users/{userHandle}/topics/popular").ToString();
            _url = _url.Replace("{userHandle}", Uri.EscapeDataString(userHandle));
            List<string> _queryParameters = new List<string>();
            if (cursor != null)
            {
                _queryParameters.Add(string.Format("cursor={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(cursor, this.Client.SerializationSettings).Trim('"'))));
            }
            if (limit != null)
            {
                _queryParameters.Add(string.Format("limit={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(limit, this.Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers
            if (authorization != null)
            {
                if (_httpRequest.Headers.Contains("Authorization"))
                {
                    _httpRequest.Headers.Remove("Authorization");
                }
                _httpRequest.Headers.TryAddWithoutValidation("Authorization", authorization);
            }
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 400 && (int)_statusCode != 401 && (int)_statusCode != 404 && (int)_statusCode != 500)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<FeedResponseTopicView>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<FeedResponseTopicView>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
