using MfpeDrugsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfpeDrugsApi.Repository
{
    public class DrugRepository : IRepository<Drug>
    {

        public List<Drug> items = new List<Drug>();
        public DrugRepository()
        {
          Add ( new Drug { Id = 1, Name = "Disprin", ManufactureDate = Convert.ToDateTime("2020-5-6 12:12:00.0000000"), ExpiryDate = Convert.ToDateTime("2021-5-6 12:12:00.0000000"), ManufacturerName = "Abbot"});
          Add(  new Drug { Id = 2, Name = "Paracetamol", ManufactureDate = Convert.ToDateTime("2019-10-2 12:12:00.0000000"), ExpiryDate = Convert.ToDateTime("2023-9-2 12:12:00.0000000"), ManufacturerName = "Intas" });

        }

        public void Add(Drug item)
        {
            items.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Drug Get(int id)
        {
           return items.Find(p => p.Id == id);
        }
        public Drug Get(string name)
        {
            return items.Find(p => p.Name == name);
        }

       /* public IEnumerable<Drug> GetAll(string name)
        {
          //  throw new NotImplementedException();
           yield return items.Find(p => p.Name == name);
        }*/
        public void Update(Drug item)
        {
            throw new NotImplementedException();
        }
    }
}
