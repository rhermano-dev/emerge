using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface IPersonRepository
    {
        public IQueryable<PersonModel> GetPersonList();

        public void AddPersonData(PersonModel person);

        public void EditPersonData(PersonModel person);

        public void DeletePersonData(PersonModel person);
    }
}
