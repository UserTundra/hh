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
    public partial class CommentVariantsOnPassigTasksChoose : Form
    {
        public CommentVariantsOnPassigTasksChoose(Tests parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private int id;

        private Tests parent;

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        private void CommentVariantsOnPassigTasksChoose_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet61.T09_view_comment_variants". При необходимости она может быть перемещена или удалена.
            this.t09_view_comment_variantsTableAdapter.Fill(this.bd_kidsDataSet61.T09_view_comment_variants);
        }

        private void T09_comment_variants_choose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T09_comment_variants_choose.CurrentRow.Cells[4].Value.ToString());
        }

        public int getID()
        {
            return id;
        }

        private void T09commentChoose_Click(object sender, EventArgs e)
        {
            parent.fillCV(getID());
            this.Close();
        }
    }
}
