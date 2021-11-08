using System;
using System.Collections.Generic;
using System.Text;

namespace StartPointCSharpDotNetConsole
{
    public static class Extention
    {
        public static bool ToBool(this object obj)
        {
            try
            {
                if (obj?.ToString() == "1")
                    obj = "true";
                return bool.TryParse(obj?.ToString(), out var result) && result;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool ToBool1(this object obj)
        {
            bool retVal = false;
            try
            {
                retVal = Convert.ToBoolean(obj);
            }
            catch
            {
                retVal = false;
            }
            return retVal;
        }


    }
}
