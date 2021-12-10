using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Panda
{
    internal class Program
    {

        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = end = 0;
            for (int i = 0; i<list.Count;i++)
            {
                if ((ulong)list[i] <= sum)//проверкаяем набор из последующих элементов (превышение сумм сразу пропускается)
                {
                    ulong sumsum = list[i];
                    for (int ii = i; ii < list.Count; ii++)
                    {
                        if (sumsum + (ulong)list[ii] < sum) //если недобрали, то плюсуем , пока не превысили
                        {
                            sumsum += (ulong)list[ii];
                           
                        }
                        else if (sumsum + (ulong)list[ii]- (ulong)list[i] == sum||sumsum == sum) //если набрали равную сумму или сумма сразу сошлась(одним элементом)
                        {
                            start = i; end = ii + 1;
                           return; //чтобы выйти из функции при первом же совпадении
                        }
                       
                      

                    }
                }
                
              
                    
                    
                    
                
               
            }
            
        }
  

        
        static void Main(string[] args)
        {
            Program p = new Program();       

            
            int end;
            int start;
            //*
            List<uint>list = new List<uint>();
            string path = @"C:\List.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    
                    list.Add(Convert.ToUInt32(line) );
                    
                }
            }
            p.FindElementsForSum(list, 15991913, out start, out end);
            //*/

            //p.FindElementsForSum(new List<uint>(){1,2,3,5},5, out start, out end);
            //p.FindElementsForSum(new List<uint>() { 1, 5, 2, 3, 5 }, 5, out start, out end);
            Console.WriteLine(start+" "+end);
            Console.ReadLine();

        }
    }
}
