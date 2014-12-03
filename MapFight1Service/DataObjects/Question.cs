using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapFight1Service.DataObjects
{
    public class Question: EntityData
    {
        public string QuestionId {get;set;}
        public string Title { get; set; }
        public string Type { get; set; }
        //_? do we need this
        public virtual ICollection<ChallengeQuestion> ChallengeQuestions { get; set; }
    }
}