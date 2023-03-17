using System.Diagnostics.CodeAnalysis;

namespace EGE_25_5258
{
    class Program
    {
        static void Main(String[] args)
        {
            //for (int i = 103; i < 123456789; i += 103)
            //{
            //    string num = Convert.ToString(i);
            //    bool flag = true;
            //    for (int j = 0; j < num.Length - 1; j++)
            //    {
            //        if (!(num[j] < num[j + 1]))
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if (flag == true)
            //    {
            //        Console.WriteLine($"{num} {i / 103}");
            //    }
            //}
            int del = 0;
            int r = 0;
            for (int nums = 100000; nums < 500001; nums++)
            {
                List<int> dels = new List<int>();
                for (int d = 1;d <= nums; d++)
                {
                    if (nums % d == 0)
                    {
                        del++;
                        dels.Add(d);
                    }
                }
                if (del > 3 )
                {
                    bool flag = true;
                    for (int a = 1; a < dels.Count - 1; a++)
                    {

                        r = dels[a] - dels[0];
                        for (int b = 2; b < dels.Count; b++)
                        {
                            if (dels[b] - dels[a] != r)
                            {
                                flag = false;
                                break;
                            }
                            else if (dels[b] - dels[a] == r && r != 0)
                            {
                                Console.WriteLine($"{nums} {dels.Count*r}");
                            }
                        }

                        //r = dels[j + 1] - dels[j];
                        //if (dels[j + 2] - dels[j + 1] == r && r != 0 && dels[j+3] - dels[j+2]==r)
                        //{
                        //    Console.WriteLine($"{nums} {dels.Count*r}");

                        //}
                    }
                }
                del= 0;
            }
        }
    }
}
