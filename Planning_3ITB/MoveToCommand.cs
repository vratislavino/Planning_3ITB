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

        public override bool Execute()
        {
            panel.Location = new Point(x, y);
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
