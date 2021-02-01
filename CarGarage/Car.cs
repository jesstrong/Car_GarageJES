using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {








        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        public Car()
        {
            Make = "your model car";
        }
        public void SetMake(string make)
        {
            Make = make;
        }

        public void SetModel(string model)
        {
            Model = model;
        }


        public int GetSpeed()

        {
                      
            return Speed;

        }

        public bool IsSpeeding()
        {
            if (Speed > 70)
            {
                return true;
            }
                return false; 
        }
            
        public void Accelerate()
        {
            if (Speed < 100)
            {
                if (Make == "Ferrari")
                    Speed += 20;
                else
                    Speed += 10; 

            }
            else
            {
                Speed = Speed; 
            }
                             
                    
        }
                
        
        public void Brake()        
            
        {
            if (Speed > 7)
            {
                Speed -= 7; 
            }
            
        }
    }
}
