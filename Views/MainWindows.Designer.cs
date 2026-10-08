namespace TIA_Program_Check
{
    partial class MainWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIA版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem,
            this.tIA版本ToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 注册ToolStripMenuItem
            // 
            resources.ApplyResources(this.注册ToolStripMenuItem, "注册ToolStripMenuItem");
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            // 
            // tIA版本ToolStripMenuItem
            // 
            resources.ApplyResources(this.tIA版本ToolStripMenuItem, "tIA版本ToolStripMenuItem");
            this.tIA版本ToolStripMenuItem.Name = "tIA版本ToolStripMenuItem";
            this.tIA版本ToolStripMenuItem.Click += new System.EventHandler(this.tIA版本ToolStripMenuItem_Click);
            // 
            // MainWindows
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIA版本ToolStripMenuItem;
    }
}

