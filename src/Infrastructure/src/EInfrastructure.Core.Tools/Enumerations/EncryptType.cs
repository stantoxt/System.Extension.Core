﻿// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using EInfrastructure.Core.Config.EntitiesExtensions.SeedWork;

namespace EInfrastructure.Core.Tools.Enumerations
{
    /// <summary>
    /// 加密方式
    /// </summary>
    public class EncryptType : Enumeration
    {
        /// <summary>
        /// Md5
        /// </summary>
        public static EncryptType Md5 = new EncryptType(0, "Md5");

        /// <summary>
        /// Sha1
        /// </summary>
        public static EncryptType Sha1 = new EncryptType(1, "Sha1");

        /// <summary>
        /// Sha256
        /// </summary>
        public static EncryptType Sha256 = new EncryptType(2, "Sha256");

        /// <summary>
        /// Sha384
        /// </summary>
        public static EncryptType Sha384 = new EncryptType(3, "Sha384");

        /// <summary>
        /// Sha512
        /// </summary>
        public static EncryptType Sha512 = new EncryptType(5, "Sha512");

        /// <summary>
        ///
        /// </summary>
        /// <param name="id">加密方式id</param>
        /// <param name="name">加密方式</param>
        public EncryptType(int id, string name) : base(id, name)
        {
        }
    }
}
