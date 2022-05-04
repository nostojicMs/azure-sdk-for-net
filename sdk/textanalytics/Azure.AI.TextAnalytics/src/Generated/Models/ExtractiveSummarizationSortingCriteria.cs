// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The sorting criteria to use for the results of Extractive Summarization. </summary>
    internal readonly partial struct ExtractiveSummarizationSortingCriteria : IEquatable<ExtractiveSummarizationSortingCriteria>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationSortingCriteria"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExtractiveSummarizationSortingCriteria(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OffsetValue = "Offset";
        private const string RankValue = "Rank";

        /// <summary> Indicates that results should be sorted in order of appearance in the text. </summary>
        public static ExtractiveSummarizationSortingCriteria Offset { get; } = new ExtractiveSummarizationSortingCriteria(OffsetValue);
        /// <summary> Indicates that results should be sorted in order of importance (i.e. rank score) according to the model. </summary>
        public static ExtractiveSummarizationSortingCriteria Rank { get; } = new ExtractiveSummarizationSortingCriteria(RankValue);
        /// <summary> Determines if two <see cref="ExtractiveSummarizationSortingCriteria"/> values are the same. </summary>
        public static bool operator ==(ExtractiveSummarizationSortingCriteria left, ExtractiveSummarizationSortingCriteria right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExtractiveSummarizationSortingCriteria"/> values are not the same. </summary>
        public static bool operator !=(ExtractiveSummarizationSortingCriteria left, ExtractiveSummarizationSortingCriteria right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExtractiveSummarizationSortingCriteria"/>. </summary>
        public static implicit operator ExtractiveSummarizationSortingCriteria(string value) => new ExtractiveSummarizationSortingCriteria(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExtractiveSummarizationSortingCriteria other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExtractiveSummarizationSortingCriteria other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
