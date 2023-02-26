using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wexy.Models
{
    public interface IAdministratorRepository
    {
        void Add(AdministratorModel admin);
        void Update(AdministratorModel admin);
        void Delete(int id);
        IEnumerable<AdministratorModel> GetAll();
        IEnumerable<AdministratorModel> GetByValue();

    }
}
