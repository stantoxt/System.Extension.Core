using EInfrastructure.Core.AutoConfig.Interface;

namespace EInfrastructure.Core.UCloud.Storage.Config
{
    /// <summary>
    /// UCloud配置
    /// </summary>
    public class UCloudConfig : IScopedConfigModel
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; } = @"1.0.0";

        /// <summary>
        /// UCloud管理服务器地址后缀
        /// </summary>
        public string UcloudProxySuffix { get; set; } = @".ufile.ucloud.cn";

        /// <summary>
        /// UCloud提供的公钥
        /// </summary>
        public string UCloudPublicKey { get; set; } = @"paste your public key here";

        /// <summary>
        /// UCloud提供的密钥
        /// </summary>
        public string UCloudPrivateKey { get; set; } = @"paste your private key here";

        /// <summary>
        /// 空间名
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// 得到浏览器头
        /// </summary>
        /// <returns></returns>
        public string GetUserAgent()
        {
            return @"UCloudCSharp/" + Version;
        }
    }
}