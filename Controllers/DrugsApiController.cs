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
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(DrugsApiController));
        IRepository _item;
        
        public DrugsApiController(IRepository drugrepo)
        {
            _item = drugrepo;

        }
        [HttpGet("{id:int}", Name = "Get")]
        public List<LocationWiseDrug> searchDrugsByID(int id)
        {
            _log4net.Info("Id Entered For Searching");
            return _item.searchDrugsByID(id);
        }


        [HttpGet("{name}")]
        public List<LocationWiseDrug> searchDrugsByName(string name)
        {
            _log4net.Info("Name Entered For Searching");
            return _item.searchDrugsByName(name);
        }

        [HttpPost]
        public bool getDispatchableDrugStock([FromBody] DrugLocation model)
        {
            _log4net.Info("Input Recieved From Another Api");
            DrugRepository obj = new DrugRepository();
            return obj.getDispatchableDrugStock((int)model.Id, (string)model.Location);
        }

    }
}
