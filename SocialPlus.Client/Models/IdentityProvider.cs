// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IdentityProvider.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityProvider
    {
        [EnumMember(Value = "Facebook")]
        Facebook,
        [EnumMember(Value = "Microsoft")]
        Microsoft,
        [EnumMember(Value = "Google")]
        Google,
        [EnumMember(Value = "Twitter")]
        Twitter,
        [EnumMember(Value = "AADS2S")]
        AADS2S,
        [EnumMember(Value = "SocialPlus")]
        SocialPlus
    }
}
