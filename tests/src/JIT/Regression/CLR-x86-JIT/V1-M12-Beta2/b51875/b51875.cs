

using System;
using System.Collections;
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Test
{
    internal struct AA
    {
        public static int Main1()
        {
            AA[] local1 = new AA[10];
            try
            {
                goto EOM;
            }
            finally
            {
                throw new Exception();
            }
        EOM:
            if (((Array)new Object()).Clone() == null)
                return 1;
            return 0;
        }
        public static int Main()
        {
            try
            {
                Main1();
                return 101;
            }
            catch (Exception)
            {
                return 100;
            }
        }
    }
}
