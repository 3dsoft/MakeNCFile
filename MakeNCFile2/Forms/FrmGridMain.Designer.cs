namespace MakeNCFile2.Forms
{
    partial class FrmGridMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarkGap = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdMarkCircle = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSizeHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdMarkRectangle = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtSizeWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConvertToNCFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdLeftTop = new System.Windows.Forms.RadioButton();
            this.rdLeftBottom = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSaveToNCFile = new System.Windows.Forms.Button();
            this.btnGridUP = new System.Windows.Forms.Button();
            this.btnGridDown = new System.Windows.Forms.Button();
            this.btnGridLeft = new System.Windows.Forms.Button();
            this.btnGridRight = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(418, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(271, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(263, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Set";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGridRight);
            this.groupBox2.Controls.Add(this.btnGridLeft);
            this.groupBox2.Controls.Add(this.btnGridDown);
            this.groupBox2.Controls.Add(this.btnGridUP);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(9, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.txtSizeWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMarkGap
            // 
            this.txtMarkGap.Location = new System.Drawing.Point(67, 99);
            this.txtMarkGap.Name = "txtMarkGap";
            this.txtMarkGap.Size = new System.Drawing.Size(50, 21);
            this.txtMarkGap.TabIndex = 3;
            this.txtMarkGap.Text = "1";
            this.txtMarkGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 419);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 16);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gab :";
            // 
            // rdMarkCircle
            // 
            this.rdMarkCircle.AutoSize = true;
            this.rdMarkCircle.Checked = true;
            this.rdMarkCircle.Location = new System.Drawing.Point(67, 136);
            this.rdMarkCircle.Name = "rdMarkCircle";
            this.rdMarkCircle.Size = new System.Drawing.Size(56, 16);
            this.rdMarkCircle.TabIndex = 4;
            this.rdMarkCircle.TabStop = true;
            this.rdMarkCircle.Text = "Circle";
            this.rdMarkCircle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mark :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 21);
            this.txtName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name :";
            // 
            // txtSizeHeight
            // 
            this.txtSizeHeight.Location = new System.Drawing.Point(135, 62);
            this.txtSizeHeight.Name = "txtSizeHeight";
            this.txtSizeHeight.ReadOnly = true;
            this.txtSizeHeight.Size = new System.Drawing.Size(50, 21);
            this.txtSizeHeight.TabIndex = 2;
            this.txtSizeHeight.Text = "30";
            this.txtSizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // rdMarkRectangle
            // 
            this.rdMarkRectangle.AutoSize = true;
            this.rdMarkRectangle.Location = new System.Drawing.Point(67, 158);
            this.rdMarkRectangle.Name = "rdMarkRectangle";
            this.rdMarkRectangle.Size = new System.Drawing.Size(79, 16);
            this.rdMarkRectangle.TabIndex = 5;
            this.rdMarkRectangle.Text = "Rectangle";
            this.rdMarkRectangle.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(67, 186);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(118, 35);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtSizeWidth
            // 
            this.txtSizeWidth.Location = new System.Drawing.Point(67, 62);
            this.txtSizeWidth.Name = "txtSizeWidth";
            this.txtSizeWidth.ReadOnly = true;
            this.txtSizeWidth.Size = new System.Drawing.Size(50, 21);
            this.txtSizeWidth.TabIndex = 1;
            this.txtSizeWidth.Text = "30";
            this.txtSizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveToNCFile);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnConvertToNCFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NC Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConvertToNCFile
            // 
            this.btnConvertToNCFile.Location = new System.Drawing.Point(9, 339);
            this.btnConvertToNCFile.Name = "btnConvertToNCFile";
            this.btnConvertToNCFile.Size = new System.Drawing.Size(134, 32);
            this.btnConvertToNCFile.TabIndex = 1;
            this.btnConvertToNCFile.Text = "Convert to NC Code";
            this.btnConvertToNCFile.UseVisualStyleBackColor = true;
            this.btnConvertToNCFile.Click += new System.EventHandler(this.btnSaveToNCFile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(34, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 26);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Grid Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Grid Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "S파일|*.s";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "S파일|*.s";
            this.saveFileDialog1.Title = "S 파일";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdLeftBottom);
            this.groupBox3.Controls.Add(this.rdLeftTop);
            this.groupBox3.Location = new System.Drawing.Point(6, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 46);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Origin Position";
            // 
            // rdLeftTop
            // 
            this.rdLeftTop.AutoSize = true;
            this.rdLeftTop.Location = new System.Drawing.Point(23, 20);
            this.rdLeftTop.Name = "rdLeftTop";
            this.rdLeftTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdLeftTop.Size = new System.Drawing.Size(71, 16);
            this.rdLeftTop.TabIndex = 0;
            this.rdLeftTop.Text = "Left-Top";
            this.rdLeftTop.UseVisualStyleBackColor = true;
            // 
            // rdLeftBottom
            // 
            this.rdLeftBottom.AutoSize = true;
            this.rdLeftBottom.Checked = true;
            this.rdLeftBottom.Location = new System.Drawing.Point(138, 20);
            this.rdLeftBottom.Name = "rdLeftBottom";
            this.rdLeftBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdLeftBottom.Size = new System.Drawing.Size(88, 16);
            this.rdLeftBottom.TabIndex = 1;
            this.rdLeftBottom.TabStop = true;
            this.rdLeftBottom.Text = "Left-Bottom";
            this.rdLeftBottom.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 268);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSaveToNCFile
            // 
            this.btnSaveToNCFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToNCFile.Location = new System.Drawing.Point(149, 339);
            this.btnSaveToNCFile.Name = "btnSaveToNCFile";
            this.btnSaveToNCFile.Size = new System.Drawing.Size(108, 32);
            this.btnSaveToNCFile.TabIndex = 2;
            this.btnSaveToNCFile.Text = "Save to NC File";
            this.btnSaveToNCFile.UseVisualStyleBackColor = true;
            this.btnSaveToNCFile.Click += new System.EventHandler(this.btnSaveToNCFile_Click_1);
            // 
            // btnGridUP
            // 
            this.btnGridUP.Location = new System.Drawing.Point(95, 18);
            this.btnGridUP.Name = "btnGridUP";
            this.btnGridUP.Size = new System.Drawing.Size(55, 26);
            this.btnGridUP.TabIndex = 0;
            this.btnGridUP.Text = "UP";
            this.btnGridUP.UseVisualStyleBackColor = true;
            this.btnGridUP.Click += new System.EventHandler(this.btnGridControl_Click);
            // 
            // btnGridDown
            // 
            this.btnGridDown.Location = new System.Drawing.Point(96, 54);
            this.btnGridDown.Name = "btnGridDown";
            this.btnGridDown.Size = new System.Drawing.Size(55, 26);
            this.btnGridDown.TabIndex = 3;
            this.btnGridDown.Text = "DOWN";
            this.btnGridDown.UseVisualStyleBackColor = true;
            this.btnGridDown.Click += new System.EventHandler(this.btnGridControl_Click);
            // 
            // btnGridLeft
            // 
            this.btnGridLeft.Location = new System.Drawing.Point(35, 35);
            this.btnGridLeft.Name = "btnGridLeft";
            this.btnGridLeft.Size = new System.Drawing.Size(55, 26);
            this.btnGridLeft.TabIndex = 1;
            this.btnGridLeft.Text = "LEFT";
            this.btnGridLeft.UseVisualStyleBackColor = true;
            this.btnGridLeft.Click += new System.EventHandler(this.btnGridControl_Click);
            // 
            // btnGridRight
            // 
            this.btnGridRight.Location = new System.Drawing.Point(156, 35);
            this.btnGridRight.Name = "btnGridRight";
            this.btnGridRight.Size = new System.Drawing.Size(55, 26);
            this.btnGridRight.TabIndex = 2;
            this.btnGridRight.Text = "RIGHT";
            this.btnGridRight.UseVisualStyleBackColor = true;
            this.btnGridRight.Click += new System.EventHandler(this.btnGridControl_Click);
            // 
            // FrmGridMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGridMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid Main";
            this.Load += new System.EventHandler(this.FrmGridMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMarkGap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdMarkCircle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSizeHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdMarkRectangle;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtSizeWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvertToNCFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdLeftBottom;
        private System.Windows.Forms.RadioButton rdLeftTop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSaveToNCFile;
        private System.Windows.Forms.Button btnGridUP;
        private System.Windows.Forms.Button btnGridRight;
        private System.Windows.Forms.Button btnGridLeft;
        private System.Windows.Forms.Button btnGridDown;
    }
}