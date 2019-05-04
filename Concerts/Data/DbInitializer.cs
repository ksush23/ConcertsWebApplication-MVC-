using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Concerts.Models;

namespace Concerts.Data
{
    public class DbInitializer
    {
        public static void Initialize(ConcertsContext context)
        {
            context.Database.EnsureCreated();

            // Look for any artists.
            if (!context.Artists.Any())
            {
                var artists = new Artist[]
            {
            new Artist{Artist_Name = "Imagine Dragons", Artist_Genre = "Indi rock"},
            new Artist{Artist_Name = "Hurts", Artist_Genre = "Pop"},
            new Artist{Artist_Name = "Sting", Artist_Genre = "Rock"},
            new Artist{Artist_Name = "Христина Соловій", Artist_Genre = "Народна музика"},
            new Artist{Artist_Name = "30 seconds to Mars", Artist_Genre = "Rock"},
            new Artist{Artist_Name = "Depeche Mode", Artist_Genre = "Rock"},
            new Artist{Artist_Name = "Three Days Grace", Artist_Genre = "Rock"},
            new Artist{Artist_Name = "Kazka", Artist_Genre = "Pop"},
            new Artist{Artist_Name = "ONUKA", Artist_Genre = "Pop"},
            new Artist{Artist_Name = "Сергій Бабкін", Artist_Genre = "Pop"},
            new Artist{Artist_Name = "ЛСП", Artist_Genre = "Rap"},
            new Artist{Artist_Name = "Олег Винник", Artist_Genre = "Pop"},
            new Artist{Artist_Name = "Oxxymiron", Artist_Genre = "Rap"}
            };
                foreach (Artist a in artists)
                {
                    context.Artists.Add(a);
                }
                context.SaveChanges();
            }


            if (!context.Concerts.Any())
            {
                var concerts = new Concert[]
            {
            new Concert{Concert_TimeData = DateTime.Parse("2018-09-01"), ConcertArtistId = 1, ConcertPlaceId = 2},
            new Concert{Concert_TimeData = DateTime.Parse("2018-10-02"), ConcertArtistId = 2, ConcertPlaceId = 2},
            new Concert{Concert_TimeData = DateTime.Parse("2019-01-23"), ConcertArtistId = 2, ConcertPlaceId = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2019-03-04"), ConcertArtistId = 3, ConcertPlaceId = 4},
            new Concert{Concert_TimeData = DateTime.Parse("2018-09-08"), ConcertArtistId = 4, ConcertPlaceId = 5},
            new Concert{Concert_TimeData = DateTime.Parse("2019-05-06"), ConcertArtistId = 4, ConcertPlaceId = 5},
            new Concert{Concert_TimeData = DateTime.Parse("2017-04-22"), ConcertArtistId = 4, ConcertPlaceId = 6},
            new Concert{Concert_TimeData = DateTime.Parse("2019-07-25"), ConcertArtistId = 5, ConcertPlaceId = 4},
            new Concert{Concert_TimeData = DateTime.Parse("2019-09-09"), ConcertArtistId = 6, ConcertPlaceId = 1},
            new Concert{Concert_TimeData = DateTime.Parse("2018-06-13"), ConcertArtistId = 7, ConcertPlaceId = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2019-07-27"), ConcertArtistId = 9, ConcertPlaceId = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2017-08-08"), ConcertArtistId = 9, ConcertPlaceId = 9},
            new Concert{Concert_TimeData = DateTime.Parse("2019-07-05"), ConcertArtistId = 10, ConcertPlaceId = 10},
            new Concert{Concert_TimeData = DateTime.Parse("2019-03-03"), ConcertArtistId = 10, ConcertPlaceId = 11},
            new Concert{Concert_TimeData = DateTime.Parse("2018-11-14"), ConcertArtistId = 10, ConcertPlaceId = 12},
            new Concert{Concert_TimeData = DateTime.Parse("2019-12-14"), ConcertArtistId = 11, ConcertPlaceId = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2019-02-18"), ConcertArtistId = 12, ConcertPlaceId = 4},
            new Concert{Concert_TimeData = DateTime.Parse("2017-04-15"), ConcertArtistId = 13, ConcertPlaceId = 1},
            new Concert{Concert_TimeData = DateTime.Parse("2018-06-19"), ConcertArtistId = 13, ConcertPlaceId = 2}
            };
                foreach (Concert c in concerts)
                {
                    context.Concerts.Add(c);
                }
                context.SaveChanges();
            }

            if (!context.Places.Any())
            {

                var places = new Place[]
            {
            new Place{Place_Name = "НСК Олімпійський", Place_Address = "Київ"},
            new Place{Place_Name = "Велотрек СКА", Place_Address = "Львів"},
            new Place{Place_Name = "StereoPlaza", Place_Address = "Київ"},
            new Place{Place_Name = "Палац Спорту", Place_Address = "Київ"},
            new Place{Place_Name = "Жовтневий Палац", Place_Address = "Київ"},
            new Place{Place_Name = "Національний Академічний театр опери і балету", Place_Address = "Одеса"},
            new Place{Place_Name = "Bel etage", Place_Address = "Київ"},
            new Place{Place_Name = "Театр ім. Ольги Кобилянської", Place_Address = "Чернівці"},
            new Place{Place_Name = "Музкомедія", Place_Address = "Одеса"},
            new Place{Place_Name = "Одеська обласна філармонія", Place_Address = "Одеса"},
            new Place{Place_Name = "Чернівецька філармонія", Place_Address = "Чернівці"},
            new Place{Place_Name = "Палац Україна", Place_Address = "Київ"}
            };
                foreach (Place p in places)
                {
                    context.Places.Add(p);
                }
                context.SaveChanges();
            }

            if (!context.Seats.Any())
            {
                var seats = new Seat[]
            {
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 1},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 2},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 3},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 4},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 5},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 6},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 7},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 8},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 9},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 10},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 11},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, SeatSectorId = 12}
            };
                foreach (Seat s in seats)
                {
                    context.Seats.Add(s);
                }
                context.SaveChanges();
            }

            if (!context.Sectors.Any())
            {

                var sectors = new Sector[]
            {
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 1},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 2},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 3},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 4},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 5},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 6},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 7},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 8},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 9},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 10},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 11},
            new Sector{Sector_Name = "Сектор 1", SectorPlaceId = 12}
            };
                foreach (Sector s in sectors)
                {
                    context.Sectors.Add(s);
                }
                context.SaveChanges();
            }

            if (!context.TicketStates.Any())
            {

                var ticket_states = new TicketState[]
            {
            new TicketState{TicketState_Name = "Вільно"},
            new TicketState{TicketState_Name = "Заброньовано"},
            new TicketState{TicketState_Name = "Куплено"}
            };
                foreach (TicketState ts in ticket_states)
                {
                    context.TicketStates.Add(ts);
                }
                context.SaveChanges();
            }

            if (!context.Tickets.Any())
            {

                var tickets = new Ticket[]
            {
            new Ticket{TicketStateId = 1, ConcertId = 1, SeatId = 1, Ticket_Price = 1200},
            new Ticket{TicketStateId = 1, ConcertId = 2, SeatId = 2, Ticket_Price = 1500},
            new Ticket{TicketStateId = 1, ConcertId = 3, SeatId = 3, Ticket_Price = 1400},
            new Ticket{TicketStateId = 1, ConcertId = 4, SeatId = 4, Ticket_Price = 900},
            new Ticket{TicketStateId = 1, ConcertId = 5, SeatId = 5, Ticket_Price = 850},
            new Ticket{TicketStateId = 1, ConcertId = 6, SeatId = 6, Ticket_Price = 1700},
            new Ticket{TicketStateId = 1, ConcertId = 7, SeatId = 7, Ticket_Price = 1300},
            new Ticket{TicketStateId = 1, ConcertId = 8, SeatId = 8, Ticket_Price = 1200},
            new Ticket{TicketStateId = 1, ConcertId = 9, SeatId = 9, Ticket_Price = 1250},
            new Ticket{TicketStateId = 1, ConcertId = 10, SeatId = 10, Ticket_Price = 1560},
            new Ticket{TicketStateId = 1, ConcertId = 11, SeatId = 1, Ticket_Price = 2300},
            new Ticket{TicketStateId = 1, ConcertId = 12, SeatId = 6, Ticket_Price = 2000},
            new Ticket{TicketStateId = 1, ConcertId = 13, SeatId = 2, Ticket_Price = 550},
            new Ticket{TicketStateId = 1, ConcertId = 14, SeatId = 7, Ticket_Price = 3100},
            new Ticket{TicketStateId = 1, ConcertId = 15, SeatId = 3, Ticket_Price = 1950},
            new Ticket{TicketStateId = 1, ConcertId = 16, SeatId = 4, Ticket_Price = 1000},
            new Ticket{TicketStateId = 1, ConcertId = 17, SeatId = 10, Ticket_Price = 2400},
            new Ticket{TicketStateId = 1, ConcertId = 18, SeatId = 5, Ticket_Price = 2300}
            };
                foreach (Ticket t in tickets)
                {
                    context.Tickets.Add(t);
                }
                context.SaveChanges();
            }
        }
    }
}
