using Microsoft.WindowsAzure.Mobile.Service;

namespace MapFight1Service.DataObjects
{
    public class ChallengeUser: EntityData
    {
        public string ChallengerId { get; set; }
        public virtual User Challenger { get; set; }
        public string RecipientId { get; set; }
        public virtual User Recipient { get; set; }
        public string ChallengeId { get; set; }
        public virtual Challenge Challenge { get; set; }
    }
}