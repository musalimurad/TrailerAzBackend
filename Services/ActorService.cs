
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ActorService
    {
        private readonly TvContext _context;

        public ActorService(TvContext context)
        {
            _context = context;
        }

        public List<Actor> GetActors()
        {
            return _context.actors.Take(1).ToList();
        }
        public List<Actor> AllActor(int skipcount)
        {
            return _context.actors.Skip(skipcount).ToList();
        }

        public Actor GetActorByID(int id)
        {
            return _context.actors.FirstOrDefault(x => x.ID == id);
        }

        public List<SerialToActor> serialToActors(int id)
        {
            var selectedActor = GetActorByID(id);
            var byActorSerial = _context.serialToActors.Where(x => x.ActorID==id ).Select(x => x.SerialID);
            var ActorToSerial = _context.serialToActors.Include(x => x.Serial).Where(x => byActorSerial.Contains(x.SerialID))
                .ToList();

            return ActorToSerial;
        }

        public List<Actor> GetActorsIsFetaured()
        {
            return _context.actors.Where(x => x.IsFeatured == true).ToList();
        }

        public List<FilmToActor> GetFilmToActors(int id)
        {
            return _context.filmToActors.Include(x => x.Film).Where(x => x.ActorID == id).ToList();
        }

        public List<FilmToActor> FilmIsLeadRole()
        {
            return _context.filmToActors.Include(x => x.Film).Where(x => x.IsLeadRole == true).ToList();
        }
       
    }
}
