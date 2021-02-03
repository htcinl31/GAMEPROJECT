using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEPROJECT

{
    
    class SalesManager : ISalesService
    {

       
        public void Sales(Games game,Gamer gamer,Campaign campaign)
        {
            // burda indirimliTutar değişkenine oyun ücretinden eklediğimiz kampanya tutarını çıkarıp atadık.Değeri 70 tl oldu.
            int indirimliTutar = game.GamePrice - campaign.CampaignAmount;
            Console.WriteLine(gamer.FirstName + " " +"isimli oyuncu"+ " "+ game.GameName + " " +" oyununu" + " "+ campaign.CampaignName +" " +" kampanyası ile" +" "+indirimliTutar + " "+"TL'den aldı");
        }
    } 
}
