using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(CountRows);
            dataGridViewStudents.DataSource =
                Connector.Select(
                    "last_name,first_name,middle_name,birth_date,group_name,direction_name",
                    "Students,Groups,Directions",
                    "[group]=group_id AND direction = direction_id");
            LoadStudents();

        }
        void CountRows(object sender, EventArgs e)
        {
            toolStripStatusLabelStudentsCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount}.";
        }
        private void LoadStudents()
        {        
                dataGridViewStudents.DataSource = Connector.SelectWithAge(
                "last_name, first_name, middle_name, birth_date, group_name, direction_name",
                "Students JOIN Groups ON [group] = group_id JOIN Directions ON direction = direction_id"
            );
             dataGridViewStudents.AutoGenerateColumns = true;
        }

        private void SearchStudents_TextChanged(object sender, EventArgs e)
        {
             string searchText = SearchStudents.Text.Trim(); 
            
            if (string.IsNullOrEmpty(searchText))
            {
                dataGridViewStudents.DataSource = Connector.Select(
                    "last_name, first_name, middle_name, birth_date, group_name, direction_name",
                    "Students JOIN Groups ON [group] = group_id JOIN Directions ON direction = direction_id"
                );
            }
            else
            {
      
                string lowerSearchText = searchText.ToLower();
                string condition = $@"
            (LOWER(last_name) LIKE '%{lowerSearchText}%' OR
            LOWER(first_name) LIKE '%{lowerSearchText}%' OR
            LOWER(middle_name) LIKE '%{lowerSearchText}%')
        ";

                dataGridViewStudents.DataSource = Connector.Select(
                    "last_name, first_name, middle_name, birth_date, group_name, direction_name",
                    "Students JOIN Groups ON [group] = group_id JOIN Directions ON direction = direction_id",
                    condition
                );
            }
        }
    }
}

