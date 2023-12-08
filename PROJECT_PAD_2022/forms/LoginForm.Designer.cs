namespace PROJECT_PAD_2022
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(64, 162);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(448, 45);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOGIN HERE";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.loginButton_DragEnter);
            this.loginButton.DragLeave += new System.EventHandler(this.loginButton_DragLeave);
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(548, 50);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Employee Login Form";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(59, 123);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(106, 35);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email :";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(171, 127);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(341, 29);
            this.emailTextBox.TabIndex = 3;
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(19, 59);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(541, 42);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Aplikasi hanya disediakan untuk employee dengan department Production, Sales, Hum" +
    "anResources, dan Purchasing";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 225);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.loginButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label labelInfo;
    }
}

