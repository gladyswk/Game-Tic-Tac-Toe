using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjectTicTacToe
{
    public partial class Opening : Form
    {
        public Opening()
        {
            Thread splash = new Thread(new ThreadStart(SplashStart));
            splash.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            splash.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new SplashSc());
        }
        private void Opening_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu baru = new MainMenu();
            this.Hide();
            baru.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
