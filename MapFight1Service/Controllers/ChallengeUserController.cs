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
    public class ChallengeUserController : TableController<ChallengeUser>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MapFight1Context context = new MapFight1Context();
            DomainManager = new EntityDomainManager<ChallengeUser>(context, Request, Services);
        }

        // GET tables/ChallengeUser
        public IQueryable<ChallengeUser> GetAllChallengeUser()
        {
            return Query(); 
        }

        // GET tables/ChallengeUser/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ChallengeUser> GetChallengeUser(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ChallengeUser/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ChallengeUser> PatchChallengeUser(string id, Delta<ChallengeUser> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ChallengeUser/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostChallengeUser(ChallengeUser item)
        {
            ChallengeUser current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ChallengeUser/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteChallengeUser(string id)
        {
             return DeleteAsync(id);
        }

    }
}