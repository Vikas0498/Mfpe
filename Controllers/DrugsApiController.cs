using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MfpeDrugsApi.Models;
using MfpeDrugsApi.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MfpeDrugsApi.Controllers
{
   [Route("api/[controller]/[action]")]
   [ApiController]
    public class DrugsApiController : ControllerBase
    {
        IRepository<Drug> _item;

        public DrugsApiController(IRepository<Drug> drugrepo)
        {
            _item = drugrepo;

        }
        [HttpGet("{id:int}", Name = "Get")]
        public Drug GetById(int id)
        {
            return _item.Get(id);
        }


        [HttpGet("{name}")]
        public Drug GetByName(string name)
        {
            return _item.Get(name);
        }

        [HttpPost]
        public bool Check([FromBody] DrugLocation model)
        {
            DrugLocationRepository obj = new DrugLocationRepository();
            return obj.Check((int)model.Id, (string)model.Location);
        }

    }
}
