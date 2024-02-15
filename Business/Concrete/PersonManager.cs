using Business.Abstract;
using Business.Adapters.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        private IPersonCheckService _personCheckService;

        public PersonManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return _personCheckService.CheckIfRealPerson(person);
        }
    }
}
