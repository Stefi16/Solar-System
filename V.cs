using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System
{
    class V
    {
        private static int _Age = default;
        public static int Age 
        {
            get
            {
                return _Age;
            } 
            set 
            {
                _Age = value;
            } 
        }
        private static int _Weight = default;
        public static int Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
            }
        }
    }
}
