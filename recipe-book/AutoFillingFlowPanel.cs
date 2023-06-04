using System.ComponentModel;

namespace recipe_book
{
    internal sealed class _AutoFillingFlowPanelComboBox : ComboBox
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AutoFillingFlowPanel? Parent
        {
            get => base.Parent as AutoFillingFlowPanel;
            set => base.Parent = value;
        }

        public _AutoFillingFlowPanelComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDown;
            TextChanged += AutoFillingFlowPanelComboBox_TextChanged;
            Validating += (object? sender, CancelEventArgs e) => Text = Text.Trim();
        }

        private void AutoFillingFlowPanelComboBox_TextChanged(object? sender, EventArgs e)
        {
            if (Parent is null)
                throw new NullReferenceException();
            if (Text == string.Empty)
                Parent.EmptyTagBox = this;
            else if (Parent.EmptyTagBox == this)
                Parent.EmptyTagBox = new _AutoFillingFlowPanelComboBox();
        }
    }


    internal sealed class AutoFillingFlowPanel : FlowLayoutPanel
    {
        private _AutoFillingFlowPanelComboBox? _emptyTagBox;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public _AutoFillingFlowPanelComboBox EmptyTagBox
        {
            get => _emptyTagBox ?? throw new NullReferenceException();
            set
            {
                if (Controls.Contains(value))
                    Controls.Remove(_emptyTagBox);
                else
                    Controls.Add(value);
                _emptyTagBox = value;
            }
        }

        public AutoFillingFlowPanel()
        {
            FlowDirection = FlowDirection.LeftToRight;
            WrapContents = true;
            AutoScroll = true;
            EmptyTagBox = new _AutoFillingFlowPanelComboBox();
        }
    }
}
