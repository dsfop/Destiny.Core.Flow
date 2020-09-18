﻿using System;
using System.ComponentModel;

namespace Destiny.Core.Flow.IdentityServer.Entities
{
    /// <summary>
    /// api授权范围声明
    /// </summary>
    [DisplayName("api授权范围声明")]
    public class ApiScopeClaim : UserClaim
    {
        /// <summary>
        /// 范围id
        /// </summary>
        [DisplayName("范围id")]
        public Guid ScopeId { get; set; }
        
        /// <summary>
        /// 范围
        /// </summary>
        [DisplayName("范围")]
        public ApiScope Scope { get; set; }
    }
}