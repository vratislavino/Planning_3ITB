namespace Planning_3ITB
{
    internal class ChangeTextCommand : Command
    {
        private string text;

        public ChangeTextCommand(Panel p, string text):base(p)
        {
            this.text = text;
        }

        public override bool Execute()
        {
            panel.Controls[0].Text = text;
            return true;
        }
    }
}