using System;
using System.Runtime.Remoting.Messaging;

namespace FirstLab
{
    
    class Program
    {
        public static void Main(String[] args)
        {
            Vector firstVector = new Vector(3), secondVector = new Vector(3);
            firstVector.AssignValueByIndex(1, 5);
            firstVector.AssignValueByIndex(3, 4);

            secondVector.AssignValueByIndex(1, 5);
            secondVector.AssignValueByIndex(3, 4);

            Console.WriteLine(firstVector);
            
        }
    }
}



