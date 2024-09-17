using Laba3;
using Amazon.DirectoryService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    internal class Computer
    {
        public string ModelName;        
        public string Processor;        
        public int RAM;                 
        public int Storage;             
        public double Price;            
        internal bool HasGraphicsCard;  
        internal bool HasWiFi;          

        public Computer()
        {
        }

        
        public Computer(string modelName, string processor, int ram, int storage, double price, bool hasGraphicsCard, bool hasWiFi)
        {
            ModelName = modelName;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            Price = price;
            HasGraphicsCard = hasGraphicsCard;
            HasWiFi = hasWiFi;
        }

        public double CostPerGB
        {
            get
            {
                return GetCostPerGB();
            }
        }

        public double GetCostPerGB()
        {
            if (RAM == 0)
            {
                return 0;
            }
            return Price / RAM;
        }
    }
}




