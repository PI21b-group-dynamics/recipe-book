using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace recipe_book
{
    internal class RoundButton : Panel
    {
        private readonly Button button;

        [Browsable(true)]
        public override string Text
        {
            get => button.Text;
            set => button.Text = value;
        }

        public RoundButton()
        {
            button = new Button() { Dock = DockStyle.Fill };
            Controls.Add(button);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using GraphicsPath graphicsPath = new();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
    }
}
