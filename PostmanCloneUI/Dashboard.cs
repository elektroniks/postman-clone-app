using System.Runtime.InteropServices;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public void ShowFormOnContentPanel(object formUI)
        {
            if (this.ContentPanel.Controls.Count > 0)
            {
                this.ContentPanel.Controls.Clear();
                //this.ContentPanel.Controls.RemoveAt(0);
            }

            Form form = formUI as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.ContentPanel.Controls.Add(form);
            this.ContentPanel.Tag = form;
            form.Show();

        }


        private void buttonSlide_Click(object sender, EventArgs e)
        {
            if (MenuPanel.Width == 200)
            {
                MenuPanel.Width = 50;
            }
            else
            {
                MenuPanel.Width = 200;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void testButton_Click(object sender, EventArgs e)
        {
            this.ShowFormOnContentPanel(new TestAPI());
        }
    }
}
