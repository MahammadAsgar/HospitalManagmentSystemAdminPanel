namespace HospitalManagmentSystemAdminPanel
{
    partial class AdminForm4
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
            this.button1 = new System.Windows.Forms.Button();
            this.ageText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dutyText = new System.Windows.Forms.TextBox();
            this.exprienceText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Doctor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(337, 129);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(237, 27);
            this.ageText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Exprience";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dutyText
            // 
            this.dutyText.Location = new System.Drawing.Point(337, 179);
            this.dutyText.Name = "dutyText";
            this.dutyText.Size = new System.Drawing.Size(237, 27);
            this.dutyText.TabIndex = 7;
            // 
            // exprienceText
            // 
            this.exprienceText.Location = new System.Drawing.Point(337, 229);
            this.exprienceText.Name = "exprienceText";
            this.exprienceText.Size = new System.Drawing.Size(237, 27);
            this.exprienceText.TabIndex = 8;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(337, 79);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(237, 27);
            this.surnameText.TabIndex = 9;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(337, 26);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(237, 27);
            this.nameText.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.exprienceText);
            this.Controls.Add(this.dutyText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dutyText;
        private System.Windows.Forms.TextBox exprienceText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox nameText;
    }
}