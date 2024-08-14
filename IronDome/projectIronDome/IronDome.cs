using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projectIronDome
{
   
        internal class IronDome
        {
            public async Task<bool> handleMissile(Missile missile)
            {

                await Task.Delay(10000);

                Random random = new Random();
                bool intercepted = random.Next(0, 2) == 1;
                return intercepted;

            }
        }
    
}
