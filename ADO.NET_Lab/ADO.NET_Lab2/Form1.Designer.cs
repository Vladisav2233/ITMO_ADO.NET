namespace ADO.NET_Lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_BDconnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_BDconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_BDdisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_BDconnection});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_BDconnection
            // 
            this.Menu_BDconnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_BDconnect,
            this.toolStripMenuItem_BDdisconnect,
            this.списокПодключенийToolStripMenuItem});
            this.Menu_BDconnection.Name = "Menu_BDconnection";
            this.Menu_BDconnection.Size = new System.Drawing.Size(59, 24);
            this.Menu_BDconnection.Text = "Файл";
            // 
            // toolStripMenuItem_BDconnect
            // 
            this.toolStripMenuItem_BDconnect.Name = "toolStripMenuItem_BDconnect";
            this.toolStripMenuItem_BDconnect.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItem_BDconnect.Text = "Подключиться к БД";
            this.toolStripMenuItem_BDconnect.Click += new System.EventHandler(this.toolStripMenuItem_BDconnect_Click);
            // 
            // toolStripMenuItem_BDdisconnect
            // 
            this.toolStripMenuItem_BDdisconnect.Name = "toolStripMenuItem_BDdisconnect";
            this.toolStripMenuItem_BDdisconnect.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItem_BDdisconnect.Text = "Отключиться от БД";
            this.toolStripMenuItem_BDdisconnect.Click += new System.EventHandler(this.toolStripMenuItem_BDdisconnect_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.списокПодключенийToolStripMenuItem.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_BDconnection;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_BDconnect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_BDdisconnect;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

