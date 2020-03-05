using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message greet = new Message();
            greet.WriteMessage("Good Afternoon");
            int[] list={2,1,3,5,3,2};
            Console.WriteLine(firstDuplicate(list));
        }
        static int firstDuplicate(int[] a) {
            int FirstMatch = 0;
            int MatchIndex = -1;
            int LowIndex = a.Length;

            for(int i=0;i < a.Length; i++)
            {
                int k=i+1;
                while (k<a.Length)
                {
                    if (a[i] == a[k])
                    {
                        FirstMatch = a[i];
                        //int[] Match = {i,k};
                        //LowIndex = Match.Max();
                        MatchIndex = k;
                        if (MatchIndex<=LowIndex)
                        {
                            LowIndex = k;
                        
                        }
                        
                    }
                    k++;

                }
            }
            if (MatchIndex != -1)
            {
                    
                return a[LowIndex];
            }
            
            return MatchIndex;
}

    }
}


