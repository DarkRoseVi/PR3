using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3.Components
{
    partial class Characteristic
    {
        public string ColorTY { get 
            {
                if (Type.Id == 1)
                {
                    return "#00FA9A";
                }
                else return "#FA8072";
            } }
    }
}
