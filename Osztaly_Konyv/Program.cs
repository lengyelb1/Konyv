using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {

        public static int sorokSzama = 0;
        static void Main(string[] args)
        {
            Konyv k = new Konyv();
            //bool helyes = false;
            /*do
            {

                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums += item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);*/

            KonyvesPolc konyvesPolc1 = new KonyvesPolc();
            try
            {
                Konyv konyv1 = new Konyv("0306406152", "Szerző 1", "Cím 1", 2023, "Magyar", false, 'n');
                Konyv konyv2 = new Konyv("0306406152", "Szerző 1", "Cím 1", 2018, "Magyar", false, 'n');
                konyvesPolc1.konyvHozzaAdasa(konyv1);
                konyvesPolc1.konyvHozzaAdasa(konyv2);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ISBN_NumberFormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidAuthorException ex)
            {
                throw ex;
            }
            catch (InvalidTitleException ex)
            {
                throw ex;
            }
            catch (InvalidInventoryNumberException ex)
            {
                throw ex;
            }
            catch (InvalidPublicationYearException ex)
            {
                throw ex;
            }
            catch (InvalidLanguageException ex)
            {
                throw ex;
            }
            List<Konyv> books = new List<Konyv>();
            Konyv a = new Konyv();
            while (true)
            {
                try
                {
                    Console.Write("Konyv isbn száma:");
                    string szam = Console.ReadLine();

                    if (szam == "" || szam == string.Empty)
                    {
                        break;
                    }
                    a.IsbnSzam = szam;

                    Console.Write("Konyv szerző:");
                    a.Szerzo = Console.ReadLine();
                    Console.Write("Könyv címe: ");
                    a.Cim = Console.ReadLine();
                    Console.Write("Kiadás éve: ");
                    a.KiadasEv = int.Parse(Console.ReadLine());
                    Console.Write("Nyelve: ");
                    a.Nyelv = Console.ReadLine();
                    Console.Write("Enciklopédia (true/false): ");
                    a.Enciklopediae = bool.Parse(Console.ReadLine());
                    Console.Write("Ebook?: ");
                    a.Ebook = char.Parse(Console.ReadLine());
                    konyvesPolc1.konyvHozzaAdasa(a);
                }
                catch (InvalidEnciklo e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidEbook e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidAuthorException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidTitleException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidInventoryNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidPublicationYearException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidLanguageException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sorokSzama++;
                }
            }

            int db = konyvesPolc1.konyvekSzama;
            Console.WriteLine(db);
            Console.WriteLine(konyvesPolc1.konyvekSzama);
            Console.WriteLine(konyvesPolc1.konyvekSzamaFuggveny());
            ////Konyv osztályba + leltári szám pontosan 11 karakter
            ////minden mezőt ellenörző adatbevitelel elkésziteni
            ////Szerző minimum 6 karakter
            ////Mű cime minimum 1 karakter
            ////Kiadás éve -10000 -- 2023 akt évig
            ////nyelv nem lehet üres
            ////enci - true/false
            ////eBook i/n
            ////Minden hibát saját exceptionnal megoldani!!!!
            ////Konyvespolc osztályban Szótárat létrehozni
            ////A szótár kulcsa a könyv leltári száma
            ////A szótár értéke a könyvnek a listában szereplő indexe
            Console.ReadKey();
        }
    }
}
