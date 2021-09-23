using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.ViewModels
{
    public class SerialVM
    {
        public int? SerialId { get; set; }

        public List<Serial> Serials { get; set; }

        public List<Serial> AllSerials { get; set; }

        public List<Film> Films { get; set; }

        public List<Actor> Actors { get; set; }

        public List<Actor> FindActors { get; set; }

        public Actor GetActorID { get; set; }

        public List<SerialToCategory> SameCategorySerial { get; set; }

        public List<SerialSerie> serialSeries { get; set; }

        public List<Serial> GetserialIsFeatured { get; set; }

        public Serial Serial { get; set; }

        public List<HomeSlider> HomeSliders { get; set; }

        public List<SerialToActor> SerialToActors { get; set; }

        public List< SerialToCategory> serialToCategories { get; set; }

        public SerialSerie Serie { get; set; }

        public List<Film> AllFilms { get; set; }

       public SerialSeason SerialSeason { get; set; }
        
    }
}
