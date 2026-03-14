using System.Collections.Generic;

namespace TP_MODUL4_103022400044
{
    public class KodePos
    {
        private Dictionary<string, string> kodePosTable = new Dictionary<string, string>()
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" }
        };

        public string getKodePos(string kelurahan)
        {
            if (kodePosTable.ContainsKey(kelurahan))
            {
                return kodePosTable[kelurahan];
            }

            return "Kode pos tidak ditemukan";
        }
    }
}