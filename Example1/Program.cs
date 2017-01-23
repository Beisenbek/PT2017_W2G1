using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Animal
    {
        int age;
        public string name;
        public double mass;
        public bool hungry;
        public Animal()
        {
            age = 0;
            mass = 0;
            hungry = true;
            name = "animal";
        }

        public void SetAge(int _age)
        {
            if (_age < 0) return;
            if (_age > 100) return;
            age = _age;
        }
        public int GetAge(string userName)
        {
            if (userName == "owner")
            {
                return age;
            }
            return -1;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }

    class BankAccount
    {
        public BankAccount()
        {
            accountInfo = "";
        }
        string accountInfo;
        public string AccountInfo
        {
            get
            {
                return accountInfo;
            }
            set
            {
                if (value.Length > 0)
                {
                    accountInfo = value;
                }
            }
        }
    }

    class Rectangle
    {
        private double square;
        private double h;
        private double w;

        public Rectangle(double h, double w)
        {
            this.w = w;
            this.h = h;
            square = w * h;
        }
        public Rectangle()
        {

        }
        public double Square
        {
            get
            {
                return square;
            }
        }
        public double W
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
                square = h * w;
            }
        }
        public double H
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
                square = h * w;
            }
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.H = r1.H + r2.H;
            r.W = r1.W + r2.W;
            return r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F3();
        }

        private static void F3()
        {
            Rectangle r = new Rectangle(5, 6);
            Rectangle r2 = new Rectangle(2, 6);
            Rectangle r3 = r + r2;
            int x = 2;
            int y = 3;
            Console.WriteLine(x + y);

            Console.WriteLine(r3.Square);
        }

        public static void F2()
        {
            BankAccount b = new BankAccount();
            b.AccountInfo = "User1 2000$";
            Console.WriteLine(b.AccountInfo);
            BankAccount c = new BankAccount { AccountInfo = "User2 3000$" };
            Console.WriteLine(c.AccountInfo);
        }

        private static void F1()
        {
            Animal a = new Animal();
            a.SetAge(10);
            a.Age = 20;
            Console.WriteLine(a.GetAge("owner"));
            Console.WriteLine(a.Age);
        }


    }
}