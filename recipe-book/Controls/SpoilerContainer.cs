namespace recipe_book.Controls
{
    internal sealed class SpoilerContainer : TableLayoutPanel
    {
        private string? _title;
        public string Title
        {
            get => _title ?? "Не задано";
            set
            {
                _title = value;
                _btnSpoiler.Text = _title;
            }
        }

        private readonly Button _btnSpoiler;

        public SpoilerContainer()
        {
            _btnSpoiler = new()
            {
                Text = Title,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill
            };
            _btnSpoiler.Click += btnSpoiler_Click;
            Controls.Add(_btnSpoiler);
        }

        private void btnSpoiler_Click(object? sender, EventArgs e)
        {
            Control contentControl = GetControlFromPosition(0, 1) ?? throw new NullReferenceException();
            contentControl.Visible = !contentControl.Visible;
        }
    }
}
