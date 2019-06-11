using CommonHelp.CommonHelp;
using System.Web.Script.Serialization;

namespace CommonHelp.WeChatCommonHelp
{
    public class MenuHelp
    {
        /// <summary>
        /// 给指定的用户发送模板消息
        /// </summary>
        /// <param name="data">对应菜单的json</param>
        /// <returns>返回json数据包</returns>
        public static string CreateMenu(object data)
        {
            string access_token = AccessTokenHelp.AccessToken;
            string postData = CommonUtility.Jss.Serialize(data);
            return HttpUtility.SendHttpRequest("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + access_token, postData);
        }
    }
}
