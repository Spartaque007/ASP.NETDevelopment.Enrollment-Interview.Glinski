﻿using System.Collections.Generic;


namespace Gliski.Utils
{
    public class StringLengthComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if(x!=null && y!=null )
            {
                if(x.Length>y.Length)
                {
                    return 1;
                }
                else if (x.Length==y.Length)
                {
                    return 0;
                }
                else if (x.Length<y.Length)
                {
                    return -1;
                }
            }
            if(x==null&&y!=null)
            {
                return 1;
            }
            if (x!= null && y == null)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
