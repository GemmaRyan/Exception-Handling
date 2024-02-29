namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MethodA();

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught in the index out of range exception handler in the main method" + ex.Message);
                Console.WriteLine("The stack trace is " + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in the general exception handler in the main method" + ex.Message);
                Console.WriteLine("The stack trace is " + ex.StackTrace);
            }
        }
        static void MethodA()
        {
            MethodB();
        }

        static void MethodB()
        {
            MethodC();
        }
        static void MethodC()
        {
            MethodD();
        }
        static void MethodD()
        {
            int[] numbers = new int[5];
            numbers[5] = 10;
            Console.WriteLine("Number at index 5: " + numbers[5]);
        }
    }
}

