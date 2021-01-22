using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{

    class MyDictionary<A>
    {
        A[] arrx;

        public MyDictionary()
        {
           arrx = new A[0];
        }

        public void Add (A item)
        {
            
            arrx = new A[arrx.Length];

            A[] temp = arrx;

            arrx = new A[arrx.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                arrx[i] = temp[i];
            }

            arrx[arrx.Length - 1] = item;

            Console.WriteLine("Başarıyla eklendi,eleman sayınız  "+arrx.Length);
        }

       
    
    }
}
