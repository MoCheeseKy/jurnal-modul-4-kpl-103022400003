using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400003
{
    internal class KodePaket
    {
        public static string getKodePaket(string namaPaket)
        {
            string[] namaPaketList = {
                "Basic", "Standard", "Premium", "Unlimited",
                "Gaming", "Streaming", "Family", "Business",
                "Student", "Traveler"
            };

            string[] kodePaketTable = {
                "P201", "P202", "P203", "P204",
                "P205", "P206", "P207", "P208",
                "P209", "P210"
            };

            for (int i = 0; i < namaPaketList.Length; i++)
            {
                if (namaPaketList[i] == namaPaket)
                    return kodePaketTable[i];
            }

            return "Paket tidak ditemukan";
        }
    }
}