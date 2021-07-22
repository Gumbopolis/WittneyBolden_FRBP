using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

using GlobalAnomaliesAPI.Models;

namespace GlobalAnomaliesAPI.Controllers
{
    public class GlobalAnomaliesController : ApiController
    {
        // private List<ConstructedGraph> constructedGraph;


        private GlobalAnomaliesController()
        {
            // constructedGraph = new List<ConstructedGraph>();

            // constructedGraph.Add(GetConstructedGraph());
        }


        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(GetConstructedGraph());
        }

        // GET api/values/5
        // This will be redirected to Get()
        /* public IHttpActionResult Get(int id)
        {
            return NotFound();
        }*/

        // POST api/values
        /// <summary>
        /// POST verb: This will be return an error  as post, put and edelete are not necessary
        /// </summary>
        /// <param name="value"></param>
        /// <returns>IHttpActionResult</returns>
        // This will be return an error  as post, put and edelete are not necessary
        public IHttpActionResult Post([FromBody] string value)
        {
            return BadRequest();
        }

        // PUT api/values/5
        /// <summary>
        /// PUT verb: This will be return an error  as post, put and edelete are not necessary
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IHttpActionResult</returns>
        // This will be return an error  as post, put and edelete are not necessary
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            return BadRequest();
        }

        // DELETE api/values/5
        /// <summary>
        /// DELETE verb: This will be return an error  as post, put and edelete are not necessary
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IHttpActionResult</returns>
        // This will be return an error  as post, put and edelete are not necessary
        public IHttpActionResult Delete(int id)
        {
            return BadRequest();
        }

        private GraphLabel GetGraphLabel()
        {
            return new GraphLabel();
        }

        private ConstructedGraph GetConstructedGraph()
        {
            return new ConstructedGraph();       
        }
    }
}
