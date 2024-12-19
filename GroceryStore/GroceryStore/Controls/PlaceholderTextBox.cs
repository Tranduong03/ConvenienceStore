using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore.Controls
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholderText = "Enter text...";
        private Color _placeholderColor = Color.Gray;
        private bool _isPlaceholderActive = true;

        [Category("Placeholder"), Description("Text to display as placeholder")]
        public new string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value;
                UpdatePlaceholder();
            }
        }

        [Category("Placeholder"), Description("Color of the placeholder text")]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                _placeholderColor = value;
                UpdatePlaceholder();
            }
        }

        public PlaceholderTextBox()
        {
            // Kích hoạt Placeholder ban đầu
            UpdatePlaceholder();

            // Gắn các sự kiện cần thiết
            GotFocus += RemovePlaceholder;
            LostFocus += SetPlaceholder;
        }

        private void UpdatePlaceholder()
        {
            if (string.IsNullOrEmpty(Text) && _isPlaceholderActive)
            {
                _isPlaceholderActive = true;
                ForeColor = _placeholderColor;
                Text = _placeholderText;
            }
        }

        private void RemovePlaceholder(object ? sender, EventArgs e)
        {
            if (_isPlaceholderActive)
            {
                _isPlaceholderActive = false;
                Text = string.Empty;
                ForeColor = SystemColors.WindowText; // Reset về màu chữ thông thường
            }
        }

        private void SetPlaceholder(object ? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                _isPlaceholderActive = true;
                ForeColor = _placeholderColor;
                Text = _placeholderText;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            // Xóa Placeholder nếu người dùng nhập liệu
            if (!_isPlaceholderActive && string.IsNullOrEmpty(Text))
            {
                SetPlaceholder(this, e);
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetPlaceholder(this, EventArgs.Empty); // Đảm bảo Placeholder được áp dụng khi control khởi tạo
        }
    }
}
