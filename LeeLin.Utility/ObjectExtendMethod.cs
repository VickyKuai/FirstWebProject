using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeeLin.Utility
{
    /// <summary>
    /// Object扩展方法
    /// </summary>
    public static class ObjectExtendMethod
    {
        /// <summary>
        /// Object是否不为Null  ，是 返回true ，不是 返回false
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNotNull(this Object obj)
        {
            return obj != null;
        }

        /// <summary>
        /// Object 为null  或Object.toString() ==""   返回true ,否则 false
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this Object obj)
        {
            bool ok = false;
            if (obj != null)
            {
                if (obj.ToString() == "")
                {
                    ok = true;
                }
            }
            else
            {
                ok = true;
            }
            return ok;
        }
    }
}
