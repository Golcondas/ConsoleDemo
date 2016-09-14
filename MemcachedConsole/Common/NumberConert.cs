using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedConsole.Common
{
    public class NumberConert
    {
        String[] UNITS ={ "", "十", "百", "千", "万", "十", "百",  
            "千", "亿", "十", "百", "千", "兆"};
        String[] NUMS = { "零", "一", "二", "三", "四", "五", "六",  
            "七", "八", "九"};

        /** 
        * 数字转换成中文汉字 
        *  
        * @param value 
        *            转换的数字 
        * @return 返回数字转后的汉字字符串 
        */
        public String Translate(Int64 value)
        {
            // 转译结果  
            String result = "";
            for (int i = value.ToString().Length - 1; i >= 0; i--)
            {
                Int64 r = (Int64)(value / Math.Pow(10, i));
                result += NUMS[r % 10];
                result +=  UNITS[i];
            }
            result = result.Replace("[十, 百, 千]零", "$1");
            result = result.Replace("零[十, 百, 千]", "零");
            result = result.Replace("零+", "零");
            result = result.Replace("零([万, 亿])", "$1");
            result = result.Replace("亿万", "亿"); // 亿万位拼接时发生的特殊情况  
            if (result.StartsWith("一十"))
                result = result.Substring(1);
            if (result.EndsWith("零"))
                result = result.Substring(0, result.ToString().Length - 1);
            return result;
        }  
    }
}
