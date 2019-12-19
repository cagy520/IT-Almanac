using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Almanac_cagy
{
    class Program
    {
        static string cache = "诸事不宜";

        public static void Main(string[] args)
        {
            string appkey = "6d912da9aa92dcac6317b277dc11c4b4"; //配置您聚合日历申请的appkey
            string url = "http://v.juhe.cn/laohuangli/d";

            var parameters = new Dictionary<string, string>();

            parameters.Add("key", appkey);//你申请的key
            parameters.Add("date", DateTime.Now.Date.ToString()); //日期，格式2014-09-09

            string result = HttpGo.sendPost(url, parameters, "get");

            if (result.Contains("超过每日可允许请求次数"))
            {
                result = cache;//使用上一次的缓存记录
            }
            else cache = result;

            Root obj = JsonConvert.DeserializeObject<Root>(result);

            string[] yi = obj.result.yi.Split(' ');
            string[] ji = obj.result.ji.Split(' ');

            string y = "*宜：";
            string j = "*忌：";

            //关键词替换
            for (int i = 0; i < yi.Length; i++)
            {
                y += AlmanacCore.ReplaceAlmanac(yi[i]) + " ";
            }
            for (int i = 0; i < ji.Length; i++)
            {
                j += AlmanacCore.ReplaceAlmanac(ji[i]) + " ";

            }

            obj.result.yi = y;
            obj.result.ji = j;

            string almanac = JsonConvert.SerializeObject(obj);
            Console.WriteLine(almanac);
            Console.ReadKey();
        }
    }
}
