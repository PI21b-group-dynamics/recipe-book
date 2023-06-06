using System.ComponentModel;

namespace recipe_book.Controls
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
            Validating += AutoFillingFlowPanelComboBox_Validating;
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

        private void AutoFillingFlowPanelComboBox_Validating(object? sender, CancelEventArgs e)
        {
            if (Parent is null)
                throw new NullReferenceException();
            Text = Text.Trim();
            foreach (_AutoFillingFlowPanelComboBox comboBox in Parent.Controls)
                if (comboBox.Text == Text && comboBox != this)
                    comboBox.Dispose();
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
                {
                    if (_emptyTagBox is null)
                        throw new NullReferenceException();
                    _emptyTagBox.Dispose();
                }
                else
                {
                    Controls.Add(value);
                }
                _emptyTagBox = value;
            }
        }

        public IEnumerable<string> Values
        {
            get => from _AutoFillingFlowPanelComboBox combobox in Controls
                   where combobox != EmptyTagBox
                   select combobox.Text;
        }

        public AutoFillingFlowPanel()
        {
            FlowDirection = FlowDirection.LeftToRight;
            WrapContents = true;
            AutoScroll = true;
            EmptyTagBox = new _AutoFillingFlowPanelComboBox();
        }

        public void Clear()
        {
            var tmp = EmptyTagBox;
            Controls.Clear();
            EmptyTagBox = tmp;
        }
    }
}
