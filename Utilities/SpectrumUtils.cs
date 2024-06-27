using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class SpectrumUtils
    {
        public static string AtaChapter(short? chapCode)
        {
            if (chapCode == null)
            {
                return null;
            }

            return (chapCode.Value % 100).ToString("00");
        }

        public static string AtaSubChapter(short? subChapAndPara)
        {
            if (subChapAndPara == null)
            {
                return null;
            }

            return ((int)((subChapAndPara.Value % 10000) / 100)).ToString("00");
        }

        public static string AtaParagraph(short? subChapAndPara)
        {
            if (subChapAndPara == null)
            {
                return null;
            }

            return (subChapAndPara.Value % 100).ToString("00");
        }

        static Random random = new Random();

        public static string RandomDate(DateTime frstDate, DateTime lastDate)
        {
            double nextDbl = random.NextDouble();

            var diff = ((lastDate - frstDate).TotalSeconds) * nextDbl;

            DateTime randDate = frstDate.AddSeconds(diff);

            return randDate.ToString("yyyy-MM-dd");
        }

        public static byte[] GenerateSessionId()
        {
            string guid = System.Guid.NewGuid().ToString();

            byte[] sessionId = Encoding.ASCII.GetBytes(guid);

            return sessionId;
        }
    }
}
