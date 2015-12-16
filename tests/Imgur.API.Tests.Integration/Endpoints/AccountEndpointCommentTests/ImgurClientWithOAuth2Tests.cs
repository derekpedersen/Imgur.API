﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Imgur.API.Tests.Integration.Endpoints.AccountEndpoint.AlbumTests
{
    [TestClass]
    public class AccountEndpointAlbumImgurClientWithOAuth2Tests
    {
        //[TestMethod]
        //public async Task GetAccountFavoritesAsync_Any_IsTrue()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var favourites = await endpoint.GetAccountFavoritesAsync();

        //    Assert.IsTrue(favourites.Any());
        //}


        //[TestMethod]
        //public async Task GetGalleryProfileAsync_WithDefaultUsername_AnyTrophies_IsFalse()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var profile = await endpoint.GetGalleryProfileAsync();

        //    Assert.IsFalse(profile.Trophies.Any());
        //}


        //[TestMethod]
        //public async Task GetAlbumsAsync_WithValidReponse_IsTrue()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var albums = await endpoint.GetAlbumsAsync();

        //    Assert.IsTrue(albums.Any());
        //}

        //[TestMethod]
        //public async Task GetAlbumAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var album = await endpoint.GetAlbumAsync("cuta6");

        //    Assert.IsNotNull(album);
        //}

        //[TestMethod]
        //public async Task GetAlbumIdsAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var albums = await endpoint.GetAlbumIdsAsync();

        //    Assert.IsTrue(albums.Any());
        //}

        //[TestMethod]
        //public async Task GetAlbumCountAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var albums = await endpoint.GetAlbumCountAsync();

        //    Assert.IsTrue(albums >= 1);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ImgurException))]
        //public async Task DeleteAlbumAsync_WithValidReponse_ThrowsImgurException()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var deleted = await endpoint.DeleteAlbumAsync("lzpoZ7a5IPrxvVe");

        //    Assert.IsTrue(deleted);
        //}

        //[TestMethod]
        //public async Task GetCommentsAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var comments = await endpoint.GetCommentsAsync();

        //    Assert.IsTrue(comments.Count() >= 2);
        //}

        //[TestMethod]
        //public async Task GetCommentIdsAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var comments = await endpoint.GetCommentIdsAsync();

        //    Assert.IsTrue(comments.Count() > 1);
        //}

        //[TestMethod]
        //public async Task GetCommentCountAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var commentCount = await endpoint.GetCommentCountAsync();

        //    Assert.IsTrue(commentCount > 1);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ImgurException))]
        //public async Task DeleteCommentAsync_WithValidReponse_ThrowsImgurException()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var deleted = await endpoint.DeleteCommentAsync("487153732");

        //    Assert.IsTrue(deleted);
        //}

        //[TestMethod]
        //public async Task GetImagesAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var images = await endpoint.GetImagesAsync();

        //    Assert.IsTrue(images.Count() >= 2);
        //}

        //[TestMethod]
        //public async Task GetImageIdsAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var images = await endpoint.GetImageIdsAsync();

        //    Assert.IsTrue(images.Count() > 1);
        //}

        //[TestMethod]
        //public async Task GetImageCountAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var imageCount = await endpoint.GetImageCountAsync();

        //    Assert.IsTrue(imageCount > 1);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ImgurException))]
        //public async Task DeleteImageAsync_WithValidReponse_ThrowsImgurException()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var deleted = await endpoint.DeleteImageAsync("487153732");

        //    Assert.IsTrue(deleted);
        //}

        //[TestMethod]
        //public async Task GetNotificationsAsync_WithValidReponse_AreEqual()
        //{
        //    var client = new ImgurClient(ClientId, ClientSecret, await GetOAuth2TokenAsync());
        //    var endpoint = new AccountEndpoint(client);

        //    var notifications = await endpoint.GetNotificationsAsync(false);

        //    Assert.IsTrue(notifications.Messages.Any());
        //}
    }
}