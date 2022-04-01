
namespace Hospital
{
    partial class TechForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.projtestDataSet = new Hospital.projtestDataSet();
            this.techFormTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techFormTableTableAdapter = new Hospital.projtestDataSetTableAdapters.TechFormTableTableAdapter();
            this.tableAdapterManager = new Hospital.projtestDataSetTableAdapters.TableAdapterManager();
            this.techFormTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projtestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFormTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFormTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(118, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Technicians please go to your assigned rooms:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(303, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 74);
            this.button1.TabIndex = 12;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(487, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 74);
            this.button4.TabIndex = 11;
            this.button4.Text = "Calculate Vacation Days";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(120, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 74);
            this.button3.TabIndex = 10;
            this.button3.Text = "Calculate Salary";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // projtestDataSet
            // 
            this.projtestDataSet.DataSetName = "projtestDataSet";
            this.projtestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techFormTableBindingSource
            // 
            this.techFormTableBindingSource.DataMember = "TechFormTable";
            this.techFormTableBindingSource.DataSource = this.projtestDataSet;
            // 
            // techFormTableTableAdapter
            // 
            this.techFormTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorFormTable1TableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.NurseFormTableTableAdapter = null;
            this.tableAdapterManager.TechFormTableTableAdapter = this.techFormTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hospital.projtestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // techFormTableDataGridView
            // 
            this.techFormTableDataGridView.AllowUserToAddRows = false;
            this.techFormTableDataGridView.AllowUserToDeleteRows = false;
            this.techFormTableDataGridView.AllowUserToOrderColumns = true;
            this.techFormTableDataGridView.AllowUserToResizeColumns = false;
            this.techFormTableDataGridView.AllowUserToResizeRows = false;
            this.techFormTableDataGridView.AutoGenerateColumns = false;
            this.techFormTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.techFormTableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.techFormTableDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.techFormTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.techFormTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.techFormTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.techFormTableDataGridView.DataSource = this.techFormTableBindingSource;
            this.techFormTableDataGridView.Location = new System.Drawing.Point(122, 232);
            this.techFormTableDataGridView.Name = "techFormTableDataGridView";
            this.techFormTableDataGridView.Size = new System.Drawing.Size(561, 59);
            this.techFormTableDataGridView.TabIndex = 14;
            this.techFormTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.techFormTableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Technician Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Technician Name";
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
            // TechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.techFormTableDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TechForm";
            this.Text = "Technicians";
            this.Load += new System.EventHandler(this.TechForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projtestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFormTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techFormTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private projtestDataSet projtestDataSet;
        private System.Windows.Forms.BindingSource techFormTableBindingSource;
        private projtestDataSetTableAdapters.TechFormTableTableAdapter techFormTableTableAdapter;
        private projtestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView techFormTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}