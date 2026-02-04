using System;

namespace CSharp14Demo.Entities
{
    // Partial declaration: event is declared here, but its add/remove is implemented in another part.
    public partial class MusicConcert
    {
        public string ConcertName { get; }
        public int TicketsSold { get; private set; }

        public MusicConcert(string name)
        {
            ConcertName = name;
            TicketsSold = 0;
        }

        // Partial event declaration (no accessors here)
        public partial event EventHandler<TicketEventArgs> TicketSold;

        // Public method that triggers the partial method which raises the event.
        public void SellTicket(int count = 1)
        {
            TicketsSold += count;
            OnTicketSold(new TicketEventArgs(ConcertName, TicketsSold));
        }

        // Partial method implemented in the other file — used to invoke the backing handlers.
        partial void OnTicketSold(TicketEventArgs e);
    }
}