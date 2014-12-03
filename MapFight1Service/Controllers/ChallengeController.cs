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
    public class ChallengeController : TableController<Challenge>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MapFight1Context context = new MapFight1Context();
            DomainManager = new EntityDomainManager<Challenge>(context, Request, Services);
        }

        // GET tables/Challenge
        public IQueryable<Challenge> GetAllChallenge()
        {
            return Query(); 
        }

        // GET tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Challenge> GetChallenge(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Challenge> PatchChallenge(string id, Delta<Challenge> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostChallenge(Challenge item)
        {
            Challenge current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteChallenge(string id)
        {
             return DeleteAsync(id);
        }

    }
}