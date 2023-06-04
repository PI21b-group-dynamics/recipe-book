namespace recipe_book
{
    internal class SpoilerContainer : TableLayoutPanel
    {
        private string? _title;
        public string Title
        {
            get => _title ?? "Не задано";
            set => _title = value;
        }

        private readonly Button btnSpoiler;

        public SpoilerContainer()
        {
            btnSpoiler = new()
            {
                Text = Title,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Dock = DockStyle.Fill
            };
            btnSpoiler.Click += btnSpoiler_Click;
            Controls.Add(btnSpoiler);
        }

        private void btnSpoiler_Click(object? sender, EventArgs e)
        {
            Control contentControl = GetControlFromPosition(0, 1) ?? throw new NullReferenceException();
            contentControl.Visible = !contentControl.Visible;
        }
    }
}
