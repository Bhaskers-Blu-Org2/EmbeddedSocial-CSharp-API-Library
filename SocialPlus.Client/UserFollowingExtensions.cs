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
    /// Extension methods for UserFollowing.
    /// </summary>
    public static partial class UserFollowingExtensions
    {
            /// <summary>
            /// Get following users of a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static FeedResponseUserCompactView GetFollowing(this IUserFollowing operations, string userHandle, string authorization, string cursor = default(string), int? limit = default(int?))
            {
                return Task.Factory.StartNew(s => ((IUserFollowing)s).GetFollowingAsync(userHandle, authorization, cursor, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get following users of a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeedResponseUserCompactView> GetFollowingAsync(this IUserFollowing operations, string userHandle, string authorization, string cursor = default(string), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFollowingWithHttpMessagesAsync(userHandle, authorization, cursor, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}