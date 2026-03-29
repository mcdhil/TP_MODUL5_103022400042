using System;

namespace TP_MODUL5_103022400042
{
    class Program
    {
        static void Main(string[] args)
        {

            HaloGeneric sapaan = new HaloGeneric();
            String nama = "Fadhil";
            sapaan.SapaUser(nama);

          
            String nim = "13022400042";
            DataGeneric<String> dataNIM = new DataGeneric<String>(nim);
            dataNIM.PrintData();
        }
    }
}