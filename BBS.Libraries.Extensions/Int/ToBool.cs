//-----------------------------------------------------------------------
//    MIT License
//
//    Copyright (c) 2016 Betabyte Software
//
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace BBS.Libraries.Extensions
{
    public static partial class Int
    {
        public static bool ToBoolean(this int helper)
        {
            switch (helper)
            {
                case 0:
                    return false;
                    break;
                case 1:
                    return true;
                    break;
                default:
                    return false;
            }
        }

        public static bool ToBoolean(this int helper, IEnumerable<int> trueValues = null,
            IEnumerable<int> falseValues = null, bool @default = false)
        {
            if (trueValues != null && trueValues.Contains(helper))
            {
                return true;
            }
            else if (falseValues != null && falseValues.Contains(helper))
            {
                return false;
            }
            else
            {
                return @default;
            }
        }
    }
}
