using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDatabaseGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace TestDatabaseGenerator.Generators
{
    public class PartsMasterGenerator
    {
        ArmsSpectrumDevelopmentContext _context;

        public PartsMasterGenerator(ArmsSpectrumDevelopmentContext context)
        {
            _context = context;
        }

        public void Generate()
        {

            _context.Database.ExecuteSqlRaw("delete from [maint].parts_master");

            Random random = new Random(0);

            for (int i = 0; i < 100; i++)
            {
                PartsMaster partsMaster = new PartsMaster();

                partsMaster.PkTransactId = i + 1;
                partsMaster.Allotment = (short) (random.NextInt64() % 99 + 1);
                partsMaster.AveragePrice = (random.NextInt64() % 999 + 1);
                partsMaster.AvgReprLeadTm = (random.NextInt64() % 40 + 1);
                _context.PartsMasters.Add(partsMaster);
            }

            _context.SaveChanges();

        }
        

        
    }
}
