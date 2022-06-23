// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.Conversations
{
    /// <summary> Answer span object of QnA. </summary>
    public partial class AnswerSpan
    {
        /// <summary> Initializes a new instance of AnswerSpan. </summary>
        internal AnswerSpan()
        {
        }

        /// <summary> Initializes a new instance of AnswerSpan. </summary>
        /// <param name="text"> Predicted text of answer span. </param>
        /// <param name="confidence"> Predicted score of answer span, value ranges from 0 to 1. </param>
        /// <param name="offset"> The answer span offset from the start of answer. </param>
        /// <param name="length"> The length of the answer span. </param>
        internal AnswerSpan(string text, double? confidence, int? offset, int? length)
        {
            Text = text;
            Confidence = confidence;
            Offset = offset;
            Length = length;
        }

        /// <summary> Predicted text of answer span. </summary>
        public string Text { get; }
        /// <summary> Predicted score of answer span, value ranges from 0 to 1. </summary>
        public double? Confidence { get; }
        /// <summary> The answer span offset from the start of answer. </summary>
        public int? Offset { get; }
        /// <summary> The length of the answer span. </summary>
        public int? Length { get; }
    }
}
