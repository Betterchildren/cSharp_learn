namespace test06_7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.北京ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上海ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.青岛ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.南京ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.西安ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(53, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(335, 238);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.北京ToolStripMenuItem,
            this.上海ToolStripMenuItem,
            this.青岛ToolStripMenuItem,
            this.南京ToolStripMenuItem,
            this.西安ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 114);
            // 
            // 北京ToolStripMenuItem
            // 
            this.北京ToolStripMenuItem.Name = "北京ToolStripMenuItem";
            this.北京ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.北京ToolStripMenuItem.Text = "北京";
            this.北京ToolStripMenuItem.Click += new System.EventHandler(this.北京ToolStripMenuItem_Click);
            // 
            // 上海ToolStripMenuItem
            // 
            this.上海ToolStripMenuItem.Name = "上海ToolStripMenuItem";
            this.上海ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.上海ToolStripMenuItem.Text = "上海";
            this.上海ToolStripMenuItem.Click += new System.EventHandler(this.上海ToolStripMenuItem_Click);
            // 
            // 青岛ToolStripMenuItem
            // 
            this.青岛ToolStripMenuItem.Name = "青岛ToolStripMenuItem";
            this.青岛ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.青岛ToolStripMenuItem.Text = "青岛";
            this.青岛ToolStripMenuItem.Click += new System.EventHandler(this.青岛ToolStripMenuItem_Click);
            // 
            // 南京ToolStripMenuItem
            // 
            this.南京ToolStripMenuItem.Name = "南京ToolStripMenuItem";
            this.南京ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.南京ToolStripMenuItem.Text = "南京";
            this.南京ToolStripMenuItem.Click += new System.EventHandler(this.南京ToolStripMenuItem_Click);
            // 
            // 西安ToolStripMenuItem
            // 
            this.西安ToolStripMenuItem.Name = "西安ToolStripMenuItem";
            this.西安ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.西安ToolStripMenuItem.Text = "西安";
            this.西安ToolStripMenuItem.Click += new System.EventHandler(this.西安ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 330);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 北京ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上海ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 青岛ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 南京ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 西安ToolStripMenuItem;
    }
}

