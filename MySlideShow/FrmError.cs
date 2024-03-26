namespace MySlideShow
{
    public partial class FrmError : Form
    {
        public FrmError(Form owner, string message)
        {
            InitializeComponent();
            Owner = owner;
            txtMessage.Text = message;
            txtMessage.Select(message.Length, message.Length);
            Focus();
        }
    }
}
