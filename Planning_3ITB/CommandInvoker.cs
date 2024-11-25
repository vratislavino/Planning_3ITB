using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning_3ITB
{
    internal class CommandInvoker
    {
        CustomQueue<Command> queue;

        public CustomQueue<Command> Queue => queue;

        public CommandInvoker()
        {
            queue = new CustomQueue<Command>();
        }

        public void AddCommand(Command command)
        {
            queue.Enqueue(command);
        }

        public bool ExecuteCommand()
        {
            var cmd = queue.Dequeue();
            if (cmd == null)
                return false;

            return cmd.Execute();
        }

        internal Command Get(int index)
        {
            return queue.Get(index);
        }
    }
}
