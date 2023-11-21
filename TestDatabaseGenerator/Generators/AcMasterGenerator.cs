using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDatabaseGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace TestDatabaseGenerator.Generators
{
    public class AcMasterGenerator
    {
        ArmsSpectrumDevelopmentContext _context;

        public AcMasterGenerator(ArmsSpectrumDevelopmentContext context)
        {
            _context = context;
        }

        public void Generate()
        {

            _context.Database.ExecuteSqlRaw("delete from [maint].ac_master");

            Random random = new Random(0);

            for (int i = 0; i < 10; i++)
            {
                AcMaster acMaster = new AcMaster();

                acMaster.PkTransactId = i + 1;
                acMaster.TailNmbr = "TN" + i.ToString("00");
                acMaster.SerialNmbr = "SN" + (random.NextInt64() % 1000000000000).ToString("000000000000");
                acMaster.Description = "Test AC " + i.ToString("00");
                acMaster.DateAcquired = new DateTime(2021, (int)(random.NextInt64() % 12) + 1, (int)(random.NextInt64() % 28) + 1);
                acMaster.DateDispDuDef = new DateTime(2021, (int)(random.NextInt64() % 12) + 1, (int)(random.NextInt64() % 28) + 1);
                acMaster.DaysInService = (int)(random.NextInt64() % 365) + 1;
                acMaster.DaysInService = (int)(random.NextInt64() % 365) + 1;
                acMaster.DaysOutOfSvc = (int)(random.NextInt64() % 365) + 1;
                acMaster.StatusState = "In Service";
                acMaster.MaintBase = "FLL";
                acMaster.AircraftType = "A310";
                acMaster.AcIdnt = "AC" + ((int)(random.NextInt64() % 1000) + 1).ToString("0000");
                acMaster.Date = DateTime.Now;
                acMaster.Hours = (float)((random.NextInt64() % 2000) + 1);
                acMaster.CheckForRemvl = "NO";
                acMaster.Cycles = (int)((random.NextInt64() % 200) + 1);
                acMaster.Weeks = (short)((random.NextInt64() % (52 * 2)) + 1);
                acMaster.FrstClassSeats = 16;
                acMaster.BusClassSeats = 32;
                acMaster.CoachSeats = 128;
                acMaster.FltFollName = "AC" + ((int)(random.NextInt64() % 1000)).ToString("000");
                acMaster.IncRelRpts = "YES";

            _context.AcMasters.Add(acMaster);
            }

            _context.SaveChanges();

        }



    }
}
