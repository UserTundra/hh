using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class MethodicalMaterialBind : Form
    {
        public MethodicalMaterialBind()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        private void MethodicalMaterialBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet16.T02_tests". При необходимости она может быть перемещена или удалена.
            this.t02_testsTableAdapter.Fill(this.bd_kidsDataSet16.T02_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet15.R07_methodical_materials". При необходимости она может быть перемещена или удалена.
            this.r07_methodical_materialsTableAdapter.Fill(this.bd_kidsDataSet15.R07_methodical_materials);

        }

        private void R07addButton_Click(object sender, EventArgs e)
        {
            int testId = int.Parse(T02_name_test.SelectedValue.ToString());

            var row = bd.T02_tests.Where(x => x.id_test == testId).FirstOrDefault();
            if (row == null) return;

            row.id_method_material = int.Parse(R07toT02.CurrentRow.Cells[0].Value.ToString());

            bd.SaveChanges();

            MessageBox.Show("Добавлено!");
        }
    }
}
