using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieEticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Data
{
    public class EticketDbInitializer
    {

      
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicesScop = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicesScop.ServiceProvider.GetService<EticketDbContext>();
                context.Database.EnsureCreated();
             //   Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://cdn.pixabay.com/photo/2017/11/24/10/43/ticket-2974645__480.jpg",
                            Description = "This Is the Description Of the Cinema"

                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://cdn.pixabay.com/photo/2019/11/07/20/48/cinema-4609877__340.jpg",
                            Description = "This Is the Description Of the Cinema2"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://cdn.pixabay.com/photo/2015/01/11/09/19/film-596009__340.jpg",
                            Description = "This Is the Description Of the Cinema3"

                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://cdn.pixabay.com/photo/2013/07/12/13/16/movie-146704__340.png",
                            Description = "This Is the Description Of the Cinema4"
                        }
                    });
                    context.SaveChanges();
                }

            //    Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                      FullName = "Manoj Baj",
                      Bio ="This Actor Form Bihar",
                      ProfilePictureURL="https://www.filmibeat.com/img/162x203/popcorn/profile_photos/manoj-bajpayee-20180615132814-375.jpg"
                        },
                         new Actor()
                        {
                      FullName = "Nawajudin",
                      Bio ="This Actor Is Very Good Acting Skill",
                      ProfilePictureURL="https://www.filmibeat.com/fanimg/214x100x267/fan_images/nawazuddin-siddiqui-photos-images-33443.jpg"
                        },
                          new Actor()
                        {
                      FullName = "Pankaj Tripathi",
                      Bio ="This Actor is also Form Bihar and great personallity",
                      ProfilePictureURL="https://www.filmibeat.com/img/162x203/popcorn/profile_photos/pankaj-tripathi-20170915110603-38909.jpg"
                        },
                           new Actor()
                        {
                      FullName = "Rajkumar Rao",
                      Bio ="He is the young actor and his Acting Skill is very Good",
                      ProfilePictureURL="https://www.filmibeat.com/img/162x203/popcorn/profile_photos/raj-kumar-yadav-22757.jpg"
                        }
                });
                    context.SaveChanges();
                }
             //   Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                      new Producer()
                      {
                          FullName="Karan Joher",
                          Bio="This is the Bio of first Producer",
                          ProfilePictureURL="https://www.filmibeat.com/img/162x203/popcorn/profile_photos/karan-johar-20190919100534-9.jpg"
                      },
                      new Producer()
                      {
                          FullName="David Dhawan",
                          Bio="This is the Bio of Second Producer",
                          ProfilePictureURL="https://www.filmibeat.com/img/162x203/popcorn/profile_photos/david-dhawan-1657.jpg"
                      },
                      new Producer()
                      {
                          FullName="Anurag Kashyab",
                          Bio="This is the Bio of Third Producer",
                          ProfilePictureURL="https://www.filmibeat.com/img/162x203/popcorn/profile_photos/anurag-kashyap-850.jpg"
                      }

                });
                    context.SaveChanges();
                }
             //   movies
                if (!context.Moviess.Any())
                {
                    context.Moviess.AddRange(new List<Movies>()
                    {
                        new Movies()
                        {
                            Name="Gangs Of Wassepur",
                            Description="This Movie Is Amazing",
                            Price = 420,
                            ImageURL="https://upload.wikimedia.org/wikipedia/en/6/6a/Gangs_of_Wasseypur_poster.jpg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-2),
                            CinemaId =1,
                            ProducerId=5,
                            MovieCategory=MovieCategory.Action
                        },
                         new Movies()
                        {
                            Name="Gangs Of Wassepur2",
                            Description="After success of part First then decided to relese this part",
                            Price = 800,
                            ImageURL="https://upload.wikimedia.org/wikipedia/en/5/58/Gangs_of_wasseypur_II.jpg",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId =1,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Action
                        },
                          new Movies()
                        {
                            Name="Stree",
                            Description="Horror And Comedy based Movie",
                            Price = 1099,
                            ImageURL="https://upload.wikimedia.org/wikipedia/en/4/4f/Stree_-_2018_Movie_Poster.jpg",
                            StartDate=DateTime.Now.AddDays(-20),
                            EndDate=DateTime.Now.AddDays(-9),
                            CinemaId =1,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Comedy
                        },
                         new Movies()
                        {
                            Name="The Mountain Man",
                            Description="In the 1960s Dashrath Manjhi (Nawazuddin Siddiqui) lived in a small village Gehlaur near Gaya," +
                            " Bihar, India with his family including his wife Phaguniya Devi",
                            Price = 630,
                            ImageURL="https://upload.wikimedia.org/wikipedia/en/4/4f/Manjhi_The_Mountain_Man_-_Poster.jpg",
                            StartDate=DateTime.Now.AddDays(-15),
                            EndDate=DateTime.Now.AddDays(-7),
                            CinemaId =1,
                            ProducerId=6,
                            MovieCategory=MovieCategory.Documentary
                        }
                     });
                    context.SaveChanges();
                }
             //   Actors & Movies
                if (!context.Actors_Moives.Any())
                {
                    context.Actors_Moives.AddRange(new List<Actor_Movie>()
                    {
                     new Actor_Movie(){
                         MoviesssId=6,
                         ActorsssId=1
                         
                     },
                     new Actor_Movie(){
                          MoviesssId=6,
                         ActorsssId=1
                        
                     },
                     new Actor_Movie(){
                         MoviesssId=7,
                         ActorsssId=2
                         
                     }

                    });
                    context.SaveChanges();
                }


            }
        }
    }
}
