using Microsoft.WindowsAzure.Mobile.Service;
using System.Collections.Generic;

namespace MapFight1Service.DataObjects
{
    public class Challenge: EntityData
    {
        public string ChallengeId { get; set; }
        public string Title { get; set; }
        public string QuestionIds {get;set;}
        public virtual ICollection<ChallengeQuestion> ChallengeQuestions { get; set; }
        public int LowLevel { get; set; }
        public int HighLevel { get; set; }
        public bool Borders { get; set; }
        public bool Flags { get; set; }
        public bool Completed { get; set; }
        public bool Pending { get; set; }

        //eg with navigation property
        /*
        public string ProjectId { get; set; }
        public virtual Project Project { get; set; }
         * */
    }
}