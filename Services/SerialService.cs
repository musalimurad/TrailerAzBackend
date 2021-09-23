using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class SerialService
    {
        private readonly TvContext _context;

        public SerialService(TvContext context)
        {
            _context = context;
        }

        public List<Serial> GetSerials()
        {
            return _context.serials.Take(3).ToList();
        }
        public List<Serial> AllSerials(int skipCount)
        {
            return _context.serials.Skip(skipCount).ToList();
        }

        public List<Serial> GetSerialIsFeatured()
        {
            return _context.serials.Where(x => x.IsFeatured).ToList();
        }

        public List<SerialSerie> GetSerialSeria(int? id,int? seasonId)
        {
            return _context.serialSeries.Where(x => x.SerialID == id && x.SerialSeasonID == seasonId).Include(x=>x.Serial).ToList();
        }


        public Serial Serial()
        {
            return _context.serials.Include(x => x.SerialSeasons).OrderByDescending(x => x.ID).FirstOrDefault(x => x.IsNew);
        }

        public Serial GetSerialByID(int id)
        {
            return _context.serials.Include("SerialSeasons.SerialSeries").FirstOrDefault(x => x.ID == id);
        }
        //public static IEnumerable<TSource> DistinctBy<TSource, TKey>
        //(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //    {
        //        HashSet<TKey> seenKeys = new HashSet<TKey>();
        //        foreach (TSource element in source)
        //        {
        //            if (seenKeys.Add(keySelector(element)))
        //            {
        //                yield return element;
        //            }
        //        }
        //    }
        public List<SerialToCategory> SameCategorySerial(int id)
        {
            List<SerialToCategory> mySerialList = new();
            var bySerial = GetSerialByID(id);
            var bySerialCategory = _context.serialToCategories.Where(x => x.SerialID == id).Select(x=>x.CategoryID).ToList();
            var sameSerial = _context.serialToCategories.Where(x => bySerialCategory.Contains(x.CategoryID) && x.SerialID != id).Include(x => x.Serial)
                //.GroupBy(x=>x.SerialID)
                //.Select(x=>x.First())
                .Take(8)
                .ToList();

            foreach (var serialCategory in sameSerial)
            {
                if (!mySerialList.Any(x => x.SerialID == serialCategory.SerialID || mySerialList.Count == 0))
                {
                    mySerialList.Add(serialCategory);
                }
            }
            return mySerialList;
        }

       

        public List<Serial> GetSerialsFeatured(int id)
        {
            return _context.serials.Where(x => x.IsFeatured == true && x.ID!=id).ToList();
        }

        public List<SerialToCategory> GetSerialToCategories(int id)
        {
            var GetSerialCategory = _context.serialToCategories.Where(x => x.SerialID == id).Select(x => x.CategoryID).ToList();
            var SerialCategory = _context.serialToCategories.Where(x => GetSerialCategory.Contains(x.CategoryID)).Include(x => x.Category).ToList();
            return SerialCategory;
        }

        public SerialSerie GetSeriaByID(int? seriaID)
        {
            var GetSerialSerie = _context.serialSeries.FirstOrDefault(x => x.SerialID == seriaID);
            return GetSerialSerie;
        }




    }
}
