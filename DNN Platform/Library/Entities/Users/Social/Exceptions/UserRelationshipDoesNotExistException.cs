﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Entities.Users
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UserRelationshipDoesNotExistException : Exception
    {
        public UserRelationshipDoesNotExistException()
        {
        }

        public UserRelationshipDoesNotExistException(string message)
            : base(message)
        {
        }

        public UserRelationshipDoesNotExistException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public UserRelationshipDoesNotExistException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
