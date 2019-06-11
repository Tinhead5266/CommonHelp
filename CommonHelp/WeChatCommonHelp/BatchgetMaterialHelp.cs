using CommonHelp.CommonHelp;

namespace CommonHelp.WeChatCommonHelp
{
    public class BatchgetMaterialHelp
    {

        public static string GetAllBatchetMaterialsByType(string type = "")
        {
            return string.Empty;
        }

        /// <summary>
        /// 根据类型获取素材
        /// </summary>
        /// <param name="type">素材的类型，图片（image）、视频（video）、语音 （voice）、图文（news）</param>
        /// <param name="offset">从全部素材的该偏移位置开始返回，0表示从第一个素材 返回</param>
        /// <param name="count">返回素材的数量，取值在1到20之间</param>
        /// <returns>返回json数据包
        /// total_count         该类型的素材的总数
        /// item_count          本次调用获取的素材的数量
        /// title               图文消息的标题
        /// thumb_media_id      图文消息的封面图片素材id（必须是永久mediaID）
        /// show_cover_pic      是否显示封面，0为false，即不显示，1为true，即显示
        /// author              作者
        /// digest              图文消息的摘要，仅有单图文消息才有摘要，多图文此处为空
        /// content             图文消息的具体内容，支持HTML标签，必须少于2万字符，小于1M，且此处会去除JS
        /// url                 图文页的URL，或者，当获取的列表是图片素材列表时，该字段是图片的URL
        /// content_source_url  图文消息的原文地址，即点击“阅读原文”后的URL
        /// update_time         这篇图文消息素材的最后更新时间
        /// name                文件名称
        /// </returns>
        public static string GetBatchgetMaterialsByType(string type = "", int offset = 0, int count = 20)
        {
            type = string.IsNullOrWhiteSpace(type) ? BatchgetMaterialType.News : type;
            string access_token = AccessTokenHelp.AccessToken;
            var data = new
            {
                type = type,
                offset = offset,
                count = count
            };

            string postData = CommonUtility.Jss.Serialize(data);
            return HttpUtility.SendHttpRequest("https://api.weixin.qq.com/cgi-bin/material/batchget_material?access_token=" + access_token, postData);
        }
    }

    /// <summary>
    /// 素材类型
    /// </summary>
    public class BatchgetMaterialType
    {
        public static string Image = "image";
        public static string Video = "video";
        public static string Voice = "voice";
        public static string News = "news";
    }
}
