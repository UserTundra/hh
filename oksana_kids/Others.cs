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
    public partial class Others : Form
    {
        public int tabIndex;

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        public Others(int index)
        {
            tabIndex = index;
            InitializeComponent();
        }

        private void Others_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet69.R14_track_types". При необходимости она может быть перемещена или удалена.
            this.r14_track_typesTableAdapter.Fill(this.bd_kidsDataSet69.R14_track_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet68.T09_view_comment_variants". При необходимости она может быть перемещена или удалена.
            this.t09_view_comment_variantsTableAdapter.Fill(this.bd_kidsDataSet68.T09_view_comment_variants);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet67.R13_play_result_variants". При необходимости она может быть перемещена или удалена.
            this.r13_play_result_variantsTableAdapter.Fill(this.bd_kidsDataSet67.R13_play_result_variants);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet66.T10_view_organizations". При необходимости она может быть перемещена или удалена.
            this.t10_view_organizationsTableAdapter.Fill(this.bd_kidsDataSet66.T10_view_organizations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet65.R05_legal_ownership_forms". При необходимости она может быть перемещена или удалена.
            this.r05_legal_ownership_formsTableAdapter.Fill(this.bd_kidsDataSet65.R05_legal_ownership_forms);
            tabControl1.SelectTab(tabIndex);
        }

    }
}
