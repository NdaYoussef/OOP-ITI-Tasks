using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay1
{
    internal class Airplane
    {
        //characterisitics 
       public string model;
       public int noOfPassengers;
       public int speed;
       public string color; 
    
        void TakeOff()
        {


        }

        void TakeOn() { }

        Airplane airplane = new Airplane(); // this leads to aan error which is stackOverflowException
        

    }
}
