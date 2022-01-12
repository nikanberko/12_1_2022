using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class StandardEvaluator:ITicketValidator
    {
        List<string> shows = new List<string>();

        public void Add(string show) { this.shows.Add(show); }


        public bool IsValid(Ticket ticket)
        {
           if(shows.Contains(ticket.ShowName) && ticket.StartsAt < DateTime.Now)
            {
                return true;

            }
            return false;
        }

        public decimal CalculateTotalProfit(List<Ticket> tickets)
        {
            decimal totalProfit = 0;
        
            foreach(Ticket ticket in tickets)
            {
                if (shows.Contains(ticket.ShowName)&& ticket.StartsAt>=DateTime.Now)
                {
                    totalProfit += ticket.Price;
                }
            }
            return totalProfit;


        }


    }
}
