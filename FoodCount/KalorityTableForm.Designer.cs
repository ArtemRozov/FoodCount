namespace FoodCount
{
    partial class KalorityTableForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обзорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.харчуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицяКалорійностіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(1, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Страва";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Калорійність за 100 грам";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обзорToolStripMenuItem,
            this.харчуванняToolStripMenuItem,
            this.таблицяКалорійностіToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обзорToolStripMenuItem
            // 
            this.обзорToolStripMenuItem.Name = "обзорToolStripMenuItem";
            this.обзорToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.обзорToolStripMenuItem.Text = "Обзор";
            this.обзорToolStripMenuItem.Click += new System.EventHandler(this.обзорToolStripMenuItem_Click);
            // 
            // харчуванняToolStripMenuItem
            // 
            this.харчуванняToolStripMenuItem.Name = "харчуванняToolStripMenuItem";
            this.харчуванняToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.харчуванняToolStripMenuItem.Text = "Харчування";
            this.харчуванняToolStripMenuItem.Click += new System.EventHandler(this.харчуванняToolStripMenuItem_Click);
            // 
            // таблицяКалорійностіToolStripMenuItem
            // 
            this.таблицяКалорійностіToolStripMenuItem.Name = "таблицяКалорійностіToolStripMenuItem";
            this.таблицяКалорійностіToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.таблицяКалорійностіToolStripMenuItem.Text = "Таблиця калорійності";
            // 
            // KalorityTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KalorityTableForm";
            this.Text = "Таблиця калорійності";
            this.Load += new System.EventHandler(this.KalorityTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem харчуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицяКалорійностіToolStripMenuItem;
    }
}