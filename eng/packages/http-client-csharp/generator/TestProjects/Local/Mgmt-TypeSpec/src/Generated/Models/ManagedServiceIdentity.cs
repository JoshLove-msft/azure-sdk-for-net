// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ManagedServiceIdentity(ManagedServiceIdentityType @type)
        {
            Type = @type;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        internal ManagedServiceIdentity(Guid? principalId, Guid? tenantId, ManagedServiceIdentityType @type, IDictionary<string, UserAssignedIdentity> userAssignedIdentities, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = @type;
            UserAssignedIdentities = userAssignedIdentities;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? PrincipalId { get; }

        /// <summary> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? TenantId { get; }

        /// <summary> The type of managed identity assigned to this resource. </summary>
        public ManagedServiceIdentityType Type { get; }

        /// <summary> The identities assigned to this resource by the user. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
