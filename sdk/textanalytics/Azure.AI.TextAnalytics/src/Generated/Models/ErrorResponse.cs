// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Error response. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorResponse(Error error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> The error object. </summary>
        public Error Error { get; }
    }
}
