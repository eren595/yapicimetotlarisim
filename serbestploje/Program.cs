using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace serbestploje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ploglam başladı");
            kisi k = new kisi();
            Console.WriteLine("ismi:{0},yas:{1}", k.Ad, k.Yas);
        }
    }
    class kisi
    {
        int yas;
        string ad;
        public kisi()
        {
            yas = 19;
            ad = "ahmet";
            Console.WriteLine("yapıcı metod çalıştı");
            Console.WriteLine("Program bitti.");
        }
        public int Yas
        {
            get 
            {
                return yas; 
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }
        }

    }

