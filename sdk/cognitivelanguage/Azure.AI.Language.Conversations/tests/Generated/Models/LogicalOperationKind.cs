// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> Set to &apos;OR&apos; or &apos;AND&apos; for using corresponding logical operation. </summary>
    public readonly partial struct LogicalOperationKind : IEquatable<LogicalOperationKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicalOperationKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicalOperationKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ANDValue = "AND";
        private const string ORValue = "OR";

        /// <summary> AND. </summary>
        public static LogicalOperationKind AND { get; } = new LogicalOperationKind(ANDValue);
        /// <summary> OR. </summary>
        public static LogicalOperationKind OR { get; } = new LogicalOperationKind(ORValue);
        /// <summary> Determines if two <see cref="LogicalOperationKind"/> values are the same. </summary>
        public static bool operator ==(LogicalOperationKind left, LogicalOperationKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicalOperationKind"/> values are not the same. </summary>
        public static bool operator !=(LogicalOperationKind left, LogicalOperationKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogicalOperationKind"/>. </summary>
        public static implicit operator LogicalOperationKind(string value) => new LogicalOperationKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicalOperationKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicalOperationKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
