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

            // Look for any students.
            if (context.Artists.Any())
            {
                return;   // DB has been seeded
            }

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

            var concerts = new Concert[]
            {
            new Concert{Concert_TimeData = DateTime.Parse("2018-09-01"), Concert_Artist_ID = 1, Concert_Place_ID = 2},
            new Concert{Concert_TimeData = DateTime.Parse("2018-10-02"), Concert_Artist_ID = 2, Concert_Place_ID = 2},
            new Concert{Concert_TimeData = DateTime.Parse("2019-01-23"), Concert_Artist_ID = 2, Concert_Place_ID = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2019-03-04"), Concert_Artist_ID = 3, Concert_Place_ID = 4},
            new Concert{Concert_TimeData = DateTime.Parse("2018-09-08"), Concert_Artist_ID = 4, Concert_Place_ID = 5},
            new Concert{Concert_TimeData = DateTime.Parse("2019-05-06"), Concert_Artist_ID = 4, Concert_Place_ID = 5},
            new Concert{Concert_TimeData = DateTime.Parse("2017-04-22"), Concert_Artist_ID = 4, Concert_Place_ID = 6},
            new Concert{Concert_TimeData = DateTime.Parse("2019-07-25"), Concert_Artist_ID = 5, Concert_Place_ID = 4},
            new Concert{Concert_TimeData = DateTime.Parse("2019-09-09"), Concert_Artist_ID = 6, Concert_Place_ID = 1},
            new Concert{Concert_TimeData = DateTime.Parse("2018-06-13"), Concert_Artist_ID = 7, Concert_Place_ID = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2019-07-27"), Concert_Artist_ID = 9, Concert_Place_ID = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2017-08-08"), Concert_Artist_ID = 9, Concert_Place_ID = 9},
            new Concert{Concert_TimeData = DateTime.Parse("2019-07-05"), Concert_Artist_ID = 10, Concert_Place_ID = 10},
            new Concert{Concert_TimeData = DateTime.Parse("2019-03-03"), Concert_Artist_ID = 10, Concert_Place_ID = 11},
            new Concert{Concert_TimeData = DateTime.Parse("2018-11-14"), Concert_Artist_ID = 10, Concert_Place_ID = 12},
            new Concert{Concert_TimeData = DateTime.Parse("2019-12-14"), Concert_Artist_ID = 11, Concert_Place_ID = 3},
            new Concert{Concert_TimeData = DateTime.Parse("2019-02-18"), Concert_Artist_ID = 12, Concert_Place_ID = 4},
            new Concert{Concert_TimeData = DateTime.Parse("2017-04-15"), Concert_Artist_ID = 13, Concert_Place_ID = 1},
            new Concert{Concert_TimeData = DateTime.Parse("2018-06-19"), Concert_Artist_ID = 13, Concert_Place_ID = 2}
            };
            foreach (Concert c in concerts)
            {
                context.Concerts.Add(c);
            }
            context.SaveChanges();

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

            var seats = new Seat[]
            {
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 1},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 2},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 3},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 4},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 5},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 6},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 7},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 8},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 9},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 10},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 11},
            new Seat{Seat_Number = 1, Seat_Line_number = 1, Seat_Sector_ID = 12}
            };
            foreach (Seat s in seats)
            {
                context.Seats.Add(s);
            }
            context.SaveChanges();

            var sectors = new Sector[]
            {
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 1},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 2},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 3},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 4},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 5},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 6},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 7},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 8},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 9},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 10},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 11},
            new Sector{Sector_Name = "Сектор 1", Sector_Place_ID = 12}
            };
            foreach (Sector s in sectors)
            {
                context.Sectors.Add(s);
            }
            context.SaveChanges();

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

            var tickets = new Ticket[]
            {
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 1, Ticket_Seat_ID = 1, Ticket_Price = 1200},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 2, Ticket_Seat_ID = 2, Ticket_Price = 1500},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 3, Ticket_Seat_ID = 3, Ticket_Price = 1400},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 4, Ticket_Seat_ID = 4, Ticket_Price = 900},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 5, Ticket_Seat_ID = 5, Ticket_Price = 850},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 6, Ticket_Seat_ID = 6, Ticket_Price = 1700},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 7, Ticket_Seat_ID = 7, Ticket_Price = 1300},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 8, Ticket_Seat_ID = 8, Ticket_Price = 1200},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 9, Ticket_Seat_ID = 9, Ticket_Price = 1250},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 10, Ticket_Seat_ID = 10, Ticket_Price = 1560},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 11, Ticket_Seat_ID = 1, Ticket_Price = 2300},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 12, Ticket_Seat_ID = 6, Ticket_Price = 2000},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 13, Ticket_Seat_ID = 2, Ticket_Price = 550},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 14, Ticket_Seat_ID = 7, Ticket_Price = 3100},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 15, Ticket_Seat_ID = 3, Ticket_Price = 1950},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 16, Ticket_Seat_ID = 4, Ticket_Price = 1000},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 17, Ticket_Seat_ID = 10, Ticket_Price = 2400},
            new Ticket{Ticket_State_ID = 1, Ticket_Concert_ID = 18, Ticket_Seat_ID = 5, Ticket_Price = 2300}
            };
            foreach (Ticket t in tickets)
            {
                context.Tickets.Add(t);
            }
            context.SaveChanges();
        }
    }
}
