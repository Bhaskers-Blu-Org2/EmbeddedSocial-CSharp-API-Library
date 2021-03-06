// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Images.
    /// </summary>
    public static partial class ImagesExtensions
    {
            /// <summary>
            /// Upload a new image
            /// </summary>
            /// Images will be resized. To access a resized image, append the 1 character
            /// size identifier to the blobHandle that is returned.
            /// 
            /// - d is 25 pixels wide
            /// - h is 50 pixels wide
            /// - l is 100 pixels wide
            /// - p is 250 pixels wide
            /// - t is 500 pixels wide
            /// - x is 1000 pixels wide
            /// 
            /// - ImageType.UserPhoto supports d,h,l,p,t,x
            /// - ImageType.ContentBlob supports d,h,l,p,t,x
            /// - ImageType.AppIcon supports l
            /// 
            /// All resized images will maintain their aspect ratio. Any
            /// orientation specified in the EXIF headers will be honored.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='imageType'>
            /// Image type. Possible values include: 'UserPhoto', 'ContentBlob', 'AppIcon'
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
            /// <param name='image'>
            /// MIME encoded contents of the image
            /// </param>
            public static PostImageResponse PostImage(this IImages operations, ImageType imageType, string authorization, System.IO.Stream image)
            {
                return Task.Factory.StartNew(s => ((IImages)s).PostImageAsync(imageType, authorization, image), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upload a new image
            /// </summary>
            /// Images will be resized. To access a resized image, append the 1 character
            /// size identifier to the blobHandle that is returned.
            /// 
            /// - d is 25 pixels wide
            /// - h is 50 pixels wide
            /// - l is 100 pixels wide
            /// - p is 250 pixels wide
            /// - t is 500 pixels wide
            /// - x is 1000 pixels wide
            /// 
            /// - ImageType.UserPhoto supports d,h,l,p,t,x
            /// - ImageType.ContentBlob supports d,h,l,p,t,x
            /// - ImageType.AppIcon supports l
            /// 
            /// All resized images will maintain their aspect ratio. Any
            /// orientation specified in the EXIF headers will be honored.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='imageType'>
            /// Image type. Possible values include: 'UserPhoto', 'ContentBlob', 'AppIcon'
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
            /// <param name='image'>
            /// MIME encoded contents of the image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PostImageResponse> PostImageAsync(this IImages operations, ImageType imageType, string authorization, System.IO.Stream image, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostImageWithHttpMessagesAsync(imageType, authorization, image, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get image
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blobHandle'>
            /// Blob handle
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
            public static System.IO.Stream GetImage(this IImages operations, string blobHandle, string authorization)
            {
                return Task.Factory.StartNew(s => ((IImages)s).GetImageAsync(blobHandle, authorization), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get image
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blobHandle'>
            /// Blob handle
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.IO.Stream> GetImageAsync(this IImages operations, string blobHandle, string authorization, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetImageWithHttpMessagesAsync(blobHandle, authorization, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

    }
}
