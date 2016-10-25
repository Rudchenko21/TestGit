using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL
{
    public class GameToGenre
    {
        public virtual Game game { get; set; }
        public virtual Genre genre { get; set; }
    }
}
