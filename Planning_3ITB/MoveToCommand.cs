using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal class MoveToCommand : Command
    {
        private int x;
        private int y;
        public MoveToCommand(Panel panel, int x, int y) : base(panel)
        {
            this.x = x;
            this.y = y;
        }

        public override void Execute()
        {
            panel.Location = new Point(x, y);
        }
    }
}
