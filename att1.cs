using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analise
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }


        static int LetraA(int n)
        {
            int c = n;
            for (int i = 0; i < n; i++)
            {
                c *= 2;
                c *= 2;
                c *= 2;
                c *= 2;
                c *= 2;
            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    for (int k = 0; k < n; k++)
                    {
                        c *= 2;
                        c *= 2;
                        c *= 2;
                        c *= 2;

                    }

                }
            }

            return c;


        }

        static int LetraB(int n)
        {
            int c = n;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    c *= 2;
                    c *= 2;
                    c *= 2;
                    c *= 2;
                    c *= 2;


                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {
                            c *= 2;
                            c *= 2;
                            c *= 2;
                            c *= 2;
                            c *= 2;
                            c *= 2;
                            c *= 2;
                            c *= 2;
                            c *= 2;


                        }

                    }

                }
            }

            for (int i = 0; i < n; i += 2)
            {
                c *= 2;
            }

            return c;
        }

        static int LetraC(int n)
        {
            int c = n;



            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    for (int k = 0; k < n; k++)
                    {
                        c *= 2;
                        c *= 2;
                        c *= 2;
                        c *= 2;

                    }

                }
            }

            c *= 2;
            c *= 2;

            return c;

        }

        static int LetraD(int n)
        {
            int c = n;

            for (int i = 0; i < n; i /= 2)
            {
                c *= 2;
            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    c *= 2;
                }
            }

           

            return c;

        }

        static int LetraE(int n)
        {
            int c = n;

            for (int i = 0; i < n; i /= 2)
            {
                c *= 2;
                c *= 2;
                c *= 2;
            }

            for (int i = 0; i < n; i /= 2)
            {
                c *= 2;
            }

            return c;
        }

        static int LetraF(int n)
        {
            int c = n;

            for(int i = 0; i < n;i++)
            {
                c *= 2;
                c *= 2;
                for (int j = 0; j < n; j++)
                {
                    c *= 2;
                    c *= 2;
                }
            }

            for (int i = 0; i < n; i/=2)
            {
                c *= 2;
            }

            return c;

        }
    }
}
