
using System.Windows.Forms;

namespace CommonTools.Win
{
    public partial class EncrypteForm : BaseForm
    {



        public EncrypteForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        private void EncrypteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm start=new StartForm();
            start.Show();
        }



    }
}
