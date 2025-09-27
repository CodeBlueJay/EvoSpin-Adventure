using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoSpin
{
    public partial class Form1 : Form
    {
        string item = "";
        string[] items = { "Dog", "Ball", "Honda Civic", "Cosmic Leviathan" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblroll.Text = $"You got:\n{item}";
        }

        private void Lblroll_Click(object sender, EventArgs e)
        {
            lblroll.Text = "test";
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            lblroll.Text = "hi";
        }
    }
}
