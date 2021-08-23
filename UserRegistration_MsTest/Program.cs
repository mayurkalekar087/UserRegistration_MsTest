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

            try
            {
                if (result != true)
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