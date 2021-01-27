using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager
    {
        public void Add(GameManager game)
        {
            Console.WriteLine("Yeni kampanya başladı!" + " " + game.OyunAdi + " " + game.IndirimliFiyat);
        }

        public void Delete(GameManager game)
        {
            Console.WriteLine("Kampanya sona erdi" + " " + game.OyunAdi + " " + game.OyunFiyati);
        }

        public void Update(GameManager game)
        {
            Console.WriteLine("Kampanya güncellendi"+ " " + game.OyunAdi + " " + game.IndirimliFiyat2);
        }
    }
}
