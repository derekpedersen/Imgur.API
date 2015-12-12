﻿using System.Net.Http;
using Imgur.API.Authentication;

namespace Imgur.API.Endpoints
{
    /// <summary>
    ///     Endpoint definition.
    /// </summary>
    public interface IEndpoint
    {
        /// <summary>
        ///     Interface for all Api authentication types.
        /// </summary>
        IApiClient ApiClient { get; }

        /// <summary>
        ///     The class for sending HTTP requests and receiving HTTP responses from the service methods.
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        ///     Gets the endpoint url based on the authentication type.
        /// </summary>
        string GetEndpointBaseUrl();

        /// <summary>
        ///     Switch from one client type to another.
        /// </summary>
        /// <param name="apiClient"></param>
        void SwitchClient(IApiClient apiClient);
    }
}