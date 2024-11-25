using System;
using System.Collections.Generic;
using System.Drawing;
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

        public override bool Execute()
        {
            panel.Location = new Point(
                panel.Location.X + x, 
                panel.Location.Y + y
                );

            if (panel.Location.X < 0 ||
                panel.Location.X + panel.Width > panel.Parent.Width ||
                panel.Location.Y < 0 ||
                panel.Location.Y + panel.Height > panel.Parent.Height)
                return false;
            return true;
        }

        public override string ToString()
        {
            return $"{GetType().Name} - [{x},{y}]";
        }
    }
}
