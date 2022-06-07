// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.Language.Conversations
{
    /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
    public partial class ConversationRequestStatistics : RequestStatistics
    {
        /// <summary> Initializes a new instance of ConversationRequestStatistics. </summary>
        /// <param name="transactionsCount"> Number of transactions for the request. </param>
        /// <param name="conversationsCount"> Number of conversations submitted in the request. </param>
        /// <param name="validConversationsCount"> Number of conversations documents. This excludes empty, over-size limit or non-supported languages documents. </param>
        /// <param name="erroneousConversationsCount"> Number of invalid documents. This includes empty, over-size limit or non-supported languages documents. </param>
        public ConversationRequestStatistics(long transactionsCount, int conversationsCount, int validConversationsCount, int erroneousConversationsCount) : base(transactionsCount)
        {
            ConversationsCount = conversationsCount;
            ValidConversationsCount = validConversationsCount;
            ErroneousConversationsCount = erroneousConversationsCount;
        }

        /// <summary> Initializes a new instance of ConversationRequestStatistics. </summary>
        /// <param name="transactionsCount"> Number of transactions for the request. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="conversationsCount"> Number of conversations submitted in the request. </param>
        /// <param name="validConversationsCount"> Number of conversations documents. This excludes empty, over-size limit or non-supported languages documents. </param>
        /// <param name="erroneousConversationsCount"> Number of invalid documents. This includes empty, over-size limit or non-supported languages documents. </param>
        internal ConversationRequestStatistics(long transactionsCount, IDictionary<string, object> additionalProperties, int conversationsCount, int validConversationsCount, int erroneousConversationsCount) : base(transactionsCount, additionalProperties)
        {
            ConversationsCount = conversationsCount;
            ValidConversationsCount = validConversationsCount;
            ErroneousConversationsCount = erroneousConversationsCount;
        }

        /// <summary> Number of conversations submitted in the request. </summary>
        public int ConversationsCount { get; set; }
        /// <summary> Number of conversations documents. This excludes empty, over-size limit or non-supported languages documents. </summary>
        public int ValidConversationsCount { get; set; }
        /// <summary> Number of invalid documents. This includes empty, over-size limit or non-supported languages documents. </summary>
        public int ErroneousConversationsCount { get; set; }
    }
}
