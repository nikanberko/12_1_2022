using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    interface ITicketValidator
    {
        public bool IsValid(Ticket ticket);

        public decimal CalculateTotalProfit(List<Ticket> ticets);
               

    }
}
