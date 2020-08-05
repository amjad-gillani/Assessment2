using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class Drone
    {
        private float drone;
        public Drone() 
        {
            drone = 100;
        
        }
       
        public float Demage(int d) 
        {
            float retVal = drone - d;
            if (retVal<=50) 
            {
                retVal = 50;
            }
            return retVal;
        }
    }
}
