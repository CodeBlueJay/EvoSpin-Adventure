using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoSpin.Spinnables
{
    public class items
    { 
        public (string item, double weight)[] spinnables = new (string item, double weight)[]
        {
            ("Dog", 0.33),
            ("Cat", 0.33),
            ("Fish", 0.33),
            ("Ball", 0.33),
            ("Honda Civic", 0.33),
            ("Space", 0.25),
            ("Sugar Glider", 0.1),
            ("Cosmic Leviathan", 0.01)
        };
    }
}
