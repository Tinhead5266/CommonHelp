using CommonHelp.CommonHelp;
using System.Web.Script.Serialization;

namespace CommonHelp.WeChatCommonHelp
{
    public class TemplateMessage
    {
        
        /// <summary>
        /// 给指定的用户发送模板消息
        /// </summary>
        /// <param name="openId">用户标识openid</param>
        /// <param name="templateId">对应的模板id</param>
        /// <param name="data">对应模板的参数</param>
        /// <param name="url">点击对应消息弹出的地址</param>
        /// <param name="topcolor">颜色</param>
        /// <returns>返回json数据包</returns>
        public static string SendTemplate(string openId, string templateId, object data, string url, string topcolor = "#173177")
        {
            string access_token = AccessTokenHelp.AccessToken;
            var msgData = new
            {
                touser = openId,
                template_id = templateId,
                topcolor = topcolor,
                url = url,
                data = data
            };
            string postData = CommonUtility.Jss.Serialize(msgData);
            return HttpUtility.SendHttpRequest("https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + access_token, postData);
        }

        /// <summary>
        /// 给指定的用户发送模板消息
        /// </summary>
        /// <param name="openId">用户标识openid</param>
        /// <param name="templateId">对应的模板id</param>
        /// <param name="data">对应模板的参数</param>
        /// <param name="topcolor">颜色</param>
        /// <returns>返回json数据包</returns>
        public static string SendTemplate(string openId, string templateId, object data, string topcolor = "#173177")
        {
            string access_token = AccessTokenHelp.AccessToken;
            var msgData = new
            {
                touser = openId,
                template_id = templateId,
                topcolor = topcolor,
                data = data
            };
            string postData = CommonUtility.Jss.Serialize(msgData);
            return HttpUtility.SendHttpRequest("https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + access_token, postData);
        }

    }
}
