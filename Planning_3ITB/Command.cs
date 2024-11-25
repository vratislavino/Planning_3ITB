using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal abstract class Command
    {
        protected Panel panel;
        public bool enabled = false;

        public Command(Panel panel) { 
            this.panel = panel; 
        }

        public abstract bool Execute();
    }
}
    