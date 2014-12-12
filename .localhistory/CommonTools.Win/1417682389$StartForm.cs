
using System.Windows.Forms;

namespace CommonTools.Win
{
    public partial class StartForm : BaseForm
    {



        public StartForm()
        {
            ApplySkin("McSkin");            
            InitializeComponent();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PicEncrypte_Click(object sender, System.EventArgs e)
        {

        }

        private void PicEncrypte_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
