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
    public partial class magaznn : Form
    {
        
        public magaznn()
        {
            InitializeComponent();
        }

        private void лист1_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.лист1_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._44п_кляпнев_эгзDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44п_кляпнев_эгзDataSet2._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter2.Fill(this._44п_кляпнев_эгзDataSet2._Лист1_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44п_кляпнев_эгзDataSet1._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter1.Fill(this._44п_кляпнев_эгзDataSet1._Лист1_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44п_кляпнев_эгзDataSet._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter.Fill(this._44п_кляпнев_эгзDataSet._Лист1_);

        }
        
        private void обложкаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void обложкаLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            korzina korz = new korzina();
            korz.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            otv otv = new otv();
            otv.Show();
            
        }

        private void обложкаListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void обложкаLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void обложкаPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void обложкаLabel_Click_2(object sender, EventArgs e)
        {

        }
    }
}
