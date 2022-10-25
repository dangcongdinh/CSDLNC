using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bai4
    {
        ArrayList X = new ArrayList();
        string u = "";

        public void docFile()
        {
            string docFile = File.ReadAllText("abcd.txt");

            string[] str1 = docFile.Split(' ');
            foreach(string str in str1)
            {
                string[] str2 = str.Split(new char[] {'-','>'},StringSplitOptions.RemoveEmptyEntries);
                PTH pth = new PTH(str2[0], str2[1]);
                X.Add(pth);
            }
        }
        public void nhap()
        {
            Console.WriteLine("Nhap U:");
            u = Console.ReadLine();
            docFile();
            /*Console.WriteLine("Nhap so PTH:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap PTH thu {i + 1}");
                Console.WriteLine("Nhap ve trai");
                string vt = Console.ReadLine();
                Console.WriteLine("Nhap ve phai");
                string vp = Console.ReadLine();
                PTH pth = new PTH(vt, vp);
                X.Add(pth);
            }*/
        }
        public void show()
        {
            foreach (PTH pth in X)
                Console.WriteLine(pth);
        }
        public string rutGon(string str1)
        {
            string str = "";
            for (int i = 0; i < str1.Length; i++)
            {
                if (!str.Contains(str1[i]))
                {
                    str += str1[i];
                }
            }
            return str;
        }

        public List<string> tapCon(string str)
        {
            List<string> list = new List<string>(); 
            for (int i = 0; i < str.Length; i++)
            {
                list.Add(str[i]+"");
                int j = i + 1;
                int d = 1;
                while (str.Length - j > 0)
                {
                    for (int k = j; k < str.Length; k++)
                    {
                        list.Add(str.Substring(i,d) + str[k]);
                    }
                    d++;
                    j++;
                }
            }
            return list;
        }

        //TÌM BAO ĐÓNG
        public string exercute_baoDong(string k)
        {
            bool flag = true;
            string Xp = k;
            string str_out = "";
            while (flag)
            {
                foreach (PTH pth in X)
                {
                    int d = 0;
                    for (int i = 0; i < pth.vt.Length; i++)
                    {
                        for (int j = 0; j < Xp.Length; j++)
                        {
                            if (pth.vt[i] == Xp[j])
                            {
                                d++;
                            }
                        }
                    }
                    if (d == pth.vt.Length)
                    {
                        Xp = Xp + pth.vp;
                        Xp = rutGon(Xp);
                    }
                }
                //Nếu lần kế tiếp mà có giống lần trước thì cho out khỏi vòng lặp While
                if (Xp.Equals(str_out))
                {
                    flag = false;
                }
                str_out = Xp;
            }
            return Xp;
        }
        //TÌM MỘT KHÓA 
        public void one_Key()
        {
            string k = u;
            for (int i = 0; i < u.Length; i++)
            {
                string s = "";
                //Tiến hành trừ từng phần tử có trong U
                for (int j = 0; j < k.Length; j++)
                {
                    if (k[j] != u[i])
                    {
                        s += k[j];
                    }
                }
                if(exercute_baoDong(s).Length != u.Length)
                {
                    s += u[i];
                }
                k = s;
            }
            Console.WriteLine($"Khoa can tim: {k}");
        }
        //TÌM TẤT CẢ CÁC KHÓA
        public string TG()
        {
            string R = "";
            string L = "";
            string str = "";
            foreach(PTH pth in X)
            {
                L += pth.vt;
                R += pth.vp;
                L = rutGon(L);
                R = rutGon(R);
            }
            for(int i = 0; i < L.Length; i++)
            {
                for(int j = 0; j < R.Length; j++)
                {
                    if (L[i] == R[j])
                    {
                        str += L[i];
                        break;
                    }
                }
            }
            return str;
        }
        public string TN()
        {
            string str = "";
            string R = "";
            foreach (PTH pth in X)
            {
                R += pth.vp;
                R = rutGon(R);
            }
            for(int i = 0; i < u.Length; i++)
            {
                if (!R.Contains(u[i]))
                {
                    str += u[i];
                }
            }
            return str;
        }

        //Rút gọn siêu khóa
        public List<string> rutGonSieuKhoa(List<string> list1)
        {
            List<string> list2 = new List<string>();
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = i + 1; j < list1.Count; j++)
                {
                    if (list1[j].Contains((string)list1[i]))
                    {
                        list2.Add((string)list1[j]);
                    }
                }
            }
            foreach (string str in list2)
            {
                list1.Remove(str);
            }
            return list1;
        }
        public void exercute_Key()
        {
            List<string> list = new List<string>();
            List<string> list_kq1 = new List<string>();
            Console.WriteLine("Buoc 1: Xac dinh Tap nguon va Tap trung gian");
            string TN = this.TN();
            string TG = this.TG();
            Console.WriteLine($"TN: {TN}");
            Console.WriteLine($"TG: {TG}");
            List<string> list_Xi = new List<string>();
            if (TG == "")
            {
                Console.WriteLine($"Khoa cua LDQH la: {TN}");
            }
            list = tapCon(TG);
            list_Xi.Add(TN);
            foreach(string str in list)
            {
                list_Xi.Add(TN + str);
            }
            Console.WriteLine("Buoc 2: Tinh bao dong cua tung phan tu con");
            foreach (string str in list_Xi)
            {
                int d = 0;
                string s = exercute_baoDong(str);
                Console.WriteLine($"Bao dong cua {str} la: {s}");
                for (int i = 0; i < s.Length; i++)
                {
                    if (u.Contains(s[i]))
                        d++;
                }
                if (d == u.Length)
                {
                    list_kq1.Add(str);
                }
            }
            Console.WriteLine("Cac sieu khoa la:");
            foreach (string str in list_kq1)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            list_kq1 = rutGonSieuKhoa(list_kq1);
            Console.WriteLine("Cac khoa toi thieu la:");
            foreach(string str in list_kq1)
            {
                Console.Write(str+" ");
            }
            Console.WriteLine();
        }

    }
    
}

