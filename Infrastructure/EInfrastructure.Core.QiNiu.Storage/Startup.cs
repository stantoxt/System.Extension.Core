using System;
using EInfrastructure.Core.AutoConfig;
using EInfrastructure.Core.QiNiu.Storage.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EInfrastructure.Core.QiNiu.Storage
{
    public static class Startup
    {
        /// <summary>
        /// 加载此服务
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="section"></param>
        /// <param name="isCompleteName">是否输入完整的类名，默认：false，为true时则需要输入命名空间+类名（配置文件需要）</param>
        /// <param name="action"></param>
        /// <param name="errConfigAction">配置信息错误回调</param>
        public static IServiceCollection AddQiNiuStorage(this IServiceCollection serviceCollection,
            IConfigurationSection section,
            bool isCompleteName = false,
            Action<ConfigAutoRegister> action = null,
            Action<string> errConfigAction = null)
        {
            serviceCollection.AddCustomerConfig<QiNiuConfig>(section, "qiniucloud.json");
            serviceCollection.AddAutoConfig(isCompleteName, action, errConfigAction);
            return serviceCollection;
        }
    }
}