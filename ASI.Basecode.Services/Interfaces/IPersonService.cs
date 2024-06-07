using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.Interfaces
{
    public interface IPersonService
    {
        // List
        public List<PersonModel> GetPersonList();

        // Create
        public void AddPersonData(PersonModel person);

        // Search by Id
        public PersonModel GetPersonById(string id);

        // Edit
        public void EditPersonData(PersonModel person);

        // Delete
        public void DeletePersonData(string id);
    }
}
