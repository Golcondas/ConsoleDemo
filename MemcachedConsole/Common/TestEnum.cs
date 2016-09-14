using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedConsole.Common
{
    public enum TestEnum
    {
        [Description("第一")]
        One,
        [Description("第二")]
        Two,
        [Description("第三")]
        Three,
        Four,
        [Description("第五")]
        Five,
        Six,
        [Description("全部")]
        All
    }
}
