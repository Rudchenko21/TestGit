using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL
{
    public class GameToPlatormType
    {
        public virtual Game Game { get; set; }
        public virtual PlatformType PlatformType { get; set; }
    }
}
