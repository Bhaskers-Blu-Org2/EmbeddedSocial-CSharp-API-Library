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
    /// Response from post (create) comment
    /// </summary>
    public partial class PostCommentResponse
    {
        /// <summary>
        /// Initializes a new instance of the PostCommentResponse class.
        /// </summary>
        public PostCommentResponse() { }

        /// <summary>
        /// Initializes a new instance of the PostCommentResponse class.
        /// </summary>
        public PostCommentResponse(string commentHandle)
        {
            CommentHandle = commentHandle;
        }

        /// <summary>
        /// Gets or sets comment handle of the comment
        /// </summary>
        [JsonProperty(PropertyName = "commentHandle")]
        public string CommentHandle { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (CommentHandle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommentHandle");
            }
        }
    }
}
