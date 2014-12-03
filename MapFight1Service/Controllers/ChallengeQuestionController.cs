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
    public class ChallengeQuestionController : TableController<ChallengeQuestion>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MapFight1Context context = new MapFight1Context();
            DomainManager = new EntityDomainManager<ChallengeQuestion>(context, Request, Services);
        }

        // GET tables/ChallengeQuestion
        public IQueryable<ChallengeQuestion> GetAllChallengeQuestion()
        {
            return Query(); 
        }

        // GET tables/ChallengeQuestion/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ChallengeQuestion> GetChallengeQuestion(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ChallengeQuestion/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ChallengeQuestion> PatchChallengeQuestion(string id, Delta<ChallengeQuestion> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ChallengeQuestion/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostChallengeQuestion(ChallengeQuestion item)
        {
            ChallengeQuestion current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ChallengeQuestion/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteChallengeQuestion(string id)
        {
             return DeleteAsync(id);
        }

    }
}