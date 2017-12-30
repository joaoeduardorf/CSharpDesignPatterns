using System;

namespace AlertLevelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup the levels
            AlertLevelBase greenLevel = new Green();
            AlertLevelBase yellowLevel = new Yellow();
            AlertLevelBase redLevel = new Red();

            //Set high levels
            greenLevel.SetHighLevel(yellowLevel);
            yellowLevel.SetHighLevel(redLevel);

            //Examples
            greenLevel.ProcessRequest(10);
            greenLevel.ProcessRequest(30);
            greenLevel.ProcessRequest(50);

            Console.ReadKey();
        }
    }
}
