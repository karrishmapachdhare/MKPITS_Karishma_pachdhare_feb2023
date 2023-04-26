using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumexp
{
    //enum declaration
    enum days
    {
        //enum data members
        monday,
        tuesday,
        wednesday,
        friday,
        saturday,
        sunday
    }
    //enum declaration
    enum color
    {
        //enum data members
        red,
        yellow,
        blue,
       //assigning value yellow(1)+5
       green=yellow+5,
       brown,
       //assigning value green(6)+3
       black=green+3,


    }
     class Program
    {
        //main method
        static void Main(string[] args)
        {
            Console.WriteLine("demostrating the diffrence"+ "between special initialisation"+ "cases and non-initialisation cases\n\n");

            // first of all non-initialized enum
            // 'days' will be displayed
            // as mentioned already, the first
            // member is initialized to 0
            // hence the output will numbers
            // from 0 1 2 3 4 5 6 );

            Console.WriteLine("value of monday is"+(int)days.monday);
            Console.WriteLine("value of tuesday is" + (int)days.tuesday);
            Console.WriteLine("value of wendesday is"+(int)days.wednesday);
            Console.WriteLine("value of thursday is"+(int)days.thursday);
            Console.WriteLine("value of friday is"+(int)days.friday);
            Console.WriteLine("value of saturday is"+(int)days.saturday);   
            Console.WriteLine("value of sunday is"+(int)days.sunday)
        }
    }
}
