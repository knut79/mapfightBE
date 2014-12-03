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
    public class HighscoreController : TableController<Highscore>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MapFight1Context context = new MapFight1Context();
            DomainManager = new EntityDomainManager<Highscore>(context, Request, Services);
        }

        // GET tables/Highscore
        public IQueryable<Highscore> GetAllHighscore()
        {
            return Query(); 
        }

        // GET tables/Highscore/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Highscore> GetHighscore(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Highscore/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Highscore> PatchHighscore(string id, Delta<Highscore> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Highscore/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostHighscore(Highscore item)
        {
            Highscore current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Highscore/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteHighscore(string id)
        {
             return DeleteAsync(id);
        }

    }
}