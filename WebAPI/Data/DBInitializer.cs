using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.EntityFramework.Context;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DBInitializer
    {

        public void Initialize(ApplicationDbContext context)
        {
            if (context.Gps.Any())
            {
                return;
            }
            Console.WriteLine("HE?!");
            Randomizer.Seed = new Random(42);

            var testGps = new Faker<Gps>()
                .RuleFor(gps => gps.Coordinates, f => $"{f.Random.Number(1, 100)}:{f.Random.Number(1, 100)}")
                .FinishWith((f, gps) =>
                {
                    Console.WriteLine("Coordinates Created! Id={0} and Coordinate Coordinates={1}", gps.Id, gps.Coordinates);
                }); ;

            var data = testGps.Generate(200);

            context.AddRange(data);
            context.SaveChanges();
        }

        public void Initialize_HardCoded(ApplicationDbContext context)
        {
            if (context.Gps.Any())
            {
                return;   // DB has been seeded
            }

            var Gpss = new Gps[]
            {
                new Gps { Coordinates ="25:10"},
                new Gps { Coordinates ="10:22"},
                new Gps { Coordinates ="110:156"},
            };

            context.AddRange(Gpss);
            context.SaveChanges();
        }
    }
}
