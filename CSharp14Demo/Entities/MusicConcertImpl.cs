using System;

namespace CSharp14Demo.Entities
{
    // Partial implementation: provides the event accessors and the partial method implementation.
    public partial class MusicConcert
    {
        // Backing delegate used by the add/remove implementation.
        private EventHandler<TicketEventArgs>? _ticketSoldHandlers;

        // Implement the partial event with custom add/remove logic (C# 14 partial event feature).
        public partial event EventHandler<TicketEventArgs> TicketSold
        {
            add
            {
                _ticketSoldHandlers += value;
                Console.WriteLine($"[MusicConcert] Handler added for '{ConcertName}'. Total handlers: {(_ticketSoldHandlers?.GetInvocationList().Length ?? 0)}");
            }
            remove
            {
                _ticketSoldHandlers -= value;
                Console.WriteLine($"[MusicConcert] Handler removed for '{ConcertName}'. Remaining handlers: {(_ticketSoldHandlers?.GetInvocationList().Length ?? 0)}");
            }
        }

        // Partial method implementation called when a ticket is sold.
        partial void OnTicketSold(TicketEventArgs e)
        {
            // Optionally add extra logic (logging, filtering) before invoking handlers
            Console.WriteLine($"[MusicConcert] Raising TicketSold for '{ConcertName}' -> {e.TicketsSold} total.");
            _ticketSoldHandlers?.Invoke(this, e);
        }
    }
}