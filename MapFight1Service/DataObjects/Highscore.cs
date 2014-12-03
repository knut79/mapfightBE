using Microsoft.WindowsAzure.Mobile.Service;

namespace MapFight1Service.DataObjects
{
    public class Highscore : EntityData
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int AnsweredQuestions { get; set; }
        public int Seconds { get; set; }
        public int Level { get;set; }
        public string ChallengeId { get; set; }
        public virtual Challenge Challenge { get; set; }
    }
}