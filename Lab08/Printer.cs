using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Printer
    {
       
            public string Name;
            public string Appointment;
            public string Printing_technology;
            public int Buyers;
            public double YearIncome;
            public double Square;
            public bool HasPhotoprinting;
            public bool HasTwo_sided_printing;
            public double GetYearIncomePerInhabitant()
            {
                return YearIncome / Buyers;
            }
        
    }
}
