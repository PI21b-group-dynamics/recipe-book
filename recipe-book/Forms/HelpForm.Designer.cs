namespace recipe_book
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            txtHelp = new RichTextBox();
            SuspendLayout();
            // 
            // txtHelp
            // 
            txtHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHelp.BorderStyle = BorderStyle.None;
            txtHelp.Location = new Point(17, 14);
            txtHelp.Margin = new Padding(7, 6, 7, 6);
            txtHelp.Name = "txtHelp";
            txtHelp.ReadOnly = true;
            txtHelp.Size = new Size(376, 311);
            txtHelp.TabIndex = 0;
            txtHelp.Text = "";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 340);
            Controls.Add(txtHelp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "HelpForm";
            Text = "Справка";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtHelp;
    }
}