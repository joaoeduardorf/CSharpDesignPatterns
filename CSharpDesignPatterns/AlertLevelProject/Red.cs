using System;
namespace AlertLevelProject
{
    /// <summary>
    /// Red.
    /// </summary>
    public class Red : AlertLevelBase
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="value">Value.</param>
        public override void ProcessRequest(int value)
        {
            Console.WriteLine("The value {0} is red level!", value);
        }
    }
}
