namespace DRY.WinForms
{
    partial class EmployeeInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateEmployeeID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(158, 35);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(333, 32);
            this.tboxFirstName.TabIndex = 1;
            // 
            // tboxLastName
            // 
            this.tboxLastName.Location = new System.Drawing.Point(158, 103);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(333, 32);
            this.tboxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // tboxEmployeeID
            // 
            this.tboxEmployeeID.Location = new System.Drawing.Point(158, 242);
            this.tboxEmployeeID.Name = "tboxEmployeeID";
            this.tboxEmployeeID.ReadOnly = true;
            this.tboxEmployeeID.Size = new System.Drawing.Size(333, 32);
            this.tboxEmployeeID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee ID";
            // 
            // btnGenerateEmployeeID
            // 
            this.btnGenerateEmployeeID.Location = new System.Drawing.Point(158, 162);
            this.btnGenerateEmployeeID.Name = "btnGenerateEmployeeID";
            this.btnGenerateEmployeeID.Size = new System.Drawing.Size(333, 42);
            this.btnGenerateEmployeeID.TabIndex = 6;
            this.btnGenerateEmployeeID.Text = "Generate Employee Id";
            this.btnGenerateEmployeeID.UseVisualStyleBackColor = true;
            this.btnGenerateEmployeeID.Click += new System.EventHandler(this.BtnGenerateEmployeeID_Click);
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 329);
            this.Controls.Add(this.btnGenerateEmployeeID);
            this.Controls.Add(this.tboxEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeInfo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.Button btnGenerateEmployeeID;
    }
}

