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
    /// Extension methods for Search.
    /// </summary>
    public static partial class SearchExtensions
    {
            /// <summary>
            /// Search topics with a query
            /// </summary>
            /// The query string will be searched across hashtags, topic titles, and topic
            /// texts,
            /// and matching results will be returned.
            /// 
            /// If the query string contains only hashtags, e.g. #foo #bar,
            /// then only the hashtags
            /// in topics will be searched.
            /// 
            /// Query string supports the following operators:
            /// - suffix: "foo*"
            /// - and: "foo+bar"
            /// - or: "foo|bar"
            /// - not: "-foo"
            /// - phrase: ""foo bar""
            /// - precedence: "foo+(bar|baz)"
            /// You need to escape * if it is at the end of a word, and - if
            /// it is at the start of a word.
            /// Default behavior is to use and, so if you use whitespace to
            /// separate words,
            /// such as "foo bar", that is equivalent to "foo+bar".
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Search query
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
            public static FeedResponseTopicView GetTopics(this ISearch operations, string query, string authorization, int? cursor = default(int?), int? limit = default(int?))
            {
                return Task.Factory.StartNew(s => ((ISearch)s).GetTopicsAsync(query, authorization, cursor, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Search topics with a query
            /// </summary>
            /// The query string will be searched across hashtags, topic titles, and topic
            /// texts,
            /// and matching results will be returned.
            /// 
            /// If the query string contains only hashtags, e.g. #foo #bar,
            /// then only the hashtags
            /// in topics will be searched.
            /// 
            /// Query string supports the following operators:
            /// - suffix: "foo*"
            /// - and: "foo+bar"
            /// - or: "foo|bar"
            /// - not: "-foo"
            /// - phrase: ""foo bar""
            /// - precedence: "foo+(bar|baz)"
            /// You need to escape * if it is at the end of a word, and - if
            /// it is at the start of a word.
            /// Default behavior is to use and, so if you use whitespace to
            /// separate words,
            /// such as "foo bar", that is equivalent to "foo+bar".
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Search query
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
            public static async Task<FeedResponseTopicView> GetTopicsAsync(this ISearch operations, string query, string authorization, int? cursor = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTopicsWithHttpMessagesAsync(query, authorization, cursor, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Search users with a query
            /// </summary>
            /// The query string will be searched across the full name of users
            /// and matching results will be returned.
            /// 
            /// Query string supports the following operators:
            /// - suffix: "foo*"
            /// - and: "foo+bar"
            /// - or: "foo|bar"
            /// - not: "-foo"
            /// - phrase: ""foo bar""
            /// - precedence: "foo+(bar|baz)"
            /// You need to escape * if it is at the end of a word, and - if
            /// it is at the start of a word.
            /// Default behavior is to use and, so if you use whitespace to
            /// separate words,
            /// such as "foo bar", that is equivalent to "foo+bar".
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Search query
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
            public static FeedResponseUserCompactView GetUsers(this ISearch operations, string query, string authorization, int? cursor = default(int?), int? limit = default(int?))
            {
                return Task.Factory.StartNew(s => ((ISearch)s).GetUsersAsync(query, authorization, cursor, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Search users with a query
            /// </summary>
            /// The query string will be searched across the full name of users
            /// and matching results will be returned.
            /// 
            /// Query string supports the following operators:
            /// - suffix: "foo*"
            /// - and: "foo+bar"
            /// - or: "foo|bar"
            /// - not: "-foo"
            /// - phrase: ""foo bar""
            /// - precedence: "foo+(bar|baz)"
            /// You need to escape * if it is at the end of a word, and - if
            /// it is at the start of a word.
            /// Default behavior is to use and, so if you use whitespace to
            /// separate words,
            /// such as "foo bar", that is equivalent to "foo+bar".
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Search query
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
            public static async Task<FeedResponseUserCompactView> GetUsersAsync(this ISearch operations, string query, string authorization, int? cursor = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUsersWithHttpMessagesAsync(query, authorization, cursor, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
