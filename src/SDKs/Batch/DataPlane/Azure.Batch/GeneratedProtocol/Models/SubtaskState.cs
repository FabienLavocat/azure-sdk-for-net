// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SubtaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubtaskState
    {
        [EnumMember(Value = "preparing")]
        Preparing,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class SubtaskStateEnumExtension
    {
        internal static string ToSerializedValue(this SubtaskState? value)
        {
            return value == null ? null : ((SubtaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SubtaskState value)
        {
            switch( value )
            {
                case SubtaskState.Preparing:
                    return "preparing";
                case SubtaskState.Running:
                    return "running";
                case SubtaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static SubtaskState? ParseSubtaskState(this string value)
        {
            switch( value )
            {
                case "preparing":
                    return SubtaskState.Preparing;
                case "running":
                    return SubtaskState.Running;
                case "completed":
                    return SubtaskState.Completed;
            }
            return null;
        }
    }
}
