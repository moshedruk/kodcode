using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectIronDome
{
   
        public class Missile
        {
        public string name { get; set; }
        public string speed { get; set; }
        public int muss { get; set; }
        public int time { get; set; }
        public Coordinate origin { get; set; }
        public Coordinate ungle { get; set; }
        public int damage { get; set; }   // לוודא ששדה זה נמצא גם 
    }
    
}
