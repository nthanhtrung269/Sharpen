﻿using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace CSharp70.UseOutVariablesInMethodInvocations
{
    static class OutClass
    {
        public static bool Method(int i, out int j, ref int l)
        {
            j = 0;
            l = l == 0 ? 1: 0;
            return true;
        }

        public static bool Method(int i, out int j)
        {
            j = 0;
            return true;
        }

        public static bool Method(out int i, out int j)
        {
            i = 0;
            j = 0;
            return true;
        }

        public static IEnumerable<T> EnumerableMethod<T>(out int i)
        {
            i = 0;
            return Enumerable.Empty<T>();
        }

        public static bool Bool(bool value) => value;
    }
}