﻿using System;
using System.Reflection;
using Imgur.API.Authentication;
using Imgur.API.Authentication.Impl;
using Imgur.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Imgur.API.Tests.Authentication
{
    [TestClass]
    public class ApiAuthenticationTests
    {
        [TestMethod]
        public void IOAuth2Token_Set_NotNull()
        {
            var apiAuth = Substitute.For<IApiAuthentication>();
            var oAuthToken = Substitute.For<IOAuth2Token>();
            apiAuth.OAuth2Token.Returns(oAuthToken);
            Assert.IsNotNull(apiAuth.OAuth2Token);
        }

        [TestMethod]
        public void IRateLimit_Set_NotNull()
        {
            var apiAuth = Substitute.For<IApiAuthentication>();
            var rateLimit = Substitute.For<IRateLimit>();
            apiAuth.RateLimit.Returns(rateLimit);
            Assert.IsNotNull(apiAuth.RateLimit);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void ClientId_SetNullByConstructor_ThrowArgumentNullException()
        {
            try
            {
                Substitute.ForPartsOf<ApiAuthenticationBase>(null, "ClientSecret");
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void ClientSecret_SetNullByConstructor_ThrowArgumentNullException()
        {
            try
            {
                Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", null);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void OAuth2_SetNullByConstructor_ThrowArgumentNullException()
        {
            try
            {
                Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", "ClientSecret", null);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        [TestMethod]
        public void RateLimit_SetByInitialization_IsNotNull()
        {
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>();
            Assert.IsNotNull(apiAuth.RateLimit);
        }

        [TestMethod]
        public void RateLimit_SetByDefaultConstructor_IsNotNull()
        {
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>();
            Assert.IsNotNull(apiAuth.RateLimit);
        }

        [TestMethod]
        public void RateLimit_SetByConstructor1_IsNotNull()
        {
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", "ClientSecret");
            Assert.IsNotNull(apiAuth.RateLimit);
        }

        [TestMethod]
        public void RateLimit_SetByConstructor2_IsNotNull()
        {
            var oAuth2Token = Substitute.For<IOAuth2Token>();
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", "ClientSecret", oAuth2Token);
            Assert.IsNotNull(apiAuth.RateLimit);
        }

        [TestMethod]
        public void OAuth2Token_SetByConstructor_IsNotNull()
        {
            var oAuth2Token = Substitute.For<IOAuth2Token>();
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", "ClientSecret", oAuth2Token);
            Assert.IsNotNull(apiAuth.OAuth2Token);
        }

        [TestMethod]
        public void OAuth2Token_SetBySetOAuth2Token_IsNotNull()
        {
            var oAuth2Token = Substitute.For<IOAuth2Token>();
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", "ClientSecret");

            Assert.IsNull(apiAuth.OAuth2Token);
            apiAuth.SetOAuth2Token(oAuth2Token);
            Assert.IsNotNull(apiAuth.OAuth2Token);
        }

        [TestMethod]
        public void OAuth2Token_SetBySetOAuth2Token_IsNull()
        {
            var oAuth2Token = Substitute.For<IOAuth2Token>();
            var apiAuth = Substitute.ForPartsOf<ApiAuthenticationBase>("ClientId", "ClientSecret");

            Assert.IsNull(apiAuth.OAuth2Token);
            apiAuth.SetOAuth2Token(oAuth2Token);
            Assert.IsNotNull(apiAuth.OAuth2Token);
            apiAuth.SetOAuth2Token(null);
            Assert.IsNull(apiAuth.OAuth2Token);
        }
    }
}