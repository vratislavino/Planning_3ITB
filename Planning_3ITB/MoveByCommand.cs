using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal class MoveByCommand : Command
    {
        public int x;
        public int y;

        public MoveByCommand(Panel p, int x, int y) : base(p)
        {
            this.x = x;
            this.y = y;
        }

        public override void Execute()
        {
            panel.Location = new Point(
                panel.Location.X + x, 
                panel.Location.Y + y
                );
        }
    }
}
