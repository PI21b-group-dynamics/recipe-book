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
            txtHelp = new RichTextBox();
            SuspendLayout();
            // 
            // txtHelp
            // 
            txtHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHelp.BorderStyle = BorderStyle.None;
            txtHelp.Location = new Point(19, 19);
            txtHelp.Margin = new Padding(8);
            txtHelp.Name = "txtHelp";
            txtHelp.ReadOnly = true;
            txtHelp.Size = new Size(430, 415);
            txtHelp.TabIndex = 0;
            txtHelp.Text = "";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 453);
            Controls.Add(txtHelp);
            Name = "HelpForm";
            Text = "Справка";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtHelp;
    }
}