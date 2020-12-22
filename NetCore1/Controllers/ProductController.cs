using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore1.Models;

namespace NetCore1.Controllers
{
    /// <summary>
    /// 自创建的测试Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// 获取产品信息接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetProducts()
        {
            return new JsonResult(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "牛奶",
                    Price = 2.5f
                },
                new Product
                {
                    Id = 2,
                    Name = "面包",
                    Price = 4.5f
                }
            });
        }

      
    }
}
