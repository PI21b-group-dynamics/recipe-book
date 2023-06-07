namespace recipe_book
{
    public sealed partial class MainForm : Form
    {
        private void ChangeSlideMenuVisibility(bool visibility)
        {
            pnlUser.BackColor = visibility ? pnlSlideMenu.BackColor : UserLayoutPanelOriginalBackColor;
            pnlSlideMenu.Visible = visibility;
        }

        private void ShowSlideMenuOnMouseEnter(object sender, EventArgs e)
        {
            ChangeSlideMenuVisibility(true);
        }

        private void HideSlideMenuOnMouseLeave(object sender, EventArgs e)
        {
            if (!SlideMenuHoverZone.Contains(PointToClient(Cursor.Position)))
                ChangeSlideMenuVisibility(false);
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EditProfileForm editProfileForm = new(userId, lblUser.Text, picUser.Image);
            switch (editProfileForm.ShowDialog())
            {
                case DialogResult.Abort:
                    Hide();
                    Authorize();
                    break;
                case DialogResult.OK:
                    lblUser.Text = editProfileForm.Login;
                    picUser.Image = editProfileForm.Photo;
                    break;
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            _helpForm = new HelpForm();
            _helpForm.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm_Load(sender, e);
            if (!IsDisposed)
                Show();
        }
    }
}
