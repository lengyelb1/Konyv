using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    class book
    {
        private int isbnSzam;
        
        private string szerzo_k;
        private string muCime;
        private int kiadasEv;
        private string nyelv;
        private bool enciklopedia;
        private char eBook; // i/n

        public book() { }

        public book(int isbnSzam, string szerzo_k, string muCime, int kiadasEv, string nyelv, bool enciklopedia, char eBook)
        {
            this.IsbnSzam = isbnSzam;
            this.Szerzo_k = szerzo_k;
            this.MuCime = muCime;
            this.KiadasEv = kiadasEv;
            this.Nyelv = nyelv;
            this.Enciklopedia = enciklopedia;
            
        }

        public int IsbnSzam { get { return isbnSzam; }
            set 
            { 
                if (true)
                {
                    string be = value.ToString();
                    int i = 1;
                    int ertek = 0;

                    foreach (var item in be)
                    {
                        ertek += item* i;
                        i++;
                    }
                    isbnSzam =  int.Parse(value.ToString() + (ertek%11));
                }
                else
                {
                    throw new Osztaly_Konyv.BookExeption(Program.sorokSzama, value);
                }
            } }
        public string Szerzo_k { get { return szerzo_k; } set { szerzo_k = value; } }
        public string MuCime { get { return muCime; } set { muCime = value; } }
        public int KiadasEv { get { return kiadasEv; } set { kiadasEv = value; } }
        public string Nyelv { get { return nyelv; } set { nyelv = value; } }
        public bool Enciklopedia { get { return enciklopedia; } set { enciklopedia = value; } }
        public char EBook { get { return eBook; } set { eBook = value; } }
        public override string ToString()
        {
            return $"ISNB: {this.isbnSzam} Szerző: {this.szerzo_k} Cím: {this.muCime} Kiadás éve: {this.kiadasEv} Nyelv: {this.nyelv} Enciklopédia: {this.enciklopedia} Ebook: {this.eBook}";
        }
        ~book(){
            Console.WriteLine("Destruktor törölte a book -ot");
        }
    }

    public class BookExeption:Exception
    {
        private int hibaSzam;
        private int hibasKonyvIsbn;

        public BookExeption(int hibaSzam, int hibasKonyvIsbn)
        {
            this.hibaSzam = hibaSzam;
            this.hibasKonyvIsbn = hibasKonyvIsbn;
        }

        public int HibaSzam { get { return hibaSzam; } set { hibaSzam = value; } }
        public int HibasKonyvIsnb { get { return hibasKonyvIsbn;} set { hibasKonyvIsbn=value; } }

    }

    internal class Program
    {
        
        public static int sorokSzama = 0;
        static void Main(string[] args)
        {
            List<book> books = new List<book>();
            book a= new book();

            while (true)
            {
                try
                {
                    Console.Write("Konyv isbn száma:");
                    string szam = Console.ReadLine();

                    if (szam == ""|| szam == string.Empty)
                    {
                        break;
                    }
                    a.IsbnSzam = int.Parse(szam);

                    Console.Write("Konyv szerző:");
                    a.Szerzo_k = Console.ReadLine();
                    Console.Write("Könyv címe: ");
                    a.MuCime = Console.ReadLine();
                    Console.Write("Kiadás éve: ");
                    a.KiadasEv = int.Parse(Console.ReadLine());
                    Console.Write("Nyelve: ");
                    a.Nyelv = Console.ReadLine();
                    Console.Write("Enciklopédia (true/false): ");
                    a.Enciklopedia = bool.Parse(Console.ReadLine());
                    Console.Write("Ebook?: ");
                    a.EBook = char.Parse(Console.ReadLine());
                    books.Add(a);
                }
                catch (BookExeption e)
                {
                    Console.WriteLine($"Hiba száma: {e.HibaSzam} Hibás konyv isnb száma: {e.HibasKonyvIsnb}");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sorokSzama++;
                }
            }
            
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }

}
