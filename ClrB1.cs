using System.Windows;
using System.Windows.Controls;


namespace gepers.View.UserControls
{
    /// <summary>
    /// Logique d'interaction pour ClearTextBox.xaml
    /// </summary>
    public partial class ClearTextBox : UserControl
    {
        public ClearTextBox()
        {
            InitializeComponent();

        }
        public string Texte
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }
        private string placeholder;
        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                tbPlaceholder.Text = placeholder;
            }
        }
        public event EventHandler<String> DataChanged;
        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
           // TextBox textBox = (TextBox)sender;
          //  DataChanged?.Invoke(this, textBox.Text);

            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else
                tbPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}
