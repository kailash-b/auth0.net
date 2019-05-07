﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Contains details of permissions that should be assigned to a role.
    /// </summary>
    public class AssignPermissionsRequest
    {
        /// <summary>
        /// User IDs to assign to the role.
        /// </summary>
        [JsonProperty("permissions")]
        public IList<PermissionIdentity> Permissions { get; set; }
    }

    // TODO: Remove in 7.0.0
    [Obsolete("Use AssignPermissionsRequest class instead")]
    public class AssociatePermissionsRequest : AssignPermissionsRequest
    {
    }
}
