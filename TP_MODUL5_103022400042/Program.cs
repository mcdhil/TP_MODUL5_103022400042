using System;

namespace TP_MODUL5_103022400042
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input menggunakan NIM 
            String nim = "130220XXXX"; // Ganti dengan NIM kamu
            DataGeneric<String> dataNIM = new DataGeneric<String>(nim);
            dataNIM.PrintData();
        }
    }
}