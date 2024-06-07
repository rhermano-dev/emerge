using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using ASI.Basecode.Data.Repositories;
using ASI.Basecode.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.Services
{
    public class PersonService : IPersonService
    {
        public IPersonRepository _personRepository;
        public IMapper _mapper;

        public PersonService(IPersonRepository personRepository,
            IMapper mapper) {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public List<PersonModel> GetPersonList()
        {
            return _personRepository.GetPersonList().ToList();
        }

        public void AddPersonData(PersonModel person)
        {
            person.Id = Guid.NewGuid().ToString();

            _personRepository.AddPersonData(person);
        }

        public PersonModel GetPersonById(string id) 
        {
            return GetPersonList().Where(x => x.Id == id).FirstOrDefault();
        }

        public void EditPersonData(PersonModel person)
        {
            PersonModel personFromDatabase = GetPersonById(person.Id);

            _mapper.Map(person, personFromDatabase);

            personFromDatabase.Name = person.Name;
            personFromDatabase.Address = person.Address;

            _personRepository.EditPersonData(personFromDatabase);
        }

        public void DeletePersonData(string id)
        {
            PersonModel personFromDatabase = GetPersonById(id);

            _personRepository.DeletePersonData(personFromDatabase);
        }
    }
}
