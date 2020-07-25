using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace IceCoffee.AntiDebugEngine
{
    public static class AntiDebug
    {
        public const string DllName = "AntiDebug_C.dll";

        public const string DllMD5 = "13b0fde74cd2fd02ba7abbef33bd158d";

        [DllImport(DllName, EntryPoint = "AntiDebug")]
        private extern static bool AntiDebug_C();

        /// <summary>
        /// 返回true说明处于被调试状态
        /// </summary>
        /// <returns></returns>
        public static bool AntiDebug_DotNet()
        {
            return AntiDebug_C();
        }
    }
}
