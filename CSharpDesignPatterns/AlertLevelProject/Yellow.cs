using System;
namespace AlertLevelProject
{
    /// <summary>
    /// Yellow.
    /// </summary>
    public class Yellow : AlertLevelBase
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="value">Value.</param>
        public override void ProcessRequest(int value)
        {
            if (value < 50)
            {
                Console.WriteLine("The value {0} is yellow level!", value);
            }
            else
            {
                _highLevel.ProcessRequest(value);
            }
        }
    }
}
