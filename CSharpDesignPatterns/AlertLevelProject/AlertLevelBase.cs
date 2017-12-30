namespace AlertLevelProject
{
    /// <summary>
    /// Alert level base.
    /// </summary>
    public abstract class AlertLevelBase
    {
        protected AlertLevelBase _highLevel;

        public void SetHighLevel(AlertLevelBase highLevel)
        {
            _highLevel = highLevel;
        }

        public abstract void ProcessRequest(int value);
    }
}
