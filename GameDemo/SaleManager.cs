using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class SaleManager
    {
        public void Sell(GamerManager gamer, GameManager game)
        {
            Console.WriteLine(game.OyunAdi + " " + "Oyun kütüphanenize eklendi" + " " + gamer.Ad + " " + gamer.Soyad);
        }


    }
}
