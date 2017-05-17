using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAtRest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new FigaroDataManager();
            dm.InsertRecordFromUrl("http://bdbxml.net/sitemap.xml");
            dm.Dispose();
        }
    }
}
