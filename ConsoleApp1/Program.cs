using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class procesor
    {
        public string mark="";
        public double frequency;
        public double cash;
        public double price;
        public void set(string mark_)
        {
            this.mark = mark_;
        }
        public void set1(double freq_)
        {
            frequency =freq_;
        }
        public void set2(double cash_)
        {
            cash = cash_;
        }
        public void set3(double price_)
        {
            price = price_;
        }

        public string marW
        {
            get
            {
                return mark;
            }
        }
        public double casW
        {
            get
            {
                return cash;
            }
        }
        public double freqW
        {
            get
            {
                return frequency;
            }
        }
        public double priceW
        {
            get
            {
                return price;
            }
        }
        public double freq(double frequency)
        {
            string buf;
            int z;
            double start;
            do
            {
                z = 0;

                try
                {
                    start = frequency;
                    buf = Console.ReadLine();
                    frequency = Convert.ToDouble(buf);
                    

                    if (frequency < 0)
                    {
                        Console.WriteLine("Ошибка! Данные дожны быть больше 0");
                        frequency = start;
                        z = 1;
                    }else
                    {
                        z = 0;
                    }
                   



                }
                catch 
                {
                    Console.WriteLine("Ошибка! Некоректный ввод.");
                    z = 1;
                }
            } while (z == 1);
            
            return (frequency);
            
            
        }
        public double cas (double cash)
        {
            
                
            {
                string buf;
                int z;
                double start;
                do
                {

                    z = 0;
                    try
                    {
                        start = cash;
                        buf = Console.ReadLine();
                        cash = Convert.ToDouble(buf);
                        if (cash < 0)
                        {
                            Console.WriteLine("Ошибка! Данные дожны быть больше 0");
                            cash = start;
                            z = 1;
                        }
                        else
                        {
                            z = 0;
                        }




                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Некоректный ввод.");
                        z = 1;
                    }
                } while (z == 1);
            
            }
            
                return (cash);
            
        }
        public double pr(double price)
        {


            {
                string buf;
                int z;
                double start;
                do
                {

                    z = 0;
                    try
                    {
                        start = price;
                        buf = Console.ReadLine();
                        price= Convert.ToDouble(buf);
                        Console.WriteLine(price);
                        if (price < 0)
                        {
                            Console.WriteLine("Ошибка! Данные дожны быть больше 0");
                            price = start;
                            z = 1;
                        }
                        else
                        {
                            z = 0;
                        }




                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Некоректный ввод.");
                        z = 1;
                    }
                } while (z == 1);
            }

            return (price);

        }

    }
    
 
    class Program
    {
        static void Main(string[] args)
        {
            procesor x = new procesor();
            string buf, mark;
            int n;
            double frequency=0, cash=0, price=0;
            for (; ; )
            {
                Console.WriteLine("\nВыберите пункт меню:\n1.Указать новую конфигурацию\n2.Проверка состояния.");
                buf = Console.ReadLine();
                n = Convert.ToInt32(buf);
                switch (n)
                {
                    case 1:
                        Console.Write("Укажите марку процессора ");
                        mark = Console.ReadLine();
                        x.set(mark);
                        Console.Write("Укажите тактовую частоту (В Гц) ");

                        x.set1(x.freq(frequency));
                        


                        Console.Write("Укажите кеш ");

                        x.set2(x.cas(cash)); 
                        Console.Write("Укажите цена ");
                        x.set3(x.pr(price)); 



                    break;
                    case 2:
                        Console.WriteLine("Марка: " + x.marW+"\nТактовая частота: "+x.freqW+"\nКеш: "+x.casW+"\nЦена: "+ x.priceW);


                        break;
                    default:
                        Console.WriteLine("Ошибка\nНесуществующий пункт меню");
                        break;
                }
            }
        }
    }
}
