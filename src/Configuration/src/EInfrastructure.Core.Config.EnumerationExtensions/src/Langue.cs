// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace EInfrastructure.Core.Config.EnumerationExtensions
{
    /// <summary>
    /// 语言
    /// </summary>
    public class Language : EntitiesExtensions.SeedWork.Enumeration
    {
        /// <summary>
        /// 未知
        /// </summary>
        public static Language Unknow = new Language(0, "未知");

        /// <summary>
        /// 国语
        /// </summary>
        public static Language Chinese = new Language(1, "国语");

        /// <summary>
        /// 粤语
        /// </summary>
        public static Language Cantonese = new Language(2, "粤语");

        /// <summary>
        /// 日语
        /// </summary>
        public static Language Japanese = new Language(3, "日语");

        /// <summary>
        /// 英语
        /// </summary>
        public static Language English = new Language(4, "英语");

        /// <summary>
        /// 韩语
        /// </summary>
        public static Language Korean = new Language(5, "韩语");

        /// <summary>
        /// 法语
        /// </summary>
        public static Language French = new Language(6, "法语");

        /// <summary>
        /// 印度语
        /// </summary>
        public static Language Hindi = new Language(7, "印度语");

        public Language(int id, string name) : base(id, name)
        {
        }
    }
}
