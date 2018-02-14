﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Simple_API_Example.Controllers
{
    [Authorize]
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("getValues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("getVal")]
        public string Get(int id)
        {
            return "value" + id.ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        [Route("postVal")]
        public HttpResponseMessage post([FromBody]string value)
        {
            string val = value;
            return new HttpResponseMessage()
            { StatusCode = HttpStatusCode.Created };
        }
        [Route("GetStudentByIdForYear/SID/{id}/Year/{year:int}")]
        public dynamic GetStudentByIdForYear(string id, int year)
        {
            string IID = id;
            int IYear = year;

            return  new HttpResponseMessage()
            { StatusCode = HttpStatusCode.Created };
        }
    }
}
