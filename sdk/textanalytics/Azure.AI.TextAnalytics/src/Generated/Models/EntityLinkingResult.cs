// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntityLinkingResult. </summary>
    internal partial class EntityLinkingResult : PreBuiltResult
    {
        /// <summary> Initializes a new instance of EntityLinkingResult. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Response by document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="modelVersion"/> or <paramref name="documents"/> is null. </exception>
        public EntityLinkingResult(IEnumerable<DocumentError> errors, string modelVersion, IEnumerable<EntityLinkingResultDocumentsItem> documents) : base(errors, modelVersion)
        {
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }
            if (modelVersion == null)
            {
                throw new ArgumentNullException(nameof(modelVersion));
            }
            if (documents == null)
            {
                throw new ArgumentNullException(nameof(documents));
            }

            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of EntityLinkingResult. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Response by document. </param>
        internal EntityLinkingResult(IList<DocumentError> errors, TextDocumentBatchStatistics statistics, string modelVersion, IList<EntityLinkingResultDocumentsItem> documents) : base(errors, statistics, modelVersion)
        {
            Documents = documents;
        }

        /// <summary> Response by document. </summary>
        public IList<EntityLinkingResultDocumentsItem> Documents { get; }
    }
}
