using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev2
{
	public class KelimeAgaci
	{
		string kelime;//sözcük anlamı string
		KelimeAgaci [] siniflar = new KelimeAgaci[26];//26 referans tutacağı, bu sınıfın nesnelerini refere etmek için

		public void KelimeEkle(string verilen,string deger)
		{
		    int i = 0, k, gösterici;
            KelimeAgaci [] baslangic = new KelimeAgaci[26];

            k = verilen.Length;
            baslangic = siniflar;
			while(k-- > 0)
			{
				gösterici = verilen[i++]-'a';
                if (siniflar[gösterici] == null)
				{
					KelimeAgaci yeni= new KelimeAgaci();
                    siniflar[gösterici] = yeni;				
					if (k == 0)
                        siniflar[gösterici].kelime = deger;
                    siniflar = siniflar[gösterici].siniflar;
				}
				else
				{	
					if(k == 0)
					{
                        if (siniflar[gösterici].kelime == null)
                            siniflar[gösterici].kelime = deger;		
						else
                            siniflar[gösterici].kelime += ";" + deger;
                        
					}
                    siniflar = siniflar[gösterici].siniflar;
				}
			}
            siniflar = baslangic;
		}
        public void KelimeSil(string verilen)
        {
            int k, gösterici, i = 0;
            KelimeAgaci[] baslangic = new KelimeAgaci[26];
            
            k = verilen.Length;
            baslangic = siniflar;
            while (k-- > 0)
            {
                gösterici = verilen[i++] - 'a';
                if (k == 0)
                    siniflar[gösterici].kelime = null;
                else
                    siniflar = siniflar[gösterici].siniflar;
            }
            siniflar = baslangic;
        }
        public string AnlamBul(string verilen)
        {
            int k, gösterici, i = 0;
            string gecici;
            KelimeAgaci[] baslangic = new KelimeAgaci[26];

            k = verilen.Length;
            baslangic = siniflar;
            while (k-- > 0)
            {
                gösterici = verilen[i++] - 'a';
                if (siniflar[gösterici] == null)
                {
                    siniflar = baslangic;
                    return "[kelime bulunamadi]";
                }
                if (k == 0)
                {
                    if (siniflar[gösterici].kelime == null)
                    {
                        siniflar = baslangic;
                        return "[bu kelime daha onceden silinmis]";
                    }
                    else
                    {
                        gecici = siniflar[gösterici].kelime;
                        siniflar = baslangic;
                        return gecici;
                    }
                }
                siniflar = siniflar[gösterici].siniflar;
            }
            siniflar = baslangic;
            return "[kelime bulunamadi]";
        }

		static void Main()
			{
				KelimeAgaci sozluk = new KelimeAgaci();
                sozluk.KelimeEkle("legal", "yasal");
                sozluk.KelimeEkle("leg", "bacak");
                sozluk.KelimeEkle("a", "bir");
                sozluk.KelimeEkle("legend", "efsane");
                sozluk.KelimeEkle("leg", "dik kenar");
                
                Console.WriteLine("leg : {0}", sozluk.AnlamBul("leg"));
                Console.WriteLine("bell : {0}", sozluk.AnlamBul("bell"));
                Console.WriteLine("a : {0}", sozluk.AnlamBul("a"));
                Console.WriteLine("legend : {0}", sozluk.AnlamBul("legend"));
                Console.WriteLine("legal : {0}", sozluk.AnlamBul("legal"));
                sozluk.KelimeSil("legal");
                Console.WriteLine("legal : {0}", sozluk.AnlamBul("legal"));
				
                Console.ReadLine();
			}

		
	}
	
}
