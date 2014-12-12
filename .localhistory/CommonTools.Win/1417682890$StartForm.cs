
using System.Drawing;
using System.Windows.Forms;

namespace CommonTools.Win
{
    public partial class StartForm : BaseForm
    {

        private PictureBox _old;

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
            PictureBox p = (PictureBox)sender;
            if (p == _old) return;

            if (_old != null)
            {
                _old.Location = new Point(_old.Location.X, _old.Location.Y);
            }

            _old = p;
            p.Location = new Point(p.Location.X, p.Location.Y);
            p.BringToFront();
        }

        private void PicEncrypte_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pictureBoxRet1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);
            //g.Clear(this.BackColor);
            g.DrawRectangle(pen, pictureBoxRet1.ClientRectangle.X, pictureBoxRet1.ClientRectangle.Y,
                                       pictureBoxRet1.ClientRectangle.X + pictureBoxRet1.ClientRectangle.Width,
                                       pictureBoxRet1.ClientRectangle.Y + pictureBoxRet1.ClientRectangle.Height);
        }



    }
}
