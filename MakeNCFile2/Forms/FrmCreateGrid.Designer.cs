namespace MakeNCFile2.Forms
{
    partial class FrmCreateGrid
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSizeWidth = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rdMarkRectangle = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSizeHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdMarkCircle = new System.Windows.Forms.RadioButton();
            this.txtMarkGap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMarkGap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdMarkCircle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSizeHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdMarkRectangle);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtSizeWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size :";
            // 
            // txtSizeWidth
            // 
            this.txtSizeWidth.Location = new System.Drawing.Point(78, 62);
            this.txtSizeWidth.Name = "txtSizeWidth";
            this.txtSizeWidth.Size = new System.Drawing.Size(50, 21);
            this.txtSizeWidth.TabIndex = 1;
            this.txtSizeWidth.Text = "600";
            this.txtSizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(78, 190);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 35);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rdMarkRectangle
            // 
            this.rdMarkRectangle.AutoSize = true;
            this.rdMarkRectangle.Location = new System.Drawing.Point(78, 158);
            this.rdMarkRectangle.Name = "rdMarkRectangle";
            this.rdMarkRectangle.Size = new System.Drawing.Size(79, 16);
            this.rdMarkRectangle.TabIndex = 5;
            this.rdMarkRectangle.Text = "Rectangle";
            this.rdMarkRectangle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // txtSizeHeight
            // 
            this.txtSizeHeight.Location = new System.Drawing.Point(146, 62);
            this.txtSizeHeight.Name = "txtSizeHeight";
            this.txtSizeHeight.Size = new System.Drawing.Size(50, 21);
            this.txtSizeHeight.TabIndex = 2;
            this.txtSizeHeight.Text = "500";
            this.txtSizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 21);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mark :";
            // 
            // rdMarkCircle
            // 
            this.rdMarkCircle.AutoSize = true;
            this.rdMarkCircle.Checked = true;
            this.rdMarkCircle.Location = new System.Drawing.Point(78, 136);
            this.rdMarkCircle.Name = "rdMarkCircle";
            this.rdMarkCircle.Size = new System.Drawing.Size(56, 16);
            this.rdMarkCircle.TabIndex = 4;
            this.rdMarkCircle.TabStop = true;
            this.rdMarkCircle.Text = "Circle";
            this.rdMarkCircle.UseVisualStyleBackColor = true;
            // 
            // txtMarkGap
            // 
            this.txtMarkGap.Location = new System.Drawing.Point(78, 99);
            this.txtMarkGap.Name = "txtMarkGap";
            this.txtMarkGap.Size = new System.Drawing.Size(50, 21);
            this.txtMarkGap.TabIndex = 3;
            this.txtMarkGap.Text = "1";
            this.txtMarkGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gab :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "mm";
            // 
            // FrmCreateGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 277);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Grid";
            this.Load += new System.EventHandler(this.FrmCreateGrid_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSizeHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdMarkRectangle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSizeWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdMarkCircle;
        private System.Windows.Forms.TextBox txtMarkGap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}