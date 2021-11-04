using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Client.Services
{
    public class ServiceActors:IServiceActor
    {
        public List<Actor> GetActors(){
            return new List<Actor>(){
                    new Actor(){Name="actor One",Biography="Description actor One",Photo="/images/actors/1.jpg", BirtDate = new DateTime(2021,09,24)},
                    new Actor(){Name="actor Two",Biography="Description actor Two",Photo="/images/actors/1.jpg", BirtDate = new DateTime(2021,09,24)},
                    new Actor(){Name="actor Trhee",Biography="Description actor Trhee",Photo="/images/actors/1.jpg", BirtDate = new DateTime(2021,09,24)},
                    new Actor(){Name="actor Four",Biography="Description actor Four",Photo="/images/actors/1.jpg", BirtDate = new DateTime(2021,09,24)},
            };
        }
    }
}