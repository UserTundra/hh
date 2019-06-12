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
    public partial class Personalities : Form
    {
        public Personalities()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();



        private void Personalities_Load(object sender, EventArgs e)
        {
            UpdateDataGrids();
            UpdateComboboxes();

            study_class.Enabled = false;
            study_years.Enabled = false;

            //birth_date.Format = DateTimePickerFormat.Custom;
            //birth_date.CustomFormat = "dd.mm.yyyy";

            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            human_category.DropDownStyle = ComboBoxStyle.DropDownList;
            study_class.DropDownStyle = ComboBoxStyle.DropDownList;
            place_work_study.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void UpdateDataGrids()
        {
            var pupilsData = bd.T01_1_pupils;
            gridViewPupils.DataSource = pupilsData.ToList();

            var otherData = bd.T01_2_others;
            gridViewOthers.DataSource = otherData.ToList();
        }

        private void UpdateComboboxes()
        {
            var genderList = bd.R00_decode.Select(x => new { Key =x.name_decode, Value = x.code_decode }).ToList();
            gender.DataSource = genderList;
            gender.DisplayMember = "Key";
            gender.ValueMember = "Value";

            var categoryList = bd.R01_people_category.Select(x => new { Key = x.name_category, Value = x.code_category }).ToList();
            human_category.DataSource = categoryList;
            human_category.DisplayMember = "Key";
            human_category.ValueMember = "Value";

            var peopleClassList = bd.R02_pupils_classes.Select(x => new { Key = x.name_class, Value = x.code_class }).ToList();
            study_class.DataSource = peopleClassList;
            study_class.DisplayMember = "Key";
            study_class.ValueMember = "Value";

            var placeWorkStudy = bd.T10_organizations.Select(x => new { Key = x.short_name, Value = x.id_org }).ToList();
            place_work_study.DataSource = placeWorkStudy;
            place_work_study.DisplayMember = "Key";
            place_work_study.ValueMember = "Value";
            
            //human_kategory
        }

        private void loadStudyYears()
        {
            int classIdx = study_class.SelectedIndex + 1;

            var linq = (from i in bd.R02_pupils_classes
                        where i.code_class == classIdx
                        select new
                        {
                            f = i.study_years
                        });

            foreach (var item in linq)
            {
                study_years.Text = item.f;
            }


        }

        private void study_class_TextChanged(object sender, EventArgs e)
        {
            loadStudyYears();
        }

        private void human_category_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (human_category.SelectedValue.ToString() == "2")
                    {
                        study_class.Enabled = true;
                        study_years.Enabled = true;
                    }
                else
                    {
                        study_class.Enabled = false;
                        study_years.Enabled = false;
                    }
            }
            catch(Exception ee) {  }
            
        }

        private void T01addButton_Click(object sender, EventArgs e)
        {
            int codeClass = 0;
            if (human_category.SelectedValue.ToString() == "2")
                codeClass = int.Parse(study_class.SelectedValue.ToString());
            var person = new T01_personalities()
            {
                surname = surname.Text,
                name = name.Text,
                patronymic = patronymic.Text,
                date_birth = birth_date.Value.ToString("dd.MM.YYYY"),
                gender = (long)gender.SelectedValue,
                code_category = (long)human_category.SelectedValue,
                id_org = (long)place_work_study.SelectedValue,
                code_class = codeClass,
                login = login.Text,
                password = password.Text,
                date_updating = "null",
                note = note.Text == "" ? " " : note.Text
            };
            bd.T01_personalities.Add(person);
            bd.SaveChanges();
            UpdateDataGrids();
        }

        private void study_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
