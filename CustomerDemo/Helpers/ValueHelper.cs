using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo.Helpers
{
    public static class ValueHelper
    {
        public static int toInt(object value)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                return 0;
            }
            return result;
        }

    }
}
