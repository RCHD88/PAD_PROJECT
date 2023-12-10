namespace PROJECT_PAD_2022.forms
{
    partial class HumanResourceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.activeTab = new System.Windows.Forms.TabPage();
            this.allButton = new System.Windows.Forms.Button();
            this.sorttypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentlabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTextTotal = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inactiveTab = new System.Windows.Forms.TabPage();
            this.inactiveTotalEmployee = new System.Windows.Forms.Label();
            this.inactivetotalLabel = new System.Windows.Forms.Label();
            this.inactiveDataGridView = new System.Windows.Forms.DataGridView();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.logoutButton = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.activeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.inactiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveDataGridView)).BeginInit();
            this.reportTab.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.activeTab);
            this.tabControl.Controls.Add(this.inactiveTab);
            this.tabControl.Controls.Add(this.reportTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1116, 513);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // activeTab
            // 
            this.activeTab.Controls.Add(this.allButton);
            this.activeTab.Controls.Add(this.sorttypeComboBox);
            this.activeTab.Controls.Add(this.label3);
            this.activeTab.Controls.Add(this.sortComboBox);
            this.activeTab.Controls.Add(this.label2);
            this.activeTab.Controls.Add(this.departmentComboBox);
            this.activeTab.Controls.Add(this.departmentlabel);
            this.activeTab.Controls.Add(this.generateButton);
            this.activeTab.Controls.Add(this.labelTotal);
            this.activeTab.Controls.Add(this.labelTextTotal);
            this.activeTab.Controls.Add(this.dataGridView);
            this.activeTab.Location = new System.Drawing.Point(4, 24);
            this.activeTab.Name = "activeTab";
            this.activeTab.Padding = new System.Windows.Forms.Padding(3);
            this.activeTab.Size = new System.Drawing.Size(1108, 485);
            this.activeTab.TabIndex = 0;
            this.activeTab.Text = "Active Employee";
            this.activeTab.UseVisualStyleBackColor = true;
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(984, 6);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(118, 23);
            this.allButton.TabIndex = 10;
            this.allButton.Text = "View All";
            this.allButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // sorttypeComboBox
            // 
            this.sorttypeComboBox.FormattingEnabled = true;
            this.sorttypeComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sorttypeComboBox.Location = new System.Drawing.Point(722, 6);
            this.sorttypeComboBox.Name = "sorttypeComboBox";
            this.sorttypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.sorttypeComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort Type :";
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "HireDate",
            "VacationHours",
            "SickHours"});
            this.sortComboBox.Location = new System.Drawing.Point(513, 6);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 23);
            this.sortComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sort By :";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(314, 6);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 23);
            this.departmentComboBox.TabIndex = 5;
            // 
            // departmentlabel
            // 
            this.departmentlabel.AutoSize = true;
            this.departmentlabel.Location = new System.Drawing.Point(230, 9);
            this.departmentlabel.Name = "departmentlabel";
            this.departmentlabel.Size = new System.Drawing.Size(78, 15);
            this.departmentlabel.TabIndex = 4;
            this.departmentlabel.Text = "Department :";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(860, 6);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(118, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate View";
            this.generateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(132, 11);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(21, 13);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "10";
            // 
            // labelTextTotal
            // 
            this.labelTextTotal.AutoSize = true;
            this.labelTextTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotal.Location = new System.Drawing.Point(6, 11);
            this.labelTextTotal.Name = "labelTextTotal";
            this.labelTextTotal.Size = new System.Drawing.Size(129, 13);
            this.labelTextTotal.TabIndex = 1;
            this.labelTextTotal.Text = "TOTAL EMPLOYEE : ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(7, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1095, 444);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // inactiveTab
            // 
            this.inactiveTab.Controls.Add(this.inactiveTotalEmployee);
            this.inactiveTab.Controls.Add(this.inactivetotalLabel);
            this.inactiveTab.Controls.Add(this.inactiveDataGridView);
            this.inactiveTab.Location = new System.Drawing.Point(4, 24);
            this.inactiveTab.Name = "inactiveTab";
            this.inactiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.inactiveTab.Size = new System.Drawing.Size(1108, 485);
            this.inactiveTab.TabIndex = 1;
            this.inactiveTab.Text = "Inactive Employee";
            this.inactiveTab.UseVisualStyleBackColor = true;
            // 
            // inactiveTotalEmployee
            // 
            this.inactiveTotalEmployee.AutoSize = true;
            this.inactiveTotalEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveTotalEmployee.Location = new System.Drawing.Point(132, 11);
            this.inactiveTotalEmployee.Name = "inactiveTotalEmployee";
            this.inactiveTotalEmployee.Size = new System.Drawing.Size(21, 13);
            this.inactiveTotalEmployee.TabIndex = 5;
            this.inactiveTotalEmployee.Text = "10";
            // 
            // inactivetotalLabel
            // 
            this.inactivetotalLabel.AutoSize = true;
            this.inactivetotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivetotalLabel.Location = new System.Drawing.Point(6, 11);
            this.inactivetotalLabel.Name = "inactivetotalLabel";
            this.inactivetotalLabel.Size = new System.Drawing.Size(129, 13);
            this.inactivetotalLabel.TabIndex = 4;
            this.inactivetotalLabel.Text = "TOTAL EMPLOYEE : ";
            // 
            // inactiveDataGridView
            // 
            this.inactiveDataGridView.AllowUserToAddRows = false;
            this.inactiveDataGridView.AllowUserToDeleteRows = false;
            this.inactiveDataGridView.AllowUserToResizeColumns = false;
            this.inactiveDataGridView.AllowUserToResizeRows = false;
            this.inactiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inactiveDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inactiveDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.inactiveDataGridView.Location = new System.Drawing.Point(7, 35);
            this.inactiveDataGridView.Name = "inactiveDataGridView";
            this.inactiveDataGridView.ReadOnly = true;
            this.inactiveDataGridView.RowHeadersVisible = false;
            this.inactiveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inactiveDataGridView.Size = new System.Drawing.Size(1095, 444);
            this.inactiveDataGridView.TabIndex = 3;
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.printButton);
            this.reportTab.Controls.Add(this.generateReportButton);
            this.reportTab.Controls.Add(this.crystalReportViewer);
            this.reportTab.Location = new System.Drawing.Point(4, 24);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(1108, 485);
            this.reportTab.TabIndex = 2;
            this.reportTab.Text = "Report";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Human Resource Form";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(173, 17);
            this.toolStripStatusLabel1.Text = "HUMAN RESOURCE EMPLOYEE";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 569);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1140, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutButton.Location = new System.Drawing.Point(1031, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(87, 26);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "LOG OUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(7, 42);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1095, 437);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(7, 7);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(173, 29);
            this.generateReportButton.TabIndex = 1;
            this.generateReportButton.Text = "Generate Global Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(186, 6);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(173, 29);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print Report";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // HumanResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1140, 591);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HumanResourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource";
            this.Load += new System.EventHandler(this.HumanResourceForm_Load);
            this.tabControl.ResumeLayout(false);
            this.activeTab.ResumeLayout(false);
            this.activeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.inactiveTab.ResumeLayout(false);
            this.inactiveTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveDataGridView)).EndInit();
            this.reportTab.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage activeTab;
        private System.Windows.Forms.TabPage inactiveTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTextTotal;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label inactiveTotalEmployee;
        private System.Windows.Forms.Label inactivetotalLabel;
        private System.Windows.Forms.DataGridView inactiveDataGridView;
        private System.Windows.Forms.ComboBox sorttypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label departmentlabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button generateReportButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}