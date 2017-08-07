// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Topic view
    /// </summary>
    public partial class TopicView
    {
        /// <summary>
        /// Initializes a new instance of the TopicView class.
        /// </summary>
        public TopicView() { }

        /// <summary>
        /// Initializes a new instance of the TopicView class.
        /// </summary>
        public TopicView(string topicHandle, DateTime createdTime, DateTime lastUpdatedTime, PublisherType publisherType, string text, long totalLikes, long totalComments, bool liked, UserCompactView user = default(UserCompactView), string title = default(string), BlobType? blobType = default(BlobType?), string blobHandle = default(string), string blobUrl = default(string), string categories = default(string), string language = default(string), string group = default(string), string deepLink = default(string), string friendlyName = default(string), bool? pinned = default(bool?), ContentStatus? contentStatus = default(ContentStatus?), AppCompactView app = default(AppCompactView))
        {
            TopicHandle = topicHandle;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
            PublisherType = publisherType;
            User = user;
            Title = title;
            Text = text;
            BlobType = blobType;
            BlobHandle = blobHandle;
            BlobUrl = blobUrl;
            Categories = categories;
            Language = language;
            Group = group;
            DeepLink = deepLink;
            FriendlyName = friendlyName;
            TotalLikes = totalLikes;
            TotalComments = totalComments;
            Liked = liked;
            Pinned = pinned;
            ContentStatus = contentStatus;
            App = app;
        }

        /// <summary>
        /// Gets or sets topic handle
        /// </summary>
        [JsonProperty(PropertyName = "topicHandle")]
        public string TopicHandle { get; set; }

        /// <summary>
        /// Gets or sets created time
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets last updated time
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTime")]
        public DateTime LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets publisher type. Possible values include: 'User', 'App'
        /// </summary>
        [JsonProperty(PropertyName = "publisherType")]
        public PublisherType PublisherType { get; set; }

        /// <summary>
        /// Gets or sets owner of the topic
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public UserCompactView User { get; set; }

        /// <summary>
        /// Gets or sets topic title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets topic text
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets topic blob type. Possible values include: 'Unknown',
        /// 'Image', 'Video', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "blobType")]
        public BlobType? BlobType { get; set; }

        /// <summary>
        /// Gets or sets topic blob handle
        /// </summary>
        [JsonProperty(PropertyName = "blobHandle")]
        public string BlobHandle { get; set; }

        /// <summary>
        /// Gets or sets topic blob url
        /// </summary>
        [JsonProperty(PropertyName = "blobUrl")]
        public string BlobUrl { get; set; }

        /// <summary>
        /// Gets or sets topic categories
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public string Categories { get; set; }

        /// <summary>
        /// Gets or sets topic language
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets topic group
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets topic deep link
        /// </summary>
        [JsonProperty(PropertyName = "deepLink")]
        public string DeepLink { get; set; }

        /// <summary>
        /// Gets or sets topic friendly name
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets total likes for the topic
        /// </summary>
        [JsonProperty(PropertyName = "totalLikes")]
        public long TotalLikes { get; set; }

        /// <summary>
        /// Gets or sets total comments for the topic
        /// </summary>
        [JsonProperty(PropertyName = "totalComments")]
        public long TotalComments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the querying user has
        /// liked the topic
        /// </summary>
        [JsonProperty(PropertyName = "liked")]
        public bool Liked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the querying user has
        /// pinned the topic
        /// </summary>
        [JsonProperty(PropertyName = "pinned")]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Gets or sets content status. Possible values include: 'Active',
        /// 'Banned', 'Mature', 'Clean'
        /// </summary>
        [JsonProperty(PropertyName = "contentStatus")]
        public ContentStatus? ContentStatus { get; set; }

        /// <summary>
        /// Gets or sets the containing app
        /// </summary>
        [JsonProperty(PropertyName = "app")]
        public AppCompactView App { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (TopicHandle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TopicHandle");
            }
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
            if (this.User != null)
            {
                this.User.Validate();
            }
            if (this.App != null)
            {
                this.App.Validate();
            }
        }
    }
}
