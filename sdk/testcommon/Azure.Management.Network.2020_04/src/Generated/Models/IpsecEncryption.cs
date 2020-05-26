// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The IPSec encryption algorithm (IKE phase 1). </summary>
    public readonly partial struct IpsecEncryption : IEquatable<IpsecEncryption>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="IpsecEncryption"/> values are the same. </summary>
        public IpsecEncryption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string DESValue = "DES";
        private const string DES3Value = "DES3";
        private const string AES128Value = "AES128";
        private const string AES192Value = "AES192";
        private const string AES256Value = "AES256";
        private const string Gcmaes128Value = "GCMAES128";
        private const string Gcmaes192Value = "GCMAES192";
        private const string Gcmaes256Value = "GCMAES256";

        /// <summary> None. </summary>
        public static IpsecEncryption None { get; } = new IpsecEncryption(NoneValue);
        /// <summary> DES. </summary>
        public static IpsecEncryption DES { get; } = new IpsecEncryption(DESValue);
        /// <summary> DES3. </summary>
        public static IpsecEncryption DES3 { get; } = new IpsecEncryption(DES3Value);
        /// <summary> AES128. </summary>
        public static IpsecEncryption AES128 { get; } = new IpsecEncryption(AES128Value);
        /// <summary> AES192. </summary>
        public static IpsecEncryption AES192 { get; } = new IpsecEncryption(AES192Value);
        /// <summary> AES256. </summary>
        public static IpsecEncryption AES256 { get; } = new IpsecEncryption(AES256Value);
        /// <summary> GCMAES128. </summary>
        public static IpsecEncryption Gcmaes128 { get; } = new IpsecEncryption(Gcmaes128Value);
        /// <summary> GCMAES192. </summary>
        public static IpsecEncryption Gcmaes192 { get; } = new IpsecEncryption(Gcmaes192Value);
        /// <summary> GCMAES256. </summary>
        public static IpsecEncryption Gcmaes256 { get; } = new IpsecEncryption(Gcmaes256Value);
        /// <summary> Determines if two <see cref="IpsecEncryption"/> values are the same. </summary>
        public static bool operator ==(IpsecEncryption left, IpsecEncryption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpsecEncryption"/> values are not the same. </summary>
        public static bool operator !=(IpsecEncryption left, IpsecEncryption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IpsecEncryption"/>. </summary>
        public static implicit operator IpsecEncryption(string value) => new IpsecEncryption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpsecEncryption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpsecEncryption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
