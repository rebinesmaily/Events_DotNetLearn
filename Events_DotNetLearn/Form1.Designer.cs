namespace Events_DotNetLearn
{
    partial class Form1
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
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1, 104);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(283, 45);
            this.button12.TabIndex = 0;
            this.button12.Text = "دکمه تستی";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseLeave += new System.EventHandler(this.button12_MouseLeave);
            this.button12.MouseHover += new System.EventHandler(this.button12_MouseHover);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button12_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button12;
    }
}