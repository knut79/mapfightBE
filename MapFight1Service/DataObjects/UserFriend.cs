using Microsoft.WindowsAzure.Mobile.Service;

namespace MapFight1Service.DataObjects
{
    public class UserFriend : EntityData
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string FriendUserId { get; set; }
        public virtual User FriendUser { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Bottles { get; set; }
        public long Credits { get; set; }
    }
}