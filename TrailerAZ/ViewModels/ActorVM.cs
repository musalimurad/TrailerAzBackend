using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.ViewModels
{
    public class ActorVM
    {
        public List<Actor> Actors { get; set; }

        public Actor GetActor { get; set; }

        public List<SerialToActor> SerialToActors { get; set; }

        public Serial Serial { get; set; }

        public List<Serial> GetserialIsFeatured { get; set; }

        public List<SerialToCategory> SameCategorySerial { get; set; }

        public List<Actor> ActorIsFeatured { get; set; }

        public List<FilmToActor> filmToActors { get; set; }

        public List<FilmToActor> FilmIsLeadRole { get; set; }

        public List<Actor> AllActor { get; set; }
    }
}
