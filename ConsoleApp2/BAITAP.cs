using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k = "";
            string t = "";
            Bai4 a = new Bai4();
            a.nhap();
            /*a.show();*/
            /*do
            {
                Console.WriteLine("Nhap bao dong can tim: ");
                k = Console.ReadLine();
                Console.WriteLine(a.exercute_baoDong(k));
                Console.WriteLine("Nhan t de tiep tuc Hoac nhan x de thoat");
                t = Console.ReadLine();
            } while (t.Equals("t"));
            a.one_Key();*/
            Console.WriteLine("XAC DINH CAC KHOA CUA LDQH");
            a.exercute_Key();
        }
    }
}
