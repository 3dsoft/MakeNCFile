namespace MakeNCFile
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPanelClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtAddCmd = new System.Windows.Forms.TextBox();
            this.btnInsertCmd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(679, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "2";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "간격 :";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(735, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 34);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "GCode";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(816, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // btnPanelClear
            // 
            this.btnPanelClear.Location = new System.Drawing.Point(537, 9);
            this.btnPanelClear.Name = "btnPanelClear";
            this.btnPanelClear.Size = new System.Drawing.Size(75, 33);
            this.btnPanelClear.TabIndex = 9;
            this.btnPanelClear.Text = "Clear";
            this.btnPanelClear.UseVisualStyleBackColor = true;
            this.btnPanelClear.Click += new System.EventHandler(this.btnPanelClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(823, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(637, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 460);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // txtAddCmd
            // 
            this.txtAddCmd.Location = new System.Drawing.Point(637, 525);
            this.txtAddCmd.Name = "txtAddCmd";
            this.txtAddCmd.Size = new System.Drawing.Size(59, 21);
            this.txtAddCmd.TabIndex = 13;
            this.txtAddCmd.Text = "Z10";
            this.txtAddCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInsertCmd
            // 
            this.btnInsertCmd.Location = new System.Drawing.Point(703, 517);
            this.btnInsertCmd.Name = "btnInsertCmd";
            this.btnInsertCmd.Size = new System.Drawing.Size(54, 34);
            this.btnInsertCmd.TabIndex = 14;
            this.btnInsertCmd.Text = "Insert";
            this.btnInsertCmd.UseVisualStyleBackColor = true;
            this.btnInsertCmd.Click += new System.EventHandler(this.btnInsertCmd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(763, 517);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 563);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsertCmd);
            this.Controls.Add(this.txtAddCmd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPanelClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make NC File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btnPanelClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtAddCmd;
        private System.Windows.Forms.Button btnInsertCmd;
        private System.Windows.Forms.Button btnDelete;
    }
}

