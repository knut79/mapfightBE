using Microsoft.WindowsAzure.Mobile.Service;

namespace MapFight1Service.DataObjects
{
    public class User : EntityData
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string UserFbId { get; set; }
        public int Level { get; set; }

    }
}