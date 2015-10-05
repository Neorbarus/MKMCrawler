namespace MKMCrawler
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.archivoMenuSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarBaseDeDatosMenuSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.search = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.expansionsListView = new System.Windows.Forms.ListView();
            this.menuSuperior.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenuSuperior,
            this.ediciónToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(1154, 24);
            this.menuSuperior.TabIndex = 0;
            this.menuSuperior.Text = "menuSuperior";
            // 
            // archivoMenuSuperior
            // 
            this.archivoMenuSuperior.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarBaseDeDatosMenuSuperior});
            this.archivoMenuSuperior.Name = "archivoMenuSuperior";
            this.archivoMenuSuperior.Size = new System.Drawing.Size(60, 20);
            this.archivoMenuSuperior.Text = "Archivo";
            // 
            // actualizarBaseDeDatosMenuSuperior
            // 
            this.actualizarBaseDeDatosMenuSuperior.Name = "actualizarBaseDeDatosMenuSuperior";
            this.actualizarBaseDeDatosMenuSuperior.Size = new System.Drawing.Size(201, 22);
            this.actualizarBaseDeDatosMenuSuperior.Text = "Actualizar base de datos";
            this.actualizarBaseDeDatosMenuSuperior.Click += new System.EventHandler(this.actualizarBaseDeDatosMenuSuperior_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "statusLabel";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.expansionsListView);
            this.splitContainer1.Panel1.Controls.Add(this.searchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 653);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 3;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(3, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(40, 13);
            this.search.TabIndex = 0;
            this.search.Text = "Buscar";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(49, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(231, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // expansionsListView
            // 
            this.expansionsListView.Location = new System.Drawing.Point(3, 29);
            this.expansionsListView.Name = "expansionsListView";
            this.expansionsListView.Size = new System.Drawing.Size(277, 621);
            this.expansionsListView.TabIndex = 2;
            this.expansionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 699);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuSuperior);
            this.MainMenuStrip = this.menuSuperior;
            this.Name = "MainWindow";
            this.Text = "MKMCrawler";
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem actualizarBaseDeDatosMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView expansionsListView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label search;
    }
}

