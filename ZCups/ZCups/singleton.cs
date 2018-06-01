using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
    class singleton
    {
        public List<int> Id { get; set; }
        public double TotalPrice = .0;
        public List<double> Price { get; set; }
        private static singleton _instance;
        public static singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new singleton();
                    // once the insatce is created all the intial object will be creates with it 
                    _instance.CreateInstance();

                }

                return _instance;
            }
        }

        private void CreateInstance()
        {
            Id = new List<int>();
            Price = new List<double>();
        }
    }
}
