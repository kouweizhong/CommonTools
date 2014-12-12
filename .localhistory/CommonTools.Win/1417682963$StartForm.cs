
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
            Graphics g = PicEncrypte.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);
            //g.Clear(this.BackColor);
            g.DrawRectangle(pen, PicEncrypte.ClientRectangle.X, PicEncrypte.ClientRectangle.Y, PicEncrypte.ClientRectangle.X + PicEncrypte.ClientRectangle.Width, PicEncrypte.ClientRectangle.Y + PicEncrypte.ClientRectangle.Height);
        }



    }
}
