using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal class ChangeColorCommand : Command
    {
        Color color;

        public ChangeColorCommand(Panel panel, Color color) : base(panel)
        {
            this.color = color;
        }

        public override void Execute()
        {
            panel.BackColor = color;
        }

        public override string ToString()
        {
            return $"{GetType().Name} - [{color.R},{color.G},{color.B}]";
        }
    }
}
