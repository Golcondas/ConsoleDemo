using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedConsole.Common
{
    public class EnumConvertToList<T> where T:struct
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public List<DropdownType> GetList(Type T)
        {
            List<DropdownType> dropList = new List<DropdownType>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                DropdownType model = new DropdownType();
                model.Value = ((int)Enum.Parse(typeof(T), item.ToString()));
                model.Name = ((Enum)item).GetEnumDescription();
                dropList.Add(model);
            }
            return dropList;
        }
    }

    public class DropdownType
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
