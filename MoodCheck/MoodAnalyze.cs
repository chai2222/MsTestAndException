

namespace MoodCheck
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }
        }
    }
}
