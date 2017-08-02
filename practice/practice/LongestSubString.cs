using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class LongestSubString
    {
        void CheckString()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string str = Console.ReadLine();
                if (str.Count()==0)
                {
                    Console.WriteLine("null hai bhai");
                }
                char[] charstr=str.ToCharArray();
                string str2=string.Empty;
                Dictionary<string, int> chdic = new Dictionary<string, int>();
                for (int j = 0; j < str.Length; j++)
                {
                    if (!str2.Contains(charstr[j]))
                    {
                        str2 += charstr[j];
                    }
                    else 
                    {
                        if ((!chdic.ContainsKey(str2)))
                        {
                            chdic.Add(str2, str2.Length);
                        }
                        if (j < str.Length && str2.Substring(str2.Length - 1, 1) != charstr[j].ToString())
                        {
                            int s = (str2.LastIndexOf(charstr[j]));
                            s+=1;
                            str2 = str2.Substring((str2.LastIndexOf(charstr[j])) + 1, (str2.Length - ((str2.LastIndexOf(charstr[j])) + 1)));
                        }
                        else
                        {
                            str2 = string.Empty;
                        }
                        
                        str2 += charstr[j];
                    }
                }
                if ((!chdic.ContainsKey(str2)))
                {
                    chdic.Add(str2, str2.Length);
                    str2 = string.Empty;
                }
                Console.WriteLine(chdic.Values.Max());
                //return chdic.Values.Max();
             }
        }
        //static void Main(string[] args)
        //{
        //    LongestSubString call = new LongestSubString();
        //    call.CheckString();
        //    Console.ReadLine();
        //}
    }
}