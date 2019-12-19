using System;
using System.Collections.Generic;
using System.Text;

namespace Almanac_cagy
{
    public class OrignAlmanac
    {

        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string yangli { get; set; }
        /// <summary>
        /// 己亥(猪)年十一月廿四
        /// </summary>
        public string yinli { get; set; }
        /// <summary>
        /// 松柏木 满执位
        /// </summary>
        public string wuxing { get; set; }
        /// <summary>
        /// 冲猴(甲申)煞北
        /// </summary>
        public string chongsha { get; set; }
        /// <summary>
        /// 庚不经络织机虚张 寅不祭祀神鬼不尝
        /// </summary>
        public string baiji { get; set; }
        /// <summary>
        /// 相日 驿马 五合 时德 福德 不将 天后 天马 福生 天巫 鸣犬对
        /// </summary>
        public string jishen { get; set; }
        /// <summary>
        /// 纳财 开市 交易 立券 会亲友 进人口 经络 祭祀 祈福 安香 出火 求医 治病 修造 动土 拆卸 扫舍 安床 栽种 牧养 开生坟 合寿木 入殓 安葬 启钻
        /// </summary>
        public string yi { get; set; }
        /// <summary>
        /// 五虚 归忌 白虎
        /// </summary>
        public string xiongshen { get; set; }
        /// <summary>
        /// 嫁娶 祈福 出火 移徙 入宅
        /// </summary>
        public string ji { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OrignAlmanac result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int error_code { get; set; }
    }
}
