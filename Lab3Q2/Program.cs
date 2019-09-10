using System;
using System.Collections.Generic;


namespace Lab3Q2
{
   public class Bird//1
    {
        public double Maxheight;
       
        public string Name;
        public Bird()
        {
            this.Name = "Mountain Eagle";//2
            this.Maxheight = 500;//3
        }
        public Bird(string birdname,double max_ht)
        {
            this.Name = "Another Bird";//4
            this.Maxheight = 0;//5

        }
        public void fly()
        {
            Console.WriteLine(this.Name + "is flying at altitude" + this.Maxheight);
        }
        public void fly(int AtHeight)//6
        {
            if(AtHeight<=this.Maxheight)
            {
                Console.WriteLine(this.Name + "flying at" + AtHeight.ToString());
            }
            else //7
            {
                Console.WriteLine(this.Name + "cannot fly at this height");//8
            }

        }

        
    }
}
