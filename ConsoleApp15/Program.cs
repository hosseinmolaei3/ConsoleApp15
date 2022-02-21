using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Security.Cryptography;
using System.IO;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 3, 2, 5, 4, 1 };
            int temp;
            Console.WriteLine("start sorting: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + $"{array[i]}");
            }
            for (int g = 0; g <= array.Length-2; g++)
            {
                for (int j = 0; j <= array.Length-2; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("end sorted");
            for (int f = 0; f < array.Length; f++)
            {
                Console.Write(" " + $"{array[f]}");
            }
            Console.WriteLine();
            Console.ReadKey();
            //---------------------------------------------------------------------------------
            //int temp, klid;
            //Console.WriteLine("Selection sort start: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(" " + $"{array[i]}");
            //}
            //for (int f = 0; f < array.Length - 1; f++)
            //{
            //    klid = f;
            //    for (int h = f + 1; h < array.Length; h++)
            //    {
            //        if (array[h] < array[klid])
            //        {
            //            klid = h;
            //        }
            //    }
            //    temp = array[klid];
            //    array[klid] = array[f];
            //    array[f] = temp;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Selection sort ended: ");
            //for (int O = 0; O < array.Length; O++)
            //{
            //    Console.Write(" " + $"{array[O]}");
            //}
            //---------------------------------------------------------------------------------
            //int[] x = new int[] { 56, 33, 89, 47, 12, 63 };
            //int temp;
            //int h = 0;
            //Console.WriteLine("start");
            //for (int j = 0; j < x.Length; j++)
            //{
            //    Console.WriteLine(x[j] + " ");
            //}
            //try
            //{
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        for (int m = 1; m < x.Length; m++)
            //        {
            //            if ((x[i] < x[m]) && (x[i] > x[m]))
            //            {
            //                temp = x[i];
            //                x[i] = x[m];
            //                x[m] = temp;
            //            }
            //            //if (x[i] > x[m])
            //            //{
            //            //    temp = x[m];
            //            //    x[m] = x[i];
            //            //    x[i] = temp;
            //            //}
            //            if (x[i] < x[m])
            //            {
            //                temp = x[i];
            //                x[i] = x[m];
            //                x[m] = temp;
            //            }
            //        }
            //    }
            //    Console.WriteLine("end");
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        Console.WriteLine(x[i] + " ");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("khata");
            //}
            //---------------------------------------------------------------------------------
            //int[] Array = new int[] { 30, 3, 56, 40, 89, 66,3,36,3,37, 74, 64, 32 };
            //int sun = 6;
            //int[] result = (from n in Array select n).ToArray();
            //int[] result1 = (from n in Array orderby n descending select n).ToArray();
            //int[] result2 = (from n in Array where 60 > n orderby n  select n).ToArray();
            //int result3 = (from n in Array where n == 3 select n).FirstOrDefault();
            //bool result4 = (from n in Array where n == sun select n).Any();
            //// Console.WriteLine(result4);
            //List<string> Names = new List<string>();
            //Names.Add("Ali");
            //Names.Add("Hossein");
            //Names.Add("Hamed");
            //Names.Add("Hamid");
            //Names.Add("Sakineh");

            //var name = (from n in Names select n).ToList();
            //var name1 = (from n in Names where n.ToLower().StartsWith("h") select n).ToList();
            //try
            //{
            //    var name2 = (from n in Names where n == "H" select n).SingleOrDefault();
            //    Console.WriteLine(name2);
            //    foreach (var hh in name1)
            //    {
            //        Console.Write(hh + " ");
            //    }
            //    Console.WriteLine("\n");
            //}
            //catch
            //{
            //    Console.WriteLine("bug in code");
            //}
            //int adad;
            //Console.WriteLine("adad ro vared konid ");
            //adad = int.Parse(Console.ReadLine());
            //int a = adad;
            //int b = adad;
            //while (a !=0)
            //{
            //    a = a / 10;
            //    b = b % 10;
            //}
            //Console.WriteLine(b);
            //try
            //{
            //    //int[] arr = new int[] { };
            //    //string gogo = "h";
            //    //byte[] vs = Encoding.ASCII.GetBytes(gogo);
            //    //Console.WriteLine(vs[0]);
            //    //Console.WriteLine();
            //    //string Name = "hossein";
            //    //string Family = "mohammadi";
            //    //string Mobile = "09365489";
            //    //string Email = "hamed@molaei.com";
            //    //LinkedList<string> peson = new LinkedList<string>();
            //    //peson.AddLast(Name);
            //    //peson.AddLast(Family);
            //    //peson.AddLast(Mobile);
            //    //peson.AddLast(Email);
            //    //Console.WriteLine(peson.First.Value);
            //    //////////////////////////////////////////
            //    //string[] array = new string[200000];
            //    //array[0] = Name;
            //    ////test(Name, Family, Mobile, Email);
            //    //char a = 'h';
            //    //Console.WriteLine((int)a);
            //    //string address=File.Create("./asami.txt").ToString();
            //    //TextWriter tw = new StreamWriter(address);
            //    //tw.WriteLine(Name);
            //    //TextReader tr = new StreamReader(address);
            //    //string hgh = tr.Read().ToString();
            //    //Console.WriteLine(hgh);

            //    ///////////////////////////////////////////////
            //    //SHA1 sh1 = SHA1.Create();
            //    //SHA256 sHA256 = SHA256.Create();
            //    //SHA512 sHA512 = SHA512.Create();
            //    //byte[] byt1 = Encoding.ASCII.GetBytes(Name);
            //    //byte[] byt2 = Encoding.ASCII.GetBytes(Family);

            //    //Console.WriteLine("-------------------------------");
            //    //byte[] hashbite1 = sh1.ComputeHash(byt1);
            //    //string ash1 = "";
            //    //var neon1 = 0;
            //    //foreach (var item in hashbite1)
            //    //{
            //    //    ash1 += item.ToString("X") + "-";
            //    //    neon1 += item;
            //    //}
            //    //Console.WriteLine(" sha1: " + ash1 + " size of : " + ash1.Length);
            //    //Console.WriteLine(" sha1 neon1: " + (int)neon1);
            //    //Console.WriteLine("-------------------------------");
            //    //byte[] hashbite256 = sHA256.ComputeHash(byt1);
            //    //string ash256 = "";
            //    //var neon2 = 0;
            //    //foreach (var item in hashbite256)
            //    //{
            //    //    ash256 += item.ToString("X") + "-";
            //    //    neon2 += item;
            //    //}
            //    //Console.WriteLine(" SHA256: " + ash256 + " size of : " + ash256.Length);
            //    //Console.WriteLine(" sha1 neon2: " + (int)neon2);
            //    //Console.WriteLine("-------------------------------");
            //    //byte[] hashbite512 = sHA512.ComputeHash(byt1);
            //    //string ash512 = "";
            //    //var neon3 = 0;
            //    //foreach (var item in hashbite512)
            //    //{
            //    //    ash512 += item.ToString("X") + "-";
            //    //    neon3 += item;
            //    //}
            //    //Console.WriteLine(" SHA512: " + ash512 + " size of : " + ash512.Length);
            //    //Console.WriteLine(" sha1 neon3: " + (int)neon3);
            //    //Console.WriteLine("-------------------------------");
            //    //int sumname = 0;
            //    //foreach (var gg in byt1)
            //    //{
            //    //    Console.WriteLine(" " + (int)gg);
            //    //    sumname += (int)gg;
            //    //}
            //    //Console.WriteLine("-------------------------------");
            //    //int sumfamily = 0;
            //    //foreach (var pp in byt2)
            //    //{
            //    //    Console.WriteLine(" " + (int)pp);
            //    //    sumfamily += (int)pp;
            //    //}
            //    //Console.WriteLine("-------------------------------");
            //    //Console.WriteLine(" sumname : " + sumname);
            //    //Console.WriteLine(" sumfamily : " + sumfamily);
            //    //Console.WriteLine(" sumname + sumfamily : " + (sumname + sumfamily));
            //    //Console.WriteLine("-------------------------------");
            //    //Console.WriteLine(" Total sum location : "
            //    //    + ((sumname * (sumname + sumfamily) * 30) / (sumfamily * Name.Length * Family.Length * 10)));
            //    //Console.WriteLine("-------------------------------");
            //    //int loc = ((sumname * (sumname + sumfamily) * 30) / (sumfamily * Name.Length * Family.Length * 10));
            //    //string hashbuilder = loc.ToString();
            //    //Console.WriteLine(" hashbuilder : " + hashbuilder.Trim());
            //    //Console.WriteLine(" int loc : " + loc);
            //    //Console.WriteLine("-------------------------------");
            //    //string[] hash = new string[100000];
            //    ////string ss;
            //    //hash[loc] = Mobile;
            //    //Console.WriteLine(" " + hash[loc]);
            //    test("hossein", "molaei", "45445554", "ftjnfynf");
            //    Console.ReadKey();
            //}
            //catch
            //{
            //    Console.WriteLine("kahta");
            //}
        }
        //unsafe public static void test(string name,string family,string mobile, string email)
        //{
        //    fixed (char* ptr = name)
        //    {
        //        Console.Write(name + ": Address--> " + (int)ptr);
        //        int address = (int)ptr;
        //    }
        //    Console.WriteLine();
        //    fixed (char* ptr = family)
        //    {
        //        Console.Write(family + ": Address--> " + (int)ptr);
        //    }
        //    Console.WriteLine();
        //    fixed (char* ptr = mobile)
        //    {
        //        Console.Write(mobile + ": Address--> " + (int)ptr);
        //    }
        //    Console.WriteLine();
        //    fixed (char* ptr = email)
        //    {
        //        Console.Write(email + ": Address--> " + (int)ptr);
        //    }

        //int[] a = new int[fa.Length];
        ////fixed (int* b = a) ;

        //int*[] b = new int*[fa.Length];
        //for (int i = 0; i < fa.Length; i++)
        //{
        //    a[i] = Convert.ToInt32(fa[i]);
        //}
        //for(int k = 0; k < fa.Length; k++)
        //{
        //    Console.Write(" " + a[k] + " ");
        //}
        //Console.WriteLine();
        //for (int h = 0; h < fa.Length; h++)
        //{
        //    int s= a.Length;
        //    b[h] = (int*)a[h];
        //    Console.Write(" " + (int)(b [h]) + " ");
        //}

        // }
        //public static int power(int a, int b)//4       3
        //{
        //    int nana = 1;
        //    for(int i = 0; i < b; i++)//3
        //    {
        //        nana *= a;
        //    }
        //    return nana;
        //}
        //unsafe public static int kk(string[] vs)
        //{
        //    int address;
        //    fixed (char* ptr = vs[0])
        //    {
        //        //Console.Write(vs[0] + ": Address--> " + (int)ptr);
        //        address = (int)ptr;
        //    }
        //    return address;
        //}
    }
}
