﻿namespace System
{
    static class StringExtensions
    {
        public static string cut(this string strObj, int count)
        {
            if(strObj.Length <= count)
            {
                return strObj;
            }
            else
            {
                return strObj.Substring(0, count) + "...";
            }
        }
    }
}
