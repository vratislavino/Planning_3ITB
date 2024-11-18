using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal class CommandInvoker
    {
        Queue<Command> queue;

        public CommandInvoker()
        {
            queue = new Queue<Command>();
        }

        public void AddCommand(Command command)
        {
            queue.Enqueue(command);
        }

        public void ExecuteCommand()
        {
            queue.Dequeue().Execute();
        }
    }
}
