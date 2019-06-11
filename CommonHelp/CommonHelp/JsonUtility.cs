using Newtonsoft.Json;
using System.Xml.Linq;

namespace CommonHelp.CommonHelp
{
    public class JsonUtility
    {
        /// <summary>
        /// 将Json转化为XML
        /// </summary>
        /// <param name="json"></param>
        /// <param name="rootName"></param>
        /// <returns></returns>
        public static XDocument ParseJsonToXML(string json, string rootName)
        {
            return JsonConvert.DeserializeXNode(json, rootName);
        }
    }
}
