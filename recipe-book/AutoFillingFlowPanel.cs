using System.ComponentModel;

namespace recipe_book
{
    internal sealed class AutoFillingFlowPanelComboBox : ComboBox
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AutoFillingFlowPanel? Parent
        {
            get => base.Parent as AutoFillingFlowPanel;
            set => base.Parent = value;
        }

        public AutoFillingFlowPanelComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDown;
            TextChanged += ExpComboBox_TextChanged;
        }

        private void ExpComboBox_TextChanged(object? sender, EventArgs e)
        {
            if (Text == string.Empty)
            {
                Parent.Controls.Remove(Parent.EmptyTagBox);
                Parent.EmptyTagBox = this;
            }
            else if (Parent.EmptyTagBox == this)
            {
                Parent.EmptyTagBox = new AutoFillingFlowPanelComboBox() { Parent = Parent };
            }
        }
    }


    internal sealed class AutoFillingFlowPanel : FlowLayoutPanel
    {
        public readonly Dictionary<AutoFillingFlowPanelComboBox, string> Tags = new();

        private AutoFillingFlowPanelComboBox _emptyTagBox;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AutoFillingFlowPanelComboBox EmptyTagBox
        {
            get => _emptyTagBox;
            set
            {
                if (!Controls.Contains(value))
                    Controls.Add(value);
                _emptyTagBox = value;
            }
        }

        public AutoFillingFlowPanel()
        {
            FlowDirection = FlowDirection.LeftToRight;
            WrapContents = true;
            AutoScroll = true;
            EmptyTagBox = new AutoFillingFlowPanelComboBox();
        }
    }
}
