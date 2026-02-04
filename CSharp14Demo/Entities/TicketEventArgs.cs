using System;

namespace CSharp14Demo.Entities
{
    public sealed class TicketEventArgs : EventArgs
    {
        public string ConcertName { get; }
        public int TicketsSold { get; }

        public TicketEventArgs(string concertName, int ticketsSold)
        {
            ConcertName = concertName;
            TicketsSold = ticketsSold;
        }

        public override string ToString() => $"Concert='{ConcertName}', TicketsSold={TicketsSold}";
    }
}