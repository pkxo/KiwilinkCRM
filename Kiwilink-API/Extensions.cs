﻿using System;
using System.Threading;

namespace Kiwilink
{
    public static class Extensions
    {
        public static string TitleCaseMe(this String value)
        {
            if(value == null)
            {
                return null;
            }

            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value);
        }
    }
}
