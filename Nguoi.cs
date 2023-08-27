using System;


namespace QLSV
{
    internal class Nguoi
    {
        public string hoten;
        public int age;
        public Nguoi()
        {
        }
        public Nguoi(string hoten, int age)
        {
            this.hoten = hoten;
            this.age = age;
        }
        string getHoten()
        {
            return hoten;
        }
        public int getAge()
        {
            return age;
        }
        public void setHoten(string hoten)
        {
            this.hoten = hoten;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void Input()
        {
            Console.WriteLine("Nhap ho ten: ");
            hoten = string.(Console.ReadLine());
            Console.WriteLine("Nhap tuoi: ");
            Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine(hoten + " | " + age);
        }


    }
}
