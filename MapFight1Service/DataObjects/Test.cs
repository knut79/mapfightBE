using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.WindowsAzure.Mobile.Service;

namespace MapFight1Service.DataObjects
{
    public class Test : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}