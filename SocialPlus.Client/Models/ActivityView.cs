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
    /// Activity view
    /// </summary>
    public partial class ActivityView
    {
        /// <summary>
        /// Initializes a new instance of the ActivityView class.
        /// </summary>
        public ActivityView() { }

        /// <summary>
        /// Initializes a new instance of the ActivityView class.
        /// </summary>
        public ActivityView(string activityHandle, DateTime createdTime, ActivityType activityType, IList<UserCompactView> actorUsers, int totalActions, bool unread, UserCompactView actedOnUser = default(UserCompactView), ContentCompactView actedOnContent = default(ContentCompactView), AppCompactView app = default(AppCompactView))
        {
            ActivityHandle = activityHandle;
            CreatedTime = createdTime;
            ActivityType = activityType;
            ActorUsers = actorUsers;
            ActedOnUser = actedOnUser;
            ActedOnContent = actedOnContent;
            TotalActions = totalActions;
            Unread = unread;
            App = app;
        }

        /// <summary>
        /// Gets or sets activity handle
        /// </summary>
        [JsonProperty(PropertyName = "activityHandle")]
        public string ActivityHandle { get; set; }

        /// <summary>
        /// Gets or sets created time
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets activity type. Possible values include: 'Like',
        /// 'Comment', 'Reply', 'CommentPeer', 'ReplyPeer', 'Following',
        /// 'FollowRequest', 'FollowAccept'
        /// </summary>
        [JsonProperty(PropertyName = "activityType")]
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Gets or sets actor users
        /// </summary>
        [JsonProperty(PropertyName = "actorUsers")]
        public IList<UserCompactView> ActorUsers { get; set; }

        /// <summary>
        /// Gets or sets acted on user
        /// </summary>
        [JsonProperty(PropertyName = "actedOnUser")]
        public UserCompactView ActedOnUser { get; set; }

        /// <summary>
        /// Gets or sets acted on content
        /// </summary>
        [JsonProperty(PropertyName = "actedOnContent")]
        public ContentCompactView ActedOnContent { get; set; }

        /// <summary>
        /// Gets or sets total actions
        /// </summary>
        [JsonProperty(PropertyName = "totalActions")]
        public int TotalActions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity was read
        /// </summary>
        [JsonProperty(PropertyName = "unread")]
        public bool Unread { get; set; }

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
            if (ActivityHandle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActivityHandle");
            }
            if (ActorUsers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActorUsers");
            }
            if (this.ActorUsers != null)
            {
                foreach (var element in this.ActorUsers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ActedOnUser != null)
            {
                this.ActedOnUser.Validate();
            }
            if (this.ActedOnContent != null)
            {
                this.ActedOnContent.Validate();
            }
            if (this.App != null)
            {
                this.App.Validate();
            }
        }
    }
}