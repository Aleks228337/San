using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1day
{
    class Monitor
    {
        private string firm;
        public string Firm { get; set; }
        private string type;
        public string Type { get; set; }
        private float diagonal;
        public float Diagonal { get; set; }


        public void print()
        {
            Console.WriteLine("Фирма:" + Firm + "Тип:" + Type + "Диагональ:" + Diagonal);
        }

        public void vrite()
        {
            Console.WriteLine("Введите фирму");
            firm = Console.ReadLine();
            Console.WriteLine("Введите тип");
            type = Console.ReadLine();
            Console.WriteLine("Введите диагональ");
            diagonal = int.Parse(Console.ReadLine());
        }
        public Monitor()
        {
            Firm = "LG ";
            Type = "ЖК ";
            Diagonal = 19;
        }

        public Monitor(string Firm, string Type, float Diagonal)
        {
           this.Firm = Firm;
            this.Type = Type;
            this.Diagonal = Diagonal;
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Monitor name = new Monitor();
            name.print();
            Console.ReadKey();
        }
    }
}