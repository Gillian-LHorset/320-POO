using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcerciceParachutes
{
    public class Para
    {
        public string name;
        public int paraPositionX;
        public int paraPositionY;
 
        public Para(string name)
        {
            this.name = name;
        }

        public string[] withoutParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };

        public string[] withParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

    }
}
