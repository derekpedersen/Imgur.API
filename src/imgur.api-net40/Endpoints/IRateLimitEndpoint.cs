﻿using System.Threading.Tasks;
using Imgur.API.Models;
using Imgur.API.Models.Impl;

namespace Imgur.API.Endpoints
{
    /// <summary>
    ///     Gets credit limit.
    /// </summary>
    public interface IRateLimitEndpoint : IEndpoint
    {
        /// <summary>
        ///     Gets remaining credits for the application.
        /// </summary>
        /// <returns></returns>
        IRateLimit GetRateLimit();
    }
}