using System.Runtime.InteropServices;

namespace HomeWork_Burclar;

class Program
{
    static void Main(string[] args)
    {
        #region Burç HomeWork

                Console.Write("Doğum gününüz: ");
                int gun = int.Parse(Console.ReadLine());

                Console.Write("Doğum ayınız: ");

                string burc = "";
                string ay = Console.ReadLine().ToLower(); //Konsoldan alınan input, lower case'e çevrilir.
                Console.Write($"{ay}"); //String interpolation
            
                if ((ay == "ocak" && gun >= 22) || (ay == "şubat" && gun <= 19))
                burc = "Kova";
                else if ((ay == "şubat" && gun >= 20) || (ay == "mart" && gun <= 20))
                burc = "Balık";
                else if ((ay == "mart" && gun >= 21) || (ay == "nisan" && gun <= 20))
                burc = "Koç";
                else if ((ay == "nisan" && gun >= 21) || (ay == "mayıs" && gun <= 21))
                burc = "Boğa";
                else if ((ay == "mayıs" && gun >= 22) || (ay == "haziran" && gun <= 22))
                burc = "İkizler";
                else if ((ay == "haziran" && gun >= 23) || (ay == "temmuz" && gun <= 22))
                burc = "Yengeç";
                else if ((ay == "temmuz" && gun >= 23) || (ay == "ağustos" && gun <= 22))
                burc = "Aslan";
                else if ((ay == "ağustos" && gun >= 23) || (ay == "eylül" && gun <= 22))
                burc = "Başak";
                else if ((ay == "eylül" && gun >= 23) || (ay == "ekim" && gun <= 22))
                burc = "Terazi";
                else if ((ay == "ekim" && gun >= 23) || (ay == "kasım" && gun <= 21))
                burc = "Akrep";
                else if ((ay == "kasım" && gun >= 22) || (ay == "aralık" && gun <= 21))
                burc = "Yay";
                else if ((ay == "aralık" && gun >= 22) || (ay == "ocak" && gun <= 21))
                burc = "Oğlak";
                else
                burc = "Geçersiz tarih";
                Console.WriteLine($"Burcunuz: {burc} burcudur.");
        #endregion

        
    }
}
