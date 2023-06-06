namespace recipe_book.Controls
{
    internal sealed class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode)
                m.Result = 1;
            else
                base.WndProc(ref m);
        }
    }
}
