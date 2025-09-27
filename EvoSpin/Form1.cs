using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoSpin {
    public partial class Form1 : Form {
        string item = "";
        string[] items = { "Dog", "Ball", "Honda Civic", "Cosmic Leviathan" };
        double[] weights = { 0.33, 0.33, 0.33, 0.01 };
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lblroll.Text = $"You got: {item}";
        }

        private void Lblroll_Click(object sender, EventArgs e) {
        }

        private void Roll_Click(object sender, EventArgs e) {
            double totalWeight = weights.Sum();
            double randomValue = new Random().NextDouble() * totalWeight;
            double cumulative = 0.0;
            int selectedIndex = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                cumulative += weights[i];
                if (randomValue < cumulative)
                {
                    selectedIndex = i;
                    break;
                }
            }
            item = items[selectedIndex];
            int chance = (int)(1 / weights[selectedIndex]);
            lblroll.Text = $"You got: {item} (1 in {chance})";
        }
    }
}
