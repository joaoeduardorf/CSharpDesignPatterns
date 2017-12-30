using System;
namespace AlertLevelProject
{
    /// <summary>
    /// Green.
    /// </summary>
    public class Green : AlertLevelBase
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="value">Value.</param>
        public override void ProcessRequest(int value)
        {
            if(value < 30)
            {
                Console.WriteLine("The value {0} is green level!", value);
            } else
            {
                _highLevel.ProcessRequest(value);
            }
        }
    }
}
