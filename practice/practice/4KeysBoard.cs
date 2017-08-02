using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class _4KeysBoard
    {
        public string MaxA(string senate)
        {
            Queue<string> senateQ = new Queue<string>();
            

            while (senate.Distinct().Count() > 1)
            {
                char[] members = senate.ToCharArray();
                for (int i = 0; i < members.Length; )
                {
                    if(members.Contains('R')||members.Contains('D'))
                    { }
                    char c = members[i];
                    if (i + 1 < members.Length)
                    {
                        if (c == members[i + 1])
                        {
                            i++;
                        }
                        else
                        {
                            members[i + 1] = 'A';
                            i += 2;
                        }
                    }
                    else if (i + 1 == members.Length)
                    {
                        if (members[0] == 'A')
                        {
                            i++;
                        }
                        else
                        {
                            if(members[i]==members[0])
                            {
                                i = 0;
                            }
                            else 
                            {
                                members[0] = 'A';
                                i = 1;
                            }
                            


                        }
                        
                    }
                    else
                    {
                        i++;
                    }
                }
                senate = new string(members);
                senate = senate.Replace("A", "");
            }
            if (senate.Contains("D"))
            {
                return "Dire";
            }
            else //(senate.Contains("R"))
            {
                return "Radiant";
            }


        }

        //static void Main(string[] args)
        //{
        //    _4KeysBoard call = new _4KeysBoard();
        //    Console.WriteLine(call.MaxA("RDD"));
        //    Console.ReadLine();
        //}
    }
}
