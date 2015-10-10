﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright>Copyright 2012-2015 Lawo AG (http://www.lawo.com). All rights reserved.</copyright>
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Lawo.EmberPlus.S101
{
    using System;

    /// <summary>The exception that is thrown when an error occurs while parsing S101-encoded data.</summary>
    /// <threadsafety static="true" instance="false"/>
    public sealed class S101Exception : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="S101Exception"/> class.</summary>
        public S101Exception() : this(null)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="S101Exception"/> class.</summary>
        public S101Exception(string message) : this(message, null)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="S101Exception"/> class.</summary>
        public S101Exception(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}