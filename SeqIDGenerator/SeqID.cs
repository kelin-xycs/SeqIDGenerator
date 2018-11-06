using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace SeqIDGenerator
{
    public class SeqID
    {

        private static string machineID;

        private static DateTime d2;

        private static int no = 0;

        private static object lockObj = new object();

        static SeqID()
        {
            machineID = ConfigurationManager.AppSettings["SeqIDGenerator.MachineID"];

            if (string.IsNullOrEmpty(machineID))
            {
                throw new SeqIDGeneratorException("缺少配置 \"SeqIDGenerator.MachineID\" 。");
            }
        }

        public static string New()
        {
            lock(lockObj)
            {
                DateTime d = DateTime.Now;

                if (d.Millisecond != d2.Millisecond
                    || d.Second != d2.Second
                    || d.Minute != d2.Minute
                    || d.Hour != d2.Hour
                    || d.Day != d2.Day
                    || d.Month != d2.Month
                    || d.Year != d2.Year)
                {
                    d2 = d;
                    no = 0;
                }

                return d.ToString("yyyyMMddHHmmssfff" + "-" + machineID + "-" + (no++).ToString("0000"));
            }
        }
    }
}
