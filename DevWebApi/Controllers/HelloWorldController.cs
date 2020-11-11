using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevWebApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        public IEnumerable<string> get()
        {
            return new string[] { "안녕하세요", "반갑습니다" };
        }
    }
}
