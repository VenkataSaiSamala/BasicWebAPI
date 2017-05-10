using KUDWebTokensNew;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace KUDWebTokens.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<AngEmployee> Get()
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                return entites.AngEmployees.ToList();
            }
        }
    }
}
