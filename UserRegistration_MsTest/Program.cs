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
            bool result1 = pattern.ValidateLastName("Kalekar");
            bool result2 = pattern.ValidateEmail("mayurkalekar550@gmail.com");

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
                if (result2 != true)
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