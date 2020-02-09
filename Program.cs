using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";

            string t = UsfTime(s);
           
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            Console.WriteLine("======" + "NIM GAME" + "=============");
            Console.WriteLine("Enter No. of Stone:");
            String no = Console.ReadLine();
            int n4 = Convert.ToInt32(no);
            Stones(n4);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                // static void printPatternRowRecur(int n)
                //{
                //if (n < 1)
                //return;
                //Console.Write(n);
                // printPatternRowRecur(n - 1);
                // }
                // if (n < 1)
                //    return;
                //printPatternRowRecur(n);
                // move to next line 
                //Console.WriteLine();
                // print number of the  
                // remaining rows recursively 
                //PrintPattern(n - 1);
                ///===================================////
                Console.WriteLine("Recursive number Print");
                int k = n;
                 for (int j = 0; j<= n; j++)
                 {

                for (int i = k; i > 0; i--)
               {
                  Console.Write(i);
                }
                 k -= 1;
                Console.WriteLine();
                 }




            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                int  sum, i, j;

                Console.WriteLine("====="+" Sum of No. Print Series"+"===========");

                for (i=1;i<=n2;i++)
                {
                    sum = 0;
                    for (j=1;j<=i;j++)
                    {
                        sum = sum + j;
                     
                    }
                 
                   Console.WriteLine(sum);
                }
                
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {

                Console.WriteLine("====="+ "USF TimeZone"+"=============");
                string[] time = s.Split(':');
                int hrs = Convert.ToInt32(time[0]);
                int min = Convert.ToInt32(time[1]);
                String var = time[2];
                int len = var.Length;
                char[] var1;
                var1 = var.ToCharArray();
                char first_half;
                String seccon="";
               for (int i=0;i<=len/2 -1;i++)
                {
                    first_half = var1[i];
                   seccon = seccon + Convert.ToString(first_half);
                   
                }
                int sec = Convert.ToInt32(seccon);
                String lastt = "";
               for (int j=len/2; j<len;j++)
                {
                    char second_half = var1[j];
                    lastt = lastt + Convert.ToString(second_half);
                }

                if (lastt == "PM")
                {
                    hrs += 12;
                }
                // Console.Write(hrs + " " + min + " " + var);
                int earthtimeins = ((hrs * 60 + min) * 60 + sec);
                int usfhrs = earthtimeins / (60 * 45);
                earthtimeins -= usfhrs * 60 * 45;
                int usfmin = earthtimeins / 45;
                earthtimeins -= usfmin * 45;
                int usfsec = earthtimeins;
                Console.WriteLine(usfhrs + " " + usfmin + " " + usfsec);

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                Console.WriteLine("======"+ "USF No.Print" +"============");

                for (int i = 1; i <=n3; i++)
                {

                    if (i % 3 == 0 && i!=0)
                    { Console.Write("U" + " "); }
                    else if (i % 5 == 0 && i != 0) 
                    { Console.Write("S" + " "); }
                    else if (i % 7 == 0 && i != 0) 
                    { Console.Write("F" + " "); }
                    else if (i % 3 == 0 && i % 5 == 0 && i != 0) 
                    { Console.Write("US" + " "); }
                    else if (i % 5 == 0 && i % 7 == 0 && i != 0) 
                    { Console.Write("SF" + " "); }
                    else
                    { Console.Write(i + " "); }
                   
                    if (i % k == 0 && i != 0) Console.WriteLine();
                    
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }


        public static bool isPalindrome(string str)
        {
            int len = str.Length;

            // compare each character from starting 
            // with its corresponding character from last 
            int j = len - 1;
            for (int i = 0; i < len/2; i++)
            {
                if (str[i] != str[j])
                {
                 return false;
                }
                j--;
            }
            return true;
        }
        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.WriteLine("==================");
                Console.WriteLine("Palindrome Check");
                // Function to check if a palindrome pair exists 

                for (int i = 0; i < words.Length; i++)
                    {

                        for (int j = 0; j < words.Length; j++)
                        {
                            string check_str;

                            // concatenate both strings 
                            check_str = words[i] + words[j];
                           // Console.WriteLine(check_str);

                            // check if the concatenated string is 
                            // palindrome 
                            if ((i!=j) && isPalindrome(check_str))
                                        Console.WriteLine("["+i + "," + j+"] ");
                           
                        }
                        
                    }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {

                
                if (n4 % 4 ==0 )
                { Console.WriteLine("FALSE : Player 2 is the winner"); }
                else
                {
                    Console.WriteLine("TRUE: Player 1 is the winner");
                    int firstmove = n4 % 4;
                    int numbermoves = 2 * (n4 / 4) + 1;
                    int numberoptions = 3 ^ (numbermoves/2);
                    string[] wincombos = new string[] { ",3,1", ",2,2", ",1,3" };
                    Console.WriteLine("Number of Moves = "+ numbermoves + " -> ");
                    Console.WriteLine("Winning sets of moves:");
                    for (int i=0; i<=numberoptions; i++)
                    {
                        string thisoption = "[" + firstmove;
                       // Console.Write("\n[" + firstmove);
                        for (int j=0; j < (numbermoves/2);j++)
                        {
                            thisoption += wincombos[(i + j) % 3];
                            //Console.Write(wincombos[(i+j)%3]);
                        }
                        thisoption += "]";
                        Console.WriteLine(thisoption);
                    }
             
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
