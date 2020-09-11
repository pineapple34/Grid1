using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid1
{
    public partial class Grid1 : Form
    {
        public Grid1()
        {
            InitializeComponent();
        }

        private void BuildBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SizeTB.Text, out int n) && n >= 1)
            {
                dataGridView1.Visible = true;

                dataGridView1.ColumnCount = dataGridView1.RowCount = n;
                for (int i = 0; i < n; i++)
                    for (int k = 0; k < n; k++)
                        dataGridView1[i, k].Value = (i == k ? 1 : 0);
            }
            else MessageBox.Show("Ошибка входных данных");
        }
    }
}
