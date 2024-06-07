using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using Basecode.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Repositories
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {

        private readonly AsiBasecodeDBContext asiBasecodeDBContext;

        public PersonRepository(IUnitOfWork unitOfWork, AsiBasecodeDBContext asiBasecodeDBContext): 
            base(unitOfWork)
        {
            this.asiBasecodeDBContext = asiBasecodeDBContext;
        }

        public IQueryable<PersonModel> GetPersonList()
        {
            return this.GetDbSet<PersonModel>();
        }

        public void AddPersonData(PersonModel person)
        {
            asiBasecodeDBContext.Person.Add(person);
            asiBasecodeDBContext.SaveChanges();
        }

        public void EditPersonData(PersonModel person)
        {
            asiBasecodeDBContext.Person.Update(person);
            asiBasecodeDBContext.SaveChanges();
        }

        public void DeletePersonData(PersonModel person)
        {
            asiBasecodeDBContext.Person.Remove(person);

            asiBasecodeDBContext.SaveChanges();
        }
    }
}
