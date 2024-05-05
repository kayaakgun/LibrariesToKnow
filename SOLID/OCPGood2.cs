using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Good2
{
    public class LowSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }

    public class ManagerSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 7;
        }
    }

    public class SalaryCalculator
    {
        // Action => void
        //Predicate => bool
        // Function 
        public decimal Calculate(decimal salary, Func<decimal,decimal> calculateDelege)
        {
            return calculateDelege(salary);
        }
    }

}
