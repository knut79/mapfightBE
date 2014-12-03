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
    public class TestController : TableController<Test>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MapFight1Context context = new MapFight1Context();
            DomainManager = new EntityDomainManager<Test>(context, Request, Services);
        }

        // GET tables/Test
        public IQueryable<Test> GetAllTest()
        {
            return Query(); 
        }

        // GET tables/Test/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Test> GetTest(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Test/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Test> PatchTest(string id, Delta<Test> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Test/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostTest(Test item)
        {
            Test current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Test/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTest(string id)
        {
             return DeleteAsync(id);
        }

    }
}