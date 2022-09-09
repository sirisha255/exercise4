namespace exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed Limit value");
            int speedlimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car");
            int carspeed = Convert.ToInt32(Console.ReadLine());
            if (carspeed > speedlimit)
            {
                int failurePoints = 0;
                while (carspeed > speedlimit)
                {
                    carspeed -= 5;
                    failurePoints++;
                }

                if (failurePoints > 12)
                    Console.WriteLine("License Suspended.");
            }
            else
            {
                Console.WriteLine("OK");
            }

        }
    }
}
