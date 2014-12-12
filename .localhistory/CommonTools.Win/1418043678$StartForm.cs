
using System.Drawing;
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

        private void PicEncrypte_MouseEnter(object sender, System.EventArgs e)
        {

        }

        private void SetPicBoxColor(Color color, PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(color, 2);
            g.DrawRectangle(pen, pictureBox.ClientRectangle.X, pictureBox.ClientRectangle.Y, pictureBox.ClientRectangle.X + pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Y + pictureBox.ClientRectangle.Height);
        }        



    }
}
