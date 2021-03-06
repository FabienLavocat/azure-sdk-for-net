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
    /// Defines values for TaskAddStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskAddStatus
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "clientError")]
        ClientError,
        [EnumMember(Value = "serverError")]
        ServerError
    }
    internal static class TaskAddStatusEnumExtension
    {
        internal static string ToSerializedValue(this TaskAddStatus? value)
        {
            return value == null ? null : ((TaskAddStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskAddStatus value)
        {
            switch( value )
            {
                case TaskAddStatus.Success:
                    return "success";
                case TaskAddStatus.ClientError:
                    return "clientError";
                case TaskAddStatus.ServerError:
                    return "serverError";
            }
            return null;
        }

        internal static TaskAddStatus? ParseTaskAddStatus(this string value)
        {
            switch( value )
            {
                case "success":
                    return TaskAddStatus.Success;
                case "clientError":
                    return TaskAddStatus.ClientError;
                case "serverError":
                    return TaskAddStatus.ServerError;
            }
            return null;
        }
    }
}
