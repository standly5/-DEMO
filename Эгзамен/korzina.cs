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
    public partial class korzina : Form
    {
        public korzina()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vozvrat_Click(object sender, EventArgs e)
        {
            magaznn mag = new magaznn();
            mag.Show();
            Hide();
        }

        private void korzina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44п_кляпнев_эгзDataSet2._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter.Fill(this._44п_кляпнев_эгзDataSet2._Лист1_);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
