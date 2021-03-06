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
    /// Request to post (create) topic
    /// </summary>
    public partial class PostTopicRequest
    {
        /// <summary>
        /// Initializes a new instance of the PostTopicRequest class.
        /// </summary>
        public PostTopicRequest() { }

        /// <summary>
        /// Initializes a new instance of the PostTopicRequest class.
        /// </summary>
        public PostTopicRequest(PublisherType publisherType, string text, string title = default(string), BlobType? blobType = default(BlobType?), string blobHandle = default(string), string categories = default(string), string language = default(string), string deepLink = default(string), string friendlyName = default(string), string group = default(string))
        {
            PublisherType = publisherType;
            Title = title;
            Text = text;
            BlobType = blobType;
            BlobHandle = blobHandle;
            Categories = categories;
            Language = language;
            DeepLink = deepLink;
            FriendlyName = friendlyName;
            Group = group;
        }

        /// <summary>
        /// Gets or sets publisher type. Possible values include: 'User', 'App'
        /// </summary>
        [JsonProperty(PropertyName = "publisherType")]
        public PublisherType PublisherType { get; set; }

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
        /// Gets or sets topic group
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
        }
    }
}
