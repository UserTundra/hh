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

        private void MethodicalMaterialBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet16.T02_tests". При необходимости она может быть перемещена или удалена.
            this.t02_testsTableAdapter.Fill(this.bd_kidsDataSet16.T02_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet15.R07_methodical_materials". При необходимости она может быть перемещена или удалена.
            this.r07_methodical_materialsTableAdapter.Fill(this.bd_kidsDataSet15.R07_methodical_materials);

        }
    }
}
