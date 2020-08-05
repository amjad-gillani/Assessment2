using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class Worker
    {
       
        private float w;
        public Worker() 
        {
             w = 100;
        
        }


        public float Demage(int d) 
        {
            float retVal = w - d;
            if (retVal<=70) 
            {
                retVal = 70;
            }
            return retVal;
        }
    }
}
