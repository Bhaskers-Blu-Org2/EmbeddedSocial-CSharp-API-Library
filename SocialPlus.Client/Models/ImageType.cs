// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ImageType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageType
    {
        [EnumMember(Value = "UserPhoto")]
        UserPhoto,
        [EnumMember(Value = "ContentBlob")]
        ContentBlob,
        [EnumMember(Value = "AppIcon")]
        AppIcon
    }
}
