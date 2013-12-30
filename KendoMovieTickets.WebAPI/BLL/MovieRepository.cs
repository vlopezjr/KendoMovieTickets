using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KendoMovieTickets.WebAPI.BLL.BusinessObjects;

namespace KendoMovieTickets.WebAPI.BLL
{
    public class MovieRepository
    {
        public static List<MovieBO> moviesMasterList;

        public static List<MovieBO> GetMoviesMasterList()
        {
            if (moviesMasterList == null
                || moviesMasterList.Count == 0)
            {
                CreateMoviesMasterList();
            }
            return moviesMasterList;
        }

        private static void CreateMoviesMasterList()
        {
            moviesMasterList = new List<MovieBO>()
            {
                new MovieBO(){
                    MovieId = 1,
                    Name = "The Great Gatsby (2013)",
                    Genre = "Drama",
                    Image = "http://images.kendomobilebook.com/movies/greatgatsby.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Leonardo DiCaprio, Amitabh Bachchan",
                    Length = "143",                    
                    Rating = "PG-13"
                },
                new MovieBO(){
                    MovieId = 2,
                    Name= "Iron man 3",
                    Genre= "Sci-Fi",
                    Image = "http://images.kendomobilebook.com/movies/ironman3.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Robert Downey Jr., Gwyneth Paltrow",
                    Length = "130",                    
                    Rating = "PG-13"
                }
            };
        }

        public static UserBO GetUserDetails(string userName)
        {
            var usersList = new List<UserBO>
            {
                new UserBO() {
                    Address = "123 North Field Pkwy, Buffalo Grove, Illinois",
                    EmailId = "alison.massey@email.com",
                    FirstName = "Alison",
                    LastName = "Massey",
                    UserName = "username1",
                    SubscribedForNewsLetter = true,
                    BookingHistory = new List<TicketBO>{
                        new TicketBO() {
                            TicketId = new Random().Next(10000),
                            TheaterName = "AMC, South Barrington, IL",
                            MovieName = "The Call",
                            Screen = "12",
                            NoOfPersons = 5,
                            ShowDate = "15-Aug-2013",
                            ShowTime = "4:30 PM"
                        },
                        new TicketBO() {
                            TicketId = new Random().Next(10000),
                            TheaterName = "Regal, Lincolnshire, IL",
                            MovieName = "Argo",
                            Screen = "7",
                            NoOfPersons = 2,
                            ShowDate = "25-Aug-2013",
                            ShowTime = "7:00 PM"
                        }
                    }
                },
            new UserBO() {
                    Address = "20627 Mauve Orchild Way, Dallas, TX",
                    EmailId = "patrick.dcoster@email.com",
                    FirstName = "Patrick",
                    LastName = "DCoster",
                    UserName = "username2",
                    SubscribedForNewsLetter = false,
                    BookingHistory = new List<TicketBO>{
                        new TicketBO() {
                            TicketId = new Random().Next(10000),
                            TheaterName = "AMC Northpark, Northpark, Dallas, TX",
                            MovieName = "Evil Dead",
                            Screen = "19",
                            NoOfPersons = 9,
                            ShowDate = "13-July-2013",
                            ShowTime = "4:30 PM"
                        },
                        new TicketBO() {
                            TicketId = new Random().Next(10000),
                            TheaterName = "Amstar 14, Dallas, TX",
                            MovieName = "The Host",
                            Screen = "21",
                            NoOfPersons = 1,
                            ShowDate = "21-Sept-2013",
                            ShowTime = "5:00 PM"
                        }
                    }
                }
            };

            return usersList.FirstOrDefault(x => x.UserName.Equals(userName));
        }
    }
}