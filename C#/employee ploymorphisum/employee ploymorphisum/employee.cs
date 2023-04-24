using employee_ploymorphisum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_ploymorphisum
{
    internal class employee
    {
        public int sal;
        public virtual int calsalary(int bonus)
        {

            return bonus;
        }

    }
}
     internal class sale : employee
{
    public int bonus = 500;
    public override int calsalary(int sal)
    {
        sal = bonus + sal;
        return sal;
    }
}







 internal class ENGG : employee
{
    public int bonus = 800;
    public override int calsalary(int sal)
    {
        sal = bonus + sal;
        return sal;
    }
}






 
 internal class manager : employee
{
    public int bonus = 1000;
    public override int calsalary(int sal)
    {
        sal = bonus + sal;
        return sal;
    }
}









    


