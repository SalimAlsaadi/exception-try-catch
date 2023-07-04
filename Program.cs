using System.IO;
using System.Linq.Expressions;

namespace practicedForException_try_catch

{
    internal class Program
    {
        static void Main(string[] args)

        {

            try
            {
                
                int EnterNumber = int.Parse( Console.ReadLine());
                int randomNumber = new Random().Next(0, 100);
                
                    Console.WriteLine("Random number is : " + randomNumber);
                    Console.WriteLine("user guess : " + EnterNumber);
                

                
                
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of Range");
            }

            catch(Exception)
            {
                Console.WriteLine("invalid enter");
            }
            


            


            /*
            Console.WriteLine("Please Enter serius number");
            int b = 1;
            for(int a=0; a<b; a++)
            {
                try
                {
                    int enterNum = int.Parse(Console.ReadLine());
                    b++;
                }
                catch (Exception)
                {
                    Console.WriteLine("non-numeric");
                    break;
                }


            }
            


            */

            //////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            
            




          /*

                string data;

            try
            {
                StreamReader textReader = new StreamReader("C:\\Users\\TRA\\Desktop\\salim\\practice.txt");
                data = textReader.ReadToEnd();
                Console.WriteLine(data);
                textReader.Close();
                
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("sorry file not found");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
          */
           
            

                /*
                try
                {
                    Console.WriteLine("Enter your Age"); 
                    int age = int.Parse(Console.ReadLine());
                    if (age <= 0)
                    {
                        Console.WriteLine("Please Enter valid Age");

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter valid Age");
                }
                */






                /*
                try
                {
                    Console.WriteLine("Enter first Number");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second Number");
                    int num2 = int.Parse(Console.ReadLine());


                    Console.WriteLine("the divid of two numbers: " + num1/num2);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("cannot divid by Zero");

                }
                catch (Exception)
                {
                    Console.WriteLine("invalid input");
                }

                */



                ///////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////


                /* int[] num = new int[] { 0, 1, 2, 3, 4, 5 };



                     try
                     {
                         Console.WriteLine(num[4] / num[2]);
                         Console.WriteLine(num[1] / num[0]);
                         Console.WriteLine(num[10] * num[2]);
                         Console.WriteLine(num[2] + num[3]);

                     }
                     catch (DivideByZeroException)
                     {
                         Console.WriteLine("cannot divid by zero");

                     }
                     catch (IndexOutOfRangeException)
                     {
                         Console.WriteLine("items that you entered is out of boundry");
                     }
                     catch (Exception ex)
                     {
                         Console.WriteLine(ex.ToString());
                     }*/
            }
        }
    }


    
