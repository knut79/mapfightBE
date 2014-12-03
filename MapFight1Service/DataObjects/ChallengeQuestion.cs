using Microsoft.WindowsAzure.Mobile.Service;

namespace MapFight1Service.DataObjects
{
    public class ChallengeQuestion: EntityData
    {
        public string ChallengeId { get; set; }
        public virtual Challenge Challenge { get; set; }
        public string QuestionId { get; set; }
        public virtual Question Question { get; set; }
        //public Challenge Challenge { get; set; }
        //public Question Question { get; set; }
    }
}