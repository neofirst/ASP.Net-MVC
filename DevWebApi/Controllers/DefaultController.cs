using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevWebApi.Controllers
{
    public class DefaultController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "안녕하세요", "반갑습니다" };
        }

        public string Get(int id)
        {
            return "입력 값:" + id.ToString();
        }
    }
}
