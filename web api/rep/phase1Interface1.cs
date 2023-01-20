using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.rep
{
    public interface phase1Interface1
    {
        List<phase1Model> GetAllDetails();

        string insert(phase1 em);

        string Update(phase1 em);

        string Delete(int Sl_No);
    }
}
