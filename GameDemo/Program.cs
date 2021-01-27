using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamer1 = new GamerManager();
            GamerManager gamer2 = new GamerManager();
            GamerManager gamer3 = new GamerManager();

            gamer1.Id = 10;
            gamer1.Ad = "Ahmet";
            gamer1.Soyad = "Yılmaz";
            gamer1.DogumYili = "1996";
            gamer1.TcNo = "111222333";

            gamer2.Id = 11;
            gamer2.Ad = "Mustafa";
            gamer2.Soyad = "Türkmen";
            gamer2.DogumYili = "1993";
            gamer2.TcNo = "444222333";

            gamer3.Id = 12;
            gamer3.Ad = "Selim";
            gamer3.Soyad = "Yüksel";
            gamer3.DogumYili = "1997";
            gamer3.TcNo = "555222111";

            Registry kayıt = new Registry();

            kayıt.Kayıt(gamer1);
            kayıt.Kayıt(gamer2);
            kayıt.Kayıt(gamer3);

            GameManager game1 = new GameManager();
            GameManager game2 = new GameManager();
            GameManager game3 = new GameManager();

            game1.OyunAdi = "Doom";
            game1.OyunFiyati = 67;
            game1.IndirimliFiyat = 23;
            game1.IndirimliFiyat2 = 31;

            game2.OyunAdi = "Witcher 3 Wild Hunt";
            game2.OyunFiyati = 52;
            game2.IndirimliFiyat = 18;
            game2.IndirimliFiyat2 = 24;

            game3.OyunAdi = "Half Life";
            game3.OyunFiyati = 18;
            game3.IndirimliFiyat = 3;
            game3.IndirimliFiyat2 = 9;

            SaleManager saleManager = new SaleManager();
            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(game2);
            campaignManager.Add(game1);
            campaignManager.Update(game3);
                                  
            saleManager.Sell(gamer1, game2);           
            saleManager.Sell(gamer2, game1);
            saleManager.Sell(gamer3, game3);

            campaignManager.Delete(game2);
            campaignManager.Delete(game1);
            campaignManager.Delete(game3);
        }
    }
}
