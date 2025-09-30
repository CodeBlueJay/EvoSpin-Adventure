using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using EvoSpin.Spinnables;

namespace EvoSpin {
    public partial class Form1 : Form {
        private items _items = new items();
        private List<string> item;
        private List<double> weights;

        public Form1() {
            InitializeComponent();
            item = _items.spinnables.Select(i => i.item).ToList();
            weights = _items.spinnables.Select(i => i.weight).ToList();
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
            for (int i = 0; i < weights.Count; i++)
            {
                cumulative += weights[i];
                if (randomValue < cumulative)
                {
                    selectedIndex = i;
                    break;
                }
            }
            string selectedItem = item[selectedIndex];
            int chance = (int)(1 / weights[selectedIndex]);
            lblroll.Text = $"You got: {selectedItem} (1 in {chance})";
        }
    }
}
