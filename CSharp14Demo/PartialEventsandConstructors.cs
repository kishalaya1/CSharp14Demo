using System;
using CSharp14Demo.Entities;

namespace CSharp14Demo
{
    public class PartialEventsandConstructors
    {
        // Demonstrates calling MovieService using both available constructors and partial events via MusicConcert.
        public static void Demo()
        {
            PartialContructorDemo();
            PartialEventsDemo();
        }

        private static void PartialContructorDemo()
        {
            Console.WriteLine("=== Partial Constructors Demo start===");

            // 1) Default constructor (partial constructor demo exists in MovieService files)
            var hitOldMovie = new MovieService("Batman :The Dark Knight");
            Console.WriteLine("Created MovieService using default constructor.");
            hitOldMovie.MovieDetails();
            Console.WriteLine("Created MovieService using partial constructor with name Batman :The Dark Knight.");

            Console.WriteLine("=== Partial Constructors Demo end===");
        }

        private static void PartialEventsDemo()
        {
            // 2) Partial events demo using MusicConcert
            Console.WriteLine("=== Partial Events Demo start===");

            var concert = new MusicConcert("Queen's 1985 Live Aid Concert");

            // Create two handlers
            EventHandler<TicketEventArgs> handler1 = (s, e) =>
                Console.WriteLine($"[Handler1] Notified: {e}");

            EventHandler<TicketEventArgs> handler2 = (s, e) =>
                Console.WriteLine($"[Handler2] Notified: {e}");

            // Subscribe handlers (add accessor implemented in MusicConcertImpl)
            concert.TicketSold += handler1;
            concert.TicketSold += handler2;

            // Sell tickets (this calls partial method which raises the event)
            Console.WriteLine("Selling 1 ticket...");
            concert.SellTicket();

            Console.WriteLine("Selling 8 tickets...");
            concert.SellTicket(8);

            // Unsubscribe one handler
            concert.TicketSold -= handler1;

            Console.WriteLine("Selling 1 ticket after removing handler1...");
            concert.SellTicket();

            Console.WriteLine("=== Partial Events Demo end===");
        }
    }
}
