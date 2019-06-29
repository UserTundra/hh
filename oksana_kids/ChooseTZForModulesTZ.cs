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
    public partial class ChooseTZForModulesTZ : Form
    {
        public ChooseTZForModulesTZ(Tests parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private int id;
        private string name;

        private Tests parent;

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        private void ChooseTZForModulesTZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet59.T04_view_testing_tasks". При необходимости она может быть перемещена или удалена.
            this.t04_view_testing_tasksTableAdapter.Fill(this.bd_kidsDataSet59.T04_view_testing_tasks);

        }

        private void T04_choose_TZ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T04_choose_TZ.CurrentRow.Cells[0].Value.ToString());

            var data = (from c in bd.T04_testing_tasks
                        where c.id_task == id
                        select c.name_task).FirstOrDefault();

            if (data == null) return;

            name = data.ToString();
            nameTZ.Clear();
            nameTZ.Text = data.ToString();
        }

        public int getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        private void chooseTZ_Click(object sender, EventArgs e)
        {
            parent.fillTZ(getID(), getName());
            this.Close();
        }
    }
}
