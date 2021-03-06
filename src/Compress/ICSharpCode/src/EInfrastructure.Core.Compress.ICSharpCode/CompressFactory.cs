// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using EInfrastructure.Core.Config.CompressExtensions.Enum;
using EInfrastructure.Core.Config.ExceptionExtensions;

namespace EInfrastructure.Core.Compress.ICSharpCode
{
    /// <summary>
    /// 压缩工厂
    /// </summary>
    internal class CompressFactory
    {
        #region 得到实现类

        /// <summary>
        /// 得到实现类
        /// </summary>
        /// <param name="compressType">压缩方式</param>
        /// <returns></returns>
        internal static BaseCompressService GetProvider(CompressTypeEnum compressType = CompressTypeEnum.Zip)
        {
            switch (compressType)
            {
                case CompressTypeEnum.Zip:
                    return new Zip.ZipCompressService();
                default:
                    throw new BusinessException("暂不支持的压缩方式");
            }
        }

        #endregion
    }
}
