namespace PROJECT_PAD_2022.forms
{
    partial class InsertCustomer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.storeRbt = new System.Windows.Forms.RadioButton();
            this.personRbt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.teritoryCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountIdTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 0;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(103, 236);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 1;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(227, 236);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(68, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(289, 36);
            this.title.TabIndex = 3;
            this.title.Text = "Add New Customer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.storeRbt);
            this.panel1.Controls.Add(this.personRbt);
            this.panel1.Location = new System.Drawing.Point(84, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 39);
            this.panel1.TabIndex = 4;
            // 
            // storeRbt
            // 
            this.storeRbt.AutoSize = true;
            this.storeRbt.Location = new System.Drawing.Point(143, 8);
            this.storeRbt.Name = "storeRbt";
            this.storeRbt.Size = new System.Drawing.Size(60, 20);
            this.storeRbt.TabIndex = 1;
            this.storeRbt.TabStop = true;
            this.storeRbt.Text = "Store";
            this.storeRbt.UseVisualStyleBackColor = true;
            // 
            // personRbt
            // 
            this.personRbt.AutoSize = true;
            this.personRbt.Location = new System.Drawing.Point(20, 8);
            this.personRbt.Name = "personRbt";
            this.personRbt.Size = new System.Drawing.Size(71, 20);
            this.personRbt.TabIndex = 0;
            this.personRbt.TabStop = true;
            this.personRbt.Text = "Person";
            this.personRbt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Store/Person ID";
            // 
            // teritoryCmb
            // 
            this.teritoryCmb.FormattingEnabled = true;
            this.teritoryCmb.Location = new System.Drawing.Point(188, 177);
            this.teritoryCmb.Name = "teritoryCmb";
            this.teritoryCmb.Size = new System.Drawing.Size(121, 24);
            this.teritoryCmb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Teritory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account ID";
            // 
            // accountIdTb
            // 
            this.accountIdTb.Location = new System.Drawing.Point(188, 207);
            this.accountIdTb.Name = "accountIdTb";
            this.accountIdTb.Size = new System.Drawing.Size(136, 22);
            this.accountIdTb.TabIndex = 9;
            // 
            // InsertCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 271);
            this.Controls.Add(this.accountIdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teritoryCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "InsertCustomer";
            this.Text = "InsertCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton storeRbt;
        private System.Windows.Forms.RadioButton personRbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teritoryCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountIdTb;
    }
}