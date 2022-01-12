using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class Ticket
    {
        public Ticket(decimal price, string showName, DateTime startsAt)
        {
            Price = price;
            ShowName = showName;
            StartsAt = startsAt;
        }

        public decimal Price { get; set; }
        public string ShowName { get; set; }
        public DateTime StartsAt { get; set; }


    }
}
