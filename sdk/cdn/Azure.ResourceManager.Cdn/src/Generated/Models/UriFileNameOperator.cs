// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct UriFileNameOperator : IEquatable<UriFileNameOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UriFileNameOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UriFileNameOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static UriFileNameOperator Any { get; } = new UriFileNameOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static UriFileNameOperator Equal { get; } = new UriFileNameOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static UriFileNameOperator Contains { get; } = new UriFileNameOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static UriFileNameOperator BeginsWith { get; } = new UriFileNameOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static UriFileNameOperator EndsWith { get; } = new UriFileNameOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static UriFileNameOperator LessThan { get; } = new UriFileNameOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static UriFileNameOperator LessThanOrEqual { get; } = new UriFileNameOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static UriFileNameOperator GreaterThan { get; } = new UriFileNameOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static UriFileNameOperator GreaterThanOrEqual { get; } = new UriFileNameOperator(GreaterThanOrEqualValue);
        /// <summary> RegEx. </summary>
        public static UriFileNameOperator RegEx { get; } = new UriFileNameOperator(RegExValue);
        /// <summary> Determines if two <see cref="UriFileNameOperator"/> values are the same. </summary>
        public static bool operator ==(UriFileNameOperator left, UriFileNameOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UriFileNameOperator"/> values are not the same. </summary>
        public static bool operator !=(UriFileNameOperator left, UriFileNameOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UriFileNameOperator"/>. </summary>
        public static implicit operator UriFileNameOperator(string value) => new UriFileNameOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UriFileNameOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UriFileNameOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
