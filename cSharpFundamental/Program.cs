using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpFundamental
{
    class Program
    {

        static void Main(string[] args)
        {
            BangunRuang bangunRuang;
            mulai:
            Console.WriteLine("======================================================");
            Console.WriteLine("Selamat datang di menu Perhitunagn Luas Bangun Datar: ");
            Console.WriteLine("======================================================");
            Console.WriteLine("Silahkan pilih menu Jenis Bangun");
            Console.WriteLine("1 untuk persegi panjang");
            Console.WriteLine("2 untuk segitiga");
            Console.WriteLine("3 untuk persegi");
            Console.Write("4 untuk lingkaran \n silahkan masukan inputan : ");
            string input = Console.ReadLine();
            Console.WriteLine("anda memasukan : " + input + "\n\n");
            int a = 0;
            if (int.TryParse(input, out a))
            {
                switch (Int16.Parse(input))
                {
                    case 1:
                        Console.WriteLine("++++++ Persegi Panjang ++++++");
                        bangunRuang = new PersegiPanjang(3,5);
                        bangunRuang.print("Persegi Panjang");
                        break;

                    case 2:
                        Console.WriteLine("++++++ Segitiga ++++++");
                        bangunRuang = new SegiTiga(3,4);
                        bangunRuang.print("Segitiga");
                        break;

                    case 3:
                        Console.WriteLine("++++++ persegi ++++++");
                        bangunRuang = new Persegi(4);
                        bangunRuang.print("Persegi");
                        break;

                    case 4:
                        Console.WriteLine("++++++ lingkaran ++++++");
                        bangunRuang = new Lingkaran(7);
                        bangunRuang.print("Lingkaran");
                        break;

                    default:
                        Console.WriteLine(" --- anda tidak memasukan input dengan benar ---");
                        break;

                }
            }
            else
            {
                Console.WriteLine("anda tidak memasukan input dengan benar");
            }
            Console.WriteLine("\n\n\n");
            Console.ReadLine();
            Console.Clear();
            goto mulai;

        }
    }

    abstract class BangunRuang
    {
        public abstract double hitung();

        public void print(string namaBangun)
        {
            Console.WriteLine("Luas Bangun " + namaBangun + " : " +hitung());
        }

    }

    class Persegi : BangunRuang
    {
        private int sisi;
        public Persegi(int sisi)
        {
            this.sisi = sisi;
        }

        public override double hitung()
        {
            return sisi * sisi;
        }

        public void print(string namaBangun, string jenisBangun)
        {
            Console.WriteLine("Jenis Bangun : " + jenisBangun);
            Console.WriteLine("Luas Bangun " + namaBangun + " : " + hitung());
        }
    }

    class PersegiPanjang : BangunRuang
    {
        private int p,l;
        public PersegiPanjang(int p,int l)
        {
            this.p = p;
            this.l = l;
        }

        public override double hitung()
        {
            return p * l;
        }
    }

    class SegiTiga : BangunRuang
    {
        private int a, t;
        public SegiTiga(int a, int t)
        {
            this.a = a;
            this.t = t;
        }

        public override double hitung()
        {
            return (a * t) / 2;
        }
    }

    class Lingkaran : BangunRuang
    {
        private int r;
        public Lingkaran(int r)
        {
            this.r = r;
        }

        public override double hitung()
        {
            return (3.14 * r * r);
        }
    }

}