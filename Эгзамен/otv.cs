using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Эгзамен
{
    public partial class otv : Form
    {
        public otv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            magaznn mag = new magaznn();
            
            Hide();
        }
    }
}
