using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace movie_ticket
{
    abstract class Movie_ticket
    {
        public string Movie_Name { get; set; }
        public string Theatre_Name { get; set; }
        public string Show_Time { get; set; }
        public int Number_of_Seats { get; set; }

        public float Ticket_Price { get; set; }
        //method to calculate ticket price

        public abstract string Calculate_Ticket_price();


       }
    class Online_Booking : Movie_ticket
    {
        public float discount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_Seats * Ticket_Price + discount;

            return "Total Price : " + tp.ToString();

        }

    }

    class BoxOffice : Movie_Ticket
    {
        public float Booking_Amount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_Seats * Ticket_Price + Booking_Amount;

            return "Total Price : " + tp.ToString();

        }

    }

}
          

      