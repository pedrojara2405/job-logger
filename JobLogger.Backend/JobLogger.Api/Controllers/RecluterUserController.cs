using JobLogger.Business;
using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobLogger.Api.Controllers
{
    public class RecluterUserController : ApiController
    {
        private RecluterUserBusiness _recluterUserBusiness;

        public RecluterUserController()
        {
            _recluterUserBusiness = new RecluterUserBusiness();
        }

        public IHttpActionResult GetAll()
        {
            List<RecluterUser> recluterUsers = _recluterUserBusiness.GetAll().ToList();
            return Ok(200);
        }

        public IHttpActionResult Get(int recluterUserId)
        {
            RecluterUser recluterUser = _recluterUserBusiness.Get(recluterUserId);
            return Ok(200);
        }
    }
}
