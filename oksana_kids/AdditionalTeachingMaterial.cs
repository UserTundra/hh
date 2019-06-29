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
    public partial class AdditionalTeachingMaterial : Form
    {
        public AdditionalTeachingMaterial(Tests parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        private int id;
        private string name;

        private Tests parent;

        private void AdditionalTeachingMaterial_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet52.T06_view_teaching_materials". При необходимости она может быть перемещена или удалена.
            this.t06_view_teaching_materialsTableAdapter.Fill(this.bd_kidsDataSet52.T06_view_teaching_materials);

        }

        private void additionalTM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(additionalTM.CurrentRow.Cells[0].Value.ToString());

            var data = (from c in bd.T06_teaching_materials
                       where c.id_teach_material == id
                       select c.description).FirstOrDefault();

            if (data == null) return;
            
            name = data.ToString();
            nameTM.Clear();
            nameTM.Text = data.ToString();

        }

        public int getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        private void chooseTeachingMaterial_Click(object sender, EventArgs e)
        {
            parent.fillATM(getID(), getName());
            this.Close();
        }
    }
}
