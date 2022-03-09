using System;

namespace test_github_to_vscode
{
    public class Factorial
    {
        public int FactR(int n)
        {
            checked
            {
                if(n==1) return 1;
                else return FactR(n-1) * n;
            }
        }
    }
}