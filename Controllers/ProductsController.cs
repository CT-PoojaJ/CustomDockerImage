using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerAppWebApiEg2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerAppWebApiEg2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> lstProducts;
        public ProductsController()
        {
            lstProducts = new List<Product>();
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "AC";
            lstProducts.Add(p1);
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return lstProducts;
        }


        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product p = lstProducts.Find(x => x.Id == id);
            if(p==null)
            {

            }
            return p;
        }
    }
}
