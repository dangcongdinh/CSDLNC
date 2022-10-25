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
        ArrayList X = new ArrayList();
        List<string> Xp = new List<string>();
        public void nhap()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Nhap PTH thu {i}");
                Console.WriteLine("Nhap ve trai");
                string vt = Console.ReadLine();
                Console.WriteLine("Nhap ve phai");
                string vp = Console.ReadLine();
                PTH pth = new PTH(vt,vp);
                X.Add(pth);
            }
        }
        public bool child(List<String>a,ArrayList array)
        {
            bool flag = false;
            for(int i=0;i<a.Count;i++)
            {
                for(int j = 0; j < array.Count; j++)
                {
                    if (a[i].Equals())
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }
        public void show()
        {
            foreach (PTH pth in X)
                Console.WriteLine(pth);
        }
        public void exercute(string a)
        {
            Boolean flag = true;
            Xp.Count
            while (flag)
            {
                flag = false;
                foreach(PTH pth in X)
                {
                    if(child(X.C)
                }
            }
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.nhap();
            a.show();
        }
    }
}
