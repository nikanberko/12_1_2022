using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class TicketTracker
    {
        ITicketValidator validator;

        List<Ticket> tickets;


        public TicketTracker( ITicketValidator someValidator)
        {
            validator = someValidator;
            tickets = new List<Ticket>();
        }

        public List<Ticket> GetValidTickets()
        {
            List<Ticket> validTickets = new List<Ticket>();

            foreach(Ticket ticket in tickets)
            {
                if (validator.IsValid(ticket))
                {
                    validTickets.Add(ticket);
                }
            }
            return validTickets;
        }


        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }



    }
}
