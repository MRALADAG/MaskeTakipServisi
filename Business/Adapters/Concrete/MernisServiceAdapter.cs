using Business.Adapters.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Concrete
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return kPSPublicSoapClient.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        person.NationalIdentity, person.FirstName.ToUpper(new CultureInfo("tr-TR", false)), person.LastName.ToUpper(new CultureInfo("tr-TR", false)), person.DateOfBirthYear
                        )
                    )
                ).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
