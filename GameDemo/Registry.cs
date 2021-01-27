using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Registry
    {
        public void Kayıt(GamerManager gamer)
        {
            Console.WriteLine("Oyuncu kayıtı başarılı" + " " + gamer.Id + " " + gamer.Ad + " " + gamer.Soyad + " " + gamer.DogumYili + " " + gamer.TcNo);
        }
    }
}
