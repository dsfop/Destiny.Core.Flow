﻿using System;
using System.ComponentModel;

namespace Destiny.Core.Flow.IdentityServer.Entities
{
    /// <summary>
    /// 身份资源声明
    /// </summary>
    [DisplayName("身份资源声明")]
    public class IdentityResourceClaim : UserClaim
    {
        /// <summary>
        /// 身份资源id
        /// </summary>
        [DisplayName("身份资源id")]
        public Guid IdentityResourceId { get; set; }

        /// <summary>
        /// 身份资源
        /// </summary>
        [DisplayName("身份资源")]
        public IdentityResource IdentityResource { get; set; }
    }
}