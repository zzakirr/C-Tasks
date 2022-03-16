using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*string name = Console.ReadLine();
            int test = 0;
            for (int i = 0; i < name.Length; i++)
            {
                switch (name[i])
                {
                    case '0':
                        {
                            test ++;
                            break;
                        }
                    case '1':
                        {
                            test ++;
                            break;
                        }
                    case '2':
                        {
                            test ++;
                            break;
                        }
                    case '3':
                        {
                            test ++;
                            break;
                        }
                    case '4':
                        {
                            test++;
                            break;
                        }
                    case '5':
                        {
                            test++;
                            break;
                        }
                    case '6':
                        {
                            test ++;
                            break;
                        }
                    case '7':
                        {
                            test ++;
                            break;
                        }
                    case '8':
                        {
                            test ++;
                            break;
                        }
                    case '9':
                        {
                            test ++;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }
            if (test == 0)
                Console.WriteLine("yoxdu");
            else
                Console.WriteLine("var");
            */
            #endregion

            #region Task-2
            /*string name = Console.ReadLine();
            bool k = true;
            for (int i = 1; i < name.Length; i++)
            {
                if (name[i - 1] == 'a' && name[i] == 'l')
                    k = false;
            }
            if (k == true)
                Console.WriteLine("yoxdu");
            else
                Console.WriteLine("var");
            */
            #endregion

            #region Task-3
            /*string name = Console.ReadLine();
            int number = Convert.ToInt32(name);
            int sum = 0, count = 0;
            while(number > 0)
            {
                sum += number % 10;
                count++;
                number /= 10;
            }
            int edorta = sum / count;
            Console.WriteLine(edorta);
            */
            #endregion

            #region Task-4
            /*string[] name = new string[4];
            int count = 0;
            Console.WriteLine("4 dene soz elave et:");
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            for (int i = 0; i < name.Length; i++)
            {
                int test = 0;
                for (int j = 0; j < name[i].Length; j++)
                {
                    switch (name[i][j])
                    {
                        case '0':
                            {
                                test++;
                                break;
                            }
                        case '1':
                            {
                                test++;
                                break;
                            }
                        case '2':
                            {
                                test++;
                                break;
                            }
                        case '3':
                            {
                                test++;
                                break;
                            }
                        case '4':
                            {
                                test++;
                                break;
                            }
                        case '5':
                            {
                                test++;
                                break;
                            }
                        case '6':
                            {
                                test++;
                                break;
                            }
                        case '7':
                            {
                                test++;
                                break;
                            }
                        case '8':
                            {
                                test++;
                                break;
                            }
                        case '9':
                            {
                                test++;
                                break;
                            }
                        default:
                            break;
                    }
                    
                }
                if (test > 0)
                    count++;
            }
            Console.WriteLine(count);
            */
            #endregion
        }
    }
    }


