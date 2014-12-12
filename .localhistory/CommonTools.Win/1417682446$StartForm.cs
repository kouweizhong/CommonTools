
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
                _old.Width -= 10;
                _old.Height -= 10;
                _old.Location = new Point(_old.Location.X + 5, _old.Location.Y + 5);
            }

            _old = p;
            p.Width += 10;
            p.Height += 10;
            p.Location = new Point(p.Location.X - 5, p.Location.Y - 5);
            p.BringToFront();
        }

        private void PicEncrypte_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (p == _old)
            {
                Pen pp = new Pen(Color.Red);
                e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.X + e.ClipRectangle.Width - 1, e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
            }
        }



    }
}
