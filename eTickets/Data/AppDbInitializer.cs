using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>(); // connect db & app
                context.Database.EnsureCreated(); // check database was created

                // Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema1",
                            Logo = "https://img.freepik.com/premium-vector/cinema-movie-background-popcorn-filmstrip-clapboard-tickets-movie-time-background_41737-248.jpg",
                            Description = "This description for cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema1",
                            Logo = "https://img.freepik.com/premium-vector/cinema-movie-background-popcorn-filmstrip-clapboard-tickets-movie-time-background_41737-248.jpg",
                            Description = "This description for cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema2",
                            Logo = "https://img.freepik.com/premium-vector/cinema-movie-background-popcorn-filmstrip-clapboard-tickets-movie-time-background_41737-248.jpg",
                            Description = "This description for cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema3",
                            Logo = "https://img.freepik.com/premium-vector/cinema-movie-background-popcorn-filmstrip-clapboard-tickets-movie-time-background_41737-248.jpg",
                            Description = "This description for cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema4",
                            Logo = "https://img.freepik.com/premium-vector/cinema-movie-background-popcorn-filmstrip-clapboard-tickets-movie-time-background_41737-248.jpg",
                            Description = "This description for cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema5",
                            Logo = "https://m.media-amazon.com/images/I/51vqw2Lj45L._AC_.jpg",
                            Description = "This description for cinema"
                        }
                    });
                    context.SaveChanges();
                };
                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor1",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://static-koimoi.akamaized.net/wp-content/new-galleries/2020/12/jim-parsons-as-sheldon-cooper-in-the-big-bang-theory-1.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor2",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://static-koimoi.akamaized.net/wp-content/new-galleries/2020/12/jim-parsons-as-sheldon-cooper-in-the-big-bang-theory-1.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor3",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://static-koimoi.akamaized.net/wp-content/new-galleries/2020/12/jim-parsons-as-sheldon-cooper-in-the-big-bang-theory-1.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor4",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://static-koimoi.akamaized.net/wp-content/new-galleries/2020/12/jim-parsons-as-sheldon-cooper-in-the-big-bang-theory-1.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor5",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://static-koimoi.akamaized.net/wp-content/new-galleries/2020/12/jim-parsons-as-sheldon-cooper-in-the-big-bang-theory-1.jpg"
                        }

                    });
                    context.SaveChanges();

                };
                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer1",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://i.pinimg.com/474x/eb/c3/d2/ebc3d25b4e0aee35e72c02ad47b88f5f.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer2",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://i.pinimg.com/474x/eb/c3/d2/ebc3d25b4e0aee35e72c02ad47b88f5f.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer3",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://i.pinimg.com/474x/eb/c3/d2/ebc3d25b4e0aee35e72c02ad47b88f5f.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer4",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://i.pinimg.com/474x/eb/c3/d2/ebc3d25b4e0aee35e72c02ad47b88f5f.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer5",
                            Bio = "This is the Bio of an actor.",
                            ProfilePictureURL = "https://i.pinimg.com/474x/eb/c3/d2/ebc3d25b4e0aee35e72c02ad47b88f5f.jpg"
                        }

                    });
                    context.SaveChanges();

                }
                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie1",
                            Description = "This is the movie description.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51vqw2Lj45L._AC_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie2",
                            Description = "This is the movie description.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51vqw2Lj45L._AC_.jpg",
                            StartDate = DateTime.Now.AddDays(-20),
                            EndDate = DateTime.Now.AddDays(-9),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie3",
                            Description = "This is the movie description.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51vqw2Lj45L._AC_.jpg",
                            StartDate = DateTime.Now.AddDays(-16),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie4",
                            Description = "This is the movie description.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51vqw2Lj45L._AC_.jpg",
                            StartDate = DateTime.Now.AddDays(-42),
                            EndDate = DateTime.Now.AddDays(-34),
                            CinemaId = 2,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Movie5",
                            Description = "This is the movie description.",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51vqw2Lj45L._AC_.jpg",
                            StartDate = DateTime.Now.AddDays(-18),
                            EndDate = DateTime.Now.AddDays(-7),
                            CinemaId = 4,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();

                }
                // Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        }

                    });
                    context.SaveChanges();
                        

                }
            }
        }
    }
}
