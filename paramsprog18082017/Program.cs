using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsprog18082017
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();

            sample.add(1, 12, 13,"hi");

            //sample.add(1, 12, 13);
            Console.ReadLine();

        }

    }

   public class Sample
    {
        //public void add(params int[] arr)
        public void add(params object[] arr)

        {
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum =sum +  arr[i];
            //}
            // Console.Write(sum);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }






}



