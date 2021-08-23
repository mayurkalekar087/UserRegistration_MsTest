using System;

namespace UserRegistration_MsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Using MsTest !");

            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Mayur");
            bool result1 = pattern.ValidateFirstName("Kalekar");


            try
            {
                if (result != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                if (result1 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}