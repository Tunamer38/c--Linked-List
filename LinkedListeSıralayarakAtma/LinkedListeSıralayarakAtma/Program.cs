using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListeSıralayarakAtma
{
    class Program
    {
        static block first = null;
        static block last = null;

        public static void Main()
        {
            Random rnd = new Random();
            block list = null;
            Console.WriteLine("Linked List Dizin Sayısını Giriniz: ");
            int len=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                int deger = rnd.Next(1, 100);                
                list = Atama(list, deger,i,len);
            }
            block t = first;
            while (t!=null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }
            Console.ReadKey();

        }
        public static block Atama(block temp, int veri,int sayac,int length)
        {
            
            temp = new block();
            temp.data = veri;
            temp.next = null;
            temp.prev = last;
            if (first == null) first = temp;
            else last.next = temp;
            last = temp;
            
            if (sayac == length - 1)
            {
                block A = first;
                block B = first;
                while (A != null)
                {

                    while (B != null)
                    {
                        if (A.data <= B.data)
                        {                            
                            int tmp = B.data;
                            B.data = A.data;
                            A.data = tmp;
                        }
                        B = B.next;
                    }
                    A = A.next;
                    B = first;
                }
                temp = A;
            }
            
            return temp;
        }
    }

    class block
    {
        public int data;
        public block next,prev ;       
    }
}
