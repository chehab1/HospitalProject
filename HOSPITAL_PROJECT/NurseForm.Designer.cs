
namespace Hospital
{
    partial class NurseForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseForm));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projtestDataSet = new Hospital.projtestDataSet();
            this.nurseFormTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseFormTableTableAdapter = new Hospital.projtestDataSetTableAdapters.NurseFormTableTableAdapter();
            this.tableAdapterManager = new Hospital.projtestDataSetTableAdapters.TableAdapterManager();
            this.nurseFormTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projtestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseFormTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseFormTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(457, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 61);
            this.button4.TabIndex = 6;
            this.button4.Text = "calculate Vacation Days";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(83, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "Calculate Salary";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(270, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(79, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nurses please go to your assigned rooms :";
            // 
            // projtestDataSet
            // 
            this.projtestDataSet.DataSetName = "projtestDataSet";
            this.projtestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseFormTableBindingSource
            // 
            this.nurseFormTableBindingSource.DataMember = "NurseFormTable";
            this.nurseFormTableBindingSource.DataSource = this.projtestDataSet;
            // 
            // nurseFormTableTableAdapter
            // 
            this.nurseFormTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorFormTable1TableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.NurseFormTableTableAdapter = this.nurseFormTableTableAdapter;
            this.tableAdapterManager.TechFormTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.projtestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nurseFormTableDataGridView
            // 
            this.nurseFormTableDataGridView.AllowUserToAddRows = false;
            this.nurseFormTableDataGridView.AllowUserToDeleteRows = false;
            this.nurseFormTableDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.nurseFormTableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.nurseFormTableDataGridView.AutoGenerateColumns = false;
            this.nurseFormTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nurseFormTableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nurseFormTableDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.nurseFormTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nurseFormTableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.nurseFormTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseFormTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nurseFormTableDataGridView.DataSource = this.nurseFormTableBindingSource;
            this.nurseFormTableDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.nurseFormTableDataGridView.Location = new System.Drawing.Point(83, 224);
            this.nurseFormTableDataGridView.Name = "nurseFormTableDataGridView";
            this.nurseFormTableDataGridView.Size = new System.Drawing.Size(555, 47);
            this.nurseFormTableDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nurse name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nurse name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Task";
            this.dataGridViewTextBoxColumn3.HeaderText = "Task";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 477);
            this.Controls.Add(this.nurseFormTableDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NurseForm";
            this.Text = "Nurses";
            this.Load += new System.EventHandler(this.NurseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projtestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseFormTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseFormTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private projtestDataSet projtestDataSet;
        private System.Windows.Forms.BindingSource nurseFormTableBindingSource;
        private projtestDataSetTableAdapters.NurseFormTableTableAdapter nurseFormTableTableAdapter;
        private projtestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nurseFormTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}