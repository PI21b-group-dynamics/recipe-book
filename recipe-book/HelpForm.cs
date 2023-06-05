using recipe_book.Properties;

namespace recipe_book
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            string filename = Path.GetTempFileName();
            File.WriteAllText(filename, Resources.Help);
            txtHelp.LoadFile(filename);
        }
    }
}
