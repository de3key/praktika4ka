
namespace WindowsFormsApp3
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунок1ToolStripMenuItem,
            this.рисунок2ToolStripMenuItem,
            this.рисунок3ToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            // 
            // рисунок1ToolStripMenuItem
            // 
            this.рисунок1ToolStripMenuItem.Name = "рисунок1ToolStripMenuItem";
            this.рисунок1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисунок1ToolStripMenuItem.Text = "Рисунок 1";
            this.рисунок1ToolStripMenuItem.Click += new System.EventHandler(this.рисунок1ToolStripMenuItem_Click);
            // 
            // рисунок2ToolStripMenuItem
            // 
            this.рисунок2ToolStripMenuItem.Name = "рисунок2ToolStripMenuItem";
            this.рисунок2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисунок2ToolStripMenuItem.Text = "Рисунок 2";
            this.рисунок2ToolStripMenuItem.Click += new System.EventHandler(this.рисунок2ToolStripMenuItem_Click);
            // 
            // рисунок3ToolStripMenuItem
            // 
            this.рисунок3ToolStripMenuItem.Name = "рисунок3ToolStripMenuItem";
            this.рисунок3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисунок3ToolStripMenuItem.Text = "Рисунок 3";
            this.рисунок3ToolStripMenuItem.Click += new System.EventHandler(this.рисунок3ToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок3ToolStripMenuItem;
    }
}