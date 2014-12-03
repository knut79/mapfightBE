using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using MapFight1Service.DataObjects;
using MapFight1Service.Models;

namespace MapFight1Service.Controllers
{
    public class UserFriendController : TableController<UserFriend>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MapFight1Context context = new MapFight1Context();
            DomainManager = new EntityDomainManager<UserFriend>(context, Request, Services);
        }

        // GET tables/UserFriend
        public IQueryable<UserFriend> GetAllUserFriend()
        {
            return Query(); 
        }

        // GET tables/UserFriend/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserFriend> GetUserFriend(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/UserFriend/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserFriend> PatchUserFriend(string id, Delta<UserFriend> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/UserFriend/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostUserFriend(UserFriend item)
        {
            UserFriend current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/UserFriend/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserFriend(string id)
        {
             return DeleteAsync(id);
        }

    }
}