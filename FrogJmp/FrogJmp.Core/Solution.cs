using System;

namespace FrogJmp.Core
{
    public class Solution
    {
        public int GetFrogJump(int X, int Y, int D)
        {
            double oper = (Y - X) / (double) D;
            return (int)Math.Ceiling(oper);
        }
    }
}
