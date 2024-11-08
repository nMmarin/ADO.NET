
namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.TabPageStudents = new System.Windows.Forms.TabPage();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.TabPageGroups = new System.Windows.Forms.TabPage();
			this.TabPageDisciplines = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.toolStripStatusLabelStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.SearchStudents = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
			this.labelStudentsGroup = new System.Windows.Forms.Label();
			this.labelStudentsDirection = new System.Windows.Forms.Label();
			this.StudentsDirection = new System.Windows.Forms.ComboBox();
			this.tabControlMain.SuspendLayout();
			this.TabPageStudents.SuspendLayout();
			this.statusStripStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.TabPageStudents);
			this.tabControlMain.Controls.Add(this.TabPageGroups);
			this.tabControlMain.Controls.Add(this.TabPageDisciplines);
			this.tabControlMain.Controls.Add(this.tabPageTeachers);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(965, 573);
			this.tabControlMain.TabIndex = 0;
			// 
			// TabPageStudents
			// 
			this.TabPageStudents.Controls.Add(this.StudentsDirection);
			this.TabPageStudents.Controls.Add(this.labelStudentsDirection);
			this.TabPageStudents.Controls.Add(this.labelStudentsGroup);
			this.TabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
			this.TabPageStudents.Controls.Add(this.labelSearch);
			this.TabPageStudents.Controls.Add(this.SearchStudents);
			this.TabPageStudents.Controls.Add(this.statusStripStudents);
			this.TabPageStudents.Controls.Add(this.dataGridViewStudents);
			this.TabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.TabPageStudents.Name = "TabPageStudents";
			this.TabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageStudents.Size = new System.Drawing.Size(957, 547);
			this.TabPageStudents.TabIndex = 0;
			this.TabPageStudents.Text = "Students";
			this.TabPageStudents.UseVisualStyleBackColor = true;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudentsCount});
			this.statusStripStudents.Location = new System.Drawing.Point(3, 522);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(951, 22);
			this.statusStripStudents.TabIndex = 1;
			this.statusStripStudents.Text = "statusStrip1";
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(3, 67);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(951, 425);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// TabPageGroups
			// 
			this.TabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.TabPageGroups.Name = "TabPageGroups";
			this.TabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageGroups.Size = new System.Drawing.Size(957, 547);
			this.TabPageGroups.TabIndex = 1;
			this.TabPageGroups.Text = "Groups";
			this.TabPageGroups.UseVisualStyleBackColor = true;
			// 
			// TabPageDisciplines
			// 
			this.TabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.TabPageDisciplines.Name = "TabPageDisciplines";
			this.TabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageDisciplines.Size = new System.Drawing.Size(957, 547);
			this.TabPageDisciplines.TabIndex = 2;
			this.TabPageDisciplines.Text = "Disciplines";
			this.TabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Size = new System.Drawing.Size(957, 547);
			this.tabPageTeachers.TabIndex = 3;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// toolStripStatusLabelStudentsCount
			// 
			this.toolStripStatusLabelStudentsCount.Name = "toolStripStatusLabelStudentsCount";
			this.toolStripStatusLabelStudentsCount.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabelStudentsCount.Text = "toolStripStatusLabel1";
			// 
			// SearchStudents
			// 
			this.SearchStudents.Location = new System.Drawing.Point(52, 17);
			this.SearchStudents.Name = "SearchStudents";
			this.SearchStudents.Size = new System.Drawing.Size(273, 20);
			this.SearchStudents.TabIndex = 2;
			// 
			// labelSearch
			// 
			this.labelSearch.AutoSize = true;
			this.labelSearch.Location = new System.Drawing.Point(7, 21);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(39, 13);
			this.labelSearch.TabIndex = 3;
			this.labelSearch.Text = "Поиск";
			//this.labelSearch.Click += new System.EventHandler(this.label1_Click);
			// 
			// comboBoxStudentsGroup
			// 
			this.comboBoxStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxStudentsGroup.FormattingEnabled = true;
			this.comboBoxStudentsGroup.Location = new System.Drawing.Point(388, 17);
			this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
			this.comboBoxStudentsGroup.Size = new System.Drawing.Size(121, 21);
			this.comboBoxStudentsGroup.TabIndex = 4;
			// 
			// labelStudentsGroup
			// 
			this.labelStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStudentsGroup.AutoSize = true;
			this.labelStudentsGroup.Location = new System.Drawing.Point(340, 21);
			this.labelStudentsGroup.Name = "labelStudentsGroup";
			this.labelStudentsGroup.Size = new System.Drawing.Size(42, 13);
			this.labelStudentsGroup.TabIndex = 5;
			this.labelStudentsGroup.Text = "Группа";
			// 
			// labelStudentsDirection
			// 
			this.labelStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStudentsDirection.AutoSize = true;
			this.labelStudentsDirection.Location = new System.Drawing.Point(529, 21);
			this.labelStudentsDirection.Name = "labelStudentsDirection";
			this.labelStudentsDirection.Size = new System.Drawing.Size(124, 13);
			this.labelStudentsDirection.TabIndex = 6;
			this.labelStudentsDirection.Text = "Направление обучения";
			// 
			// StudentsDirection
			// 
			this.StudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentsDirection.FormattingEnabled = true;
			this.StudentsDirection.Location = new System.Drawing.Point(659, 17);
			this.StudentsDirection.Name = "StudentsDirection";
			this.StudentsDirection.Size = new System.Drawing.Size(121, 21);
			this.StudentsDirection.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 573);
			this.Controls.Add(this.tabControlMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Academy";
			this.tabControlMain.ResumeLayout(false);
			this.TabPageStudents.ResumeLayout(false);
			this.TabPageStudents.PerformLayout();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage TabPageStudents;
		private System.Windows.Forms.TabPage TabPageGroups;
		private System.Windows.Forms.TabPage TabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.StatusStrip statusStripStudents;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudentsCount;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.TextBox SearchStudents;
		private System.Windows.Forms.ComboBox StudentsDirection;
		private System.Windows.Forms.Label labelStudentsDirection;
		private System.Windows.Forms.Label labelStudentsGroup;
		private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
	}
}

