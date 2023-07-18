using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Title.Parent = pinkbackground;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Hide();

            SoundPlayer sp = new SoundPlayer(@"ezgif.com-crop.wav");
            sp.Play();
            await Task.Delay(7100);
            this.Hide();
            form2.Show();

        }
    }
}
