namespace Ispan_midProject_WinForm47
{
    partial class BackStageMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.產品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.產品總管ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訂單管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訂單總管ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供應商管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供應商總管ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.產品管理ToolStripMenuItem,
            this.訂單管理ToolStripMenuItem,
            this.供應商管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 產品管理ToolStripMenuItem
            // 
            this.產品管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.產品總管ToolStripMenuItem});
            this.產品管理ToolStripMenuItem.Name = "產品管理ToolStripMenuItem";
            this.產品管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.產品管理ToolStripMenuItem.Text = "產品管理";
            // 
            // 產品總管ToolStripMenuItem
            // 
            this.產品總管ToolStripMenuItem.Name = "產品總管ToolStripMenuItem";
            this.產品總管ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.產品總管ToolStripMenuItem.Text = "產品總管";
            this.產品總管ToolStripMenuItem.Click += new System.EventHandler(this.產品總管ToolStripMenuItem_Click);
            // 
            // 訂單管理ToolStripMenuItem
            // 
            this.訂單管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂單總管ToolStripMenuItem});
            this.訂單管理ToolStripMenuItem.Name = "訂單管理ToolStripMenuItem";
            this.訂單管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.訂單管理ToolStripMenuItem.Text = "訂單管理";
            // 
            // 訂單總管ToolStripMenuItem
            // 
            this.訂單總管ToolStripMenuItem.Name = "訂單總管ToolStripMenuItem";
            this.訂單總管ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.訂單總管ToolStripMenuItem.Text = "訂單總管";
            // 
            // 供應商管理ToolStripMenuItem
            // 
            this.供應商管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.供應商總管ToolStripMenuItem});
            this.供應商管理ToolStripMenuItem.Name = "供應商管理ToolStripMenuItem";
            this.供應商管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.供應商管理ToolStripMenuItem.Text = "供應商管理";
            // 
            // 供應商總管ToolStripMenuItem
            // 
            this.供應商總管ToolStripMenuItem.Name = "供應商總管ToolStripMenuItem";
            this.供應商總管ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.供應商總管ToolStripMenuItem.Text = "供應商總管";
            // 
            // BackStageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BackStageMain";
            this.Text = "民宿旅遊後台管理(Beta)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 產品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 產品總管ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 訂單管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 訂單總管ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供應商管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供應商總管ToolStripMenuItem;
    }
}

