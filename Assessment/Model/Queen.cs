using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class Queen
    {
        private float q;
        public Queen() 
        {
            q = 100;
        
        }
       
        public float Demage(int d) 
        {
            float retVal = q - d;
            if (retVal<=20) 
            {
                retVal = 20;
            }
            return retVal;
        }
    }
}
