using System;
using System.IO;
namespace Odev1
{
    public class Okuma
    {

        public static string oku(string dosyaadresi)
        {
            string arguman = "";
            StreamReader sr = new StreamReader(dosyaadresi);// streamreader sinifi nesnesi
            arguman = sr.ReadToEnd();// streamreader sınıfı içindeki readtoend fonksiyonunu çağırdık
            sr.Close();
            return arguman;
        }
    }
    public class Stack
    {
        private string[] dizi;
        private int indis = 0;
        private int boyu;
        private string arguman;

        public Stack(int boyu)
        {
            dizi = new string[boyu];
        }
        public bool isempty()
        {
            if (dizi[0] == null)
                return true;
            return false;
        }


        public int push(string arguman)
        {
            if (indis == boyu - 1)
            {//dizimizin uzunluğu eğer ilk aldığımız boya eşit ise dizi doludur demektir.
                return -1;
            }
            dizi[indis++] = arguman;
            return 0;
        }



        public string peek()
        {
            if (dizi[0] == null)
                return null;
            return dizi[indis - 1];
        }
        public string pop()
        {
            if (dizi[0] == null)
                return null;
            string gecici = dizi[indis - 1];
            dizi[--indis] = null;
            return gecici;
        }

    }


    public class Sınıf
    {
        public static void yazdir(string str)
        {
            int k;
            int i = 0;
            int eh = 0;
            int eb = 0;
            int eu = 0;
            while (true)
            {
                if (str[i] == '<' && str[i + 1] != '/')
                {
                    if (str[i + 1] == 'h')
                        eh = 1;
                    else if (str[i + 1] == 'b')
                        eb = 1;
                    else if (str[i + 1] == 'u')
                        eu = 1;
                    else if (str[i + 1] == 'p')
                        if (eh == 0)
                        {
                            if (eb == 1)
                            {
                                for (k = 0; k < 2; k++)
                                    Console.Write("[");
                            }
                            else
                                Console.Write("[");
                        }
                    i = i + 3;
                }
                else if (str[i] == '<' && str[i + 1] == '/')
                {
                    if (str[i + 2] == 'h')
                        eh = 0;
                    else if (str[i + 2] == 'b')
                        eb = 0;
                    else if (str[i + 2] == 'u')
                        eu = 0;
                    else if (str[i + 2] == 'p')
                        if (eh == 0)
                        {
                            if (eb == 1)
                            {
                                for (k = 0; k < 2; k++)
                                    Console.Write("]");
                            }
                            else
                                Console.Write("]");

                        }
                    i = i + 4;
                }
                else
                {
                    if (eh == 0)
                    {
                        if (eb == 1)
                        {
                            if (eu == 1)
                            {
                                for (k = 0; k < 2; k++)
                                    Console.Write(char.ToString(str[i]));
                            }
                            else
                            {
                                for (k = 0; k < 2; k++)
                                    Console.Write(char.ToString(str[i]));
                            }
                        }
                        else if (eu == 1)
                            Console.Write(char.ToUpper(str[i]));
                        else
                            Console.Write(str[i]);
                    }
                    i++;
                }
                if (i == str.Length)
                    break;
            }
        }
                
        
        public static int kontrol(string str, Stack yeni) {
            int i = 0;
            while (true)
            {
                if (str[i] == '<' && str[i + 1] != '/')
                {
                    if (str[i + 2] != '>')
                        return 0;
                    else
                        yeni.push(char.ToString(str[i+1]));
                    i = i + 3;
                }
                else if (str[i] == '<' && str[i + 1] == '/')
                {
                    if (str[i + 3] != '>')
                        return 0;
                    else
                    {
                        if (yeni.peek() != char.ToString(str[i + 2]))
                            return 0;
                        else
                            yeni.pop();
                    }
                    i = i + 4;
                }
                else
                    i++;
                if (i == (str.Length))
                {
                    if (yeni.isempty())
                        return 1;
                    else
                        return 0;
                        

                }
            }
                
        }
        static void Main()
        {
            string str = "";
			int k;
            Stack stk = new Stack(100);
            str = Okuma.oku("C:/kaynak.txt");
            k = kontrol(str, stk);
            if (k == 0)
            {
                Console.WriteLine("Kaynak dosyanin bicimleme etiketleri hatalidir, kontrol ediniz.");
            }
            else
                yazdir(str);
            Console.ReadLine();
        }//End main

    }//End sınıf

}//End uzay