// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchJobAction enums. </summary>
    public readonly partial struct BatchJobActionKind : IEquatable<BatchJobActionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchJobActionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchJobActionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string DisableValue = "disable";
        private const string TerminateValue = "terminate";

        /// <summary> Take no action. </summary>
        public static BatchJobActionKind None { get; } = new BatchJobActionKind(NoneValue);
        /// <summary> Disable the Job. This is equivalent to calling the disable Job API, with a disableTasks value of requeue. </summary>
        public static BatchJobActionKind Disable { get; } = new BatchJobActionKind(DisableValue);
        /// <summary> Terminate the Job. The terminationReason in the Job's executionInfo is set to "TaskFailed". </summary>
        public static BatchJobActionKind Terminate { get; } = new BatchJobActionKind(TerminateValue);
        /// <summary> Determines if two <see cref="BatchJobActionKind"/> values are the same. </summary>
        public static bool operator ==(BatchJobActionKind left, BatchJobActionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchJobActionKind"/> values are not the same. </summary>
        public static bool operator !=(BatchJobActionKind left, BatchJobActionKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchJobActionKind"/>. </summary>
        public static implicit operator BatchJobActionKind(string value) => new BatchJobActionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchJobActionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchJobActionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
