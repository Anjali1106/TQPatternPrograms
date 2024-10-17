using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQPatternPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1)
            //     *****
            //      ****
            //       ***
            //        **
            //         *

            //for (int i = 5; i >= 1; i--) {
            //    for (int j = 5; j >i; j--) {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}





            //  2) Print pattern
            //            1
            //            12
            //            123
            //            1234
            //            12345
            //            1234
            //            123
            //            12
            //            1

            // 1st half
            //for (int i = 1; i <= 5; i++) {
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //// 2nd half
            //for (int i = 4; i >= 1; i--) {
            //    for (int j = 1; j <= i; j++) { 
            //    Console.Write(j); 
            //    }
            //    Console.WriteLine();
            //}





            //  3) Print pattern
            //        1
            //        121
            //        12321
            //        1234321
            //        123454321
            //        1234321
            //        12321
            //        121
            //        1

            //for (int i = 1; i <= 5; i++) {
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(j);
            //    }
            //    for (int j = i - 1; j >= 1; j--) {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--) {
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(j);
            //    }
            //    for (int j = i - 1; j >= 1; j--) {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}





            //  4)
            //         1
            //        1 2
            //       1 2 3
            //      1 2 3 4
            //     1 2 3 4 5
            //    1 2 3 4 5 6
            //   1 2 3 4 5 6 7

            //for (int i = 1; i <= 7; i++)
            //{

            //    for (int j = 1; j <= 7-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(j+" ");
            //    }
            //    Console.WriteLine();
            //}





            //5)
            //             1
            //            2 2
            //           3 3 3
            //          4 4 4 4
            //         5 5 5 5 5
            //        6 6 6 6 6 6
            //       7 7 7 7 7 7 7

            //for (int i = 1; i <= 7; i++) {
            //    for (int j = 1; j <= 7-i; j++) {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(i+" ");
            //    }
            //    Console.WriteLine();
            //}



            //6.WAP to print following Pattern
            //        *
            //        **
            //        ***
            //        ****
            //        *****
            //        *****
            //        ****
            //        ***
            //        **
            //        *

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 5; i >= 1; i--) {
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            //7) WAP to print following Pattern
            //     *
            //    * *
            //   * * *
            //  * * * *
            // * * * * *
            //  * * * *
            //   * * *
            //    * *
            //     *


            // 1st pyramid
            //for (int i = 1; i <= 5; i++) {
            //    for (int j = 1; j <= 5- i; j++) {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i * 2 - 1; j++) { 

            //    Console.Write("*"); 
            //    }
            //    Console.WriteLine();
            //}

            //// reverse pyramid
            //for (int i = 4; i > 0; i--) {
            //    for (int j = 1; j <= 5-i; j++) {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i * 2 - 1; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            //8)     WAP to print following Pattern

            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1

            // for (int i = 1; i <= 5; i++) {
            //        int num;
            //        if (i % 2 == 0)
            //        {
            //            num = 0;
            //            for (int j = 1; j <= 5; j++)
            //            {
            //                Console.Write(num);
            //                num = (num == 0) ? 1 : 0;
            //            }
            //        }
            //        else {
            //            num = 1;
            //            for (int j = 1; j <= 5; j++) {
            //                Console.Write(num);
            //                num = (num == 0) ? 1 : 0;   
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}





            //9)          ab
            //          ababab
            //        ababababab

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3 - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i * 2 - 1; j++)
            //    {

            //        Console.Write("ab");
            //    }
            //    Console.WriteLine();


            //}
        }
    }
}
