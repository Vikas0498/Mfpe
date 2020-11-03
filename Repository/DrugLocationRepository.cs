using MfpeDrugsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfpeDrugsApi.Repository
{
    public class DrugLocationRepository : IRepository<DrugLocation>
    {
        public List<DrugLocation> items = new List<DrugLocation>();
        public DrugLocationRepository()
        {
            Add(new DrugLocation { Id = 1,Location="Delhi", Quantity=10, DrugName = "Disprin" });
            Add(new DrugLocation { Id = 2,Location = "Dehradun", Quantity = 15, DrugName = "Paracetamol" });

        }
        public void Add(DrugLocation item)
        {
            items.Add(item);  
        }

        public bool Check(int id, string location)
        {
            return items.Any(u => u.Id == id && u.Location == location);
        }

        public DrugLocation Get(int id)
        {
            throw new NotImplementedException();
        }

        public DrugLocation Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}
