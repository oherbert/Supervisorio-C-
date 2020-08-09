namespace Arduino_teste2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.com1Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com2Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com3Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com4Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com5Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com6Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com7Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com8Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.com9Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartPrincipal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 657);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblCom, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 125);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(13, 5);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(51, 20);
            this.lblCom.TabIndex = 0;
            this.lblCom.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offsetsToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // offsetsToolStripMenuItem
            // 
            this.offsetsToolStripMenuItem.Name = "offsetsToolStripMenuItem";
            this.offsetsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.offsetsToolStripMenuItem.Text = "Offsets";
            this.offsetsToolStripMenuItem.Click += new System.EventHandler(this.offsetsToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicaçãoToolStripMenuItem,
            this.conectarMenu,
            this.desconectarMenu});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // comunicaçãoToolStripMenuItem
            // 
            this.comunicaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.com1Menu,
            this.com2Menu,
            this.com3Menu,
            this.com4Menu,
            this.com5Menu,
            this.com6Menu,
            this.com7Menu,
            this.com8Menu,
            this.com9Menu});
            this.comunicaçãoToolStripMenuItem.Name = "comunicaçãoToolStripMenuItem";
            this.comunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comunicaçãoToolStripMenuItem.Text = "Comunicação";
            // 
            // com1Menu
            // 
            this.com1Menu.Name = "com1Menu";
            this.com1Menu.Size = new System.Drawing.Size(108, 22);
            this.com1Menu.Text = "COM1";
            this.com1Menu.Click += new System.EventHandler(this.com1Menu_Click);
            // 
            // com2Menu
            // 
            this.com2Menu.Name = "com2Menu";
            this.com2Menu.Size = new System.Drawing.Size(108, 22);
            this.com2Menu.Text = "COM2";
            this.com2Menu.Click += new System.EventHandler(this.com2Menu_Click);
            // 
            // com3Menu
            // 
            this.com3Menu.Name = "com3Menu";
            this.com3Menu.Size = new System.Drawing.Size(108, 22);
            this.com3Menu.Text = "COM3";
            this.com3Menu.Click += new System.EventHandler(this.com3Menu_Click);
            // 
            // com4Menu
            // 
            this.com4Menu.Name = "com4Menu";
            this.com4Menu.Size = new System.Drawing.Size(108, 22);
            this.com4Menu.Text = "COM4";
            this.com4Menu.Click += new System.EventHandler(this.com4Menu_Click);
            // 
            // com5Menu
            // 
            this.com5Menu.Name = "com5Menu";
            this.com5Menu.Size = new System.Drawing.Size(108, 22);
            this.com5Menu.Text = "COM5";
            this.com5Menu.Click += new System.EventHandler(this.com5Menu_Click);
            // 
            // com6Menu
            // 
            this.com6Menu.Name = "com6Menu";
            this.com6Menu.Size = new System.Drawing.Size(108, 22);
            this.com6Menu.Text = "COM6";
            this.com6Menu.Click += new System.EventHandler(this.com6Menu_Click);
            // 
            // com7Menu
            // 
            this.com7Menu.Name = "com7Menu";
            this.com7Menu.Size = new System.Drawing.Size(108, 22);
            this.com7Menu.Text = "COM7";
            this.com7Menu.Click += new System.EventHandler(this.com7Menu_Click);
            // 
            // com8Menu
            // 
            this.com8Menu.Name = "com8Menu";
            this.com8Menu.Size = new System.Drawing.Size(108, 22);
            this.com8Menu.Text = "COM8";
            this.com8Menu.Click += new System.EventHandler(this.com8Menu_Click);
            // 
            // com9Menu
            // 
            this.com9Menu.Name = "com9Menu";
            this.com9Menu.Size = new System.Drawing.Size(108, 22);
            this.com9Menu.Text = "COM9";
            this.com9Menu.Click += new System.EventHandler(this.com9Menu_Click);
            // 
            // conectarMenu
            // 
            this.conectarMenu.Name = "conectarMenu";
            this.conectarMenu.Size = new System.Drawing.Size(180, 22);
            this.conectarMenu.Text = "Conectar";
            this.conectarMenu.Click += new System.EventHandler(this.conectarMenu_Click);
            // 
            // desconectarMenu
            // 
            this.desconectarMenu.Name = "desconectarMenu";
            this.desconectarMenu.Size = new System.Drawing.Size(180, 22);
            this.desconectarMenu.Text = "Desconectar";
            this.desconectarMenu.Click += new System.EventHandler(this.desconectarMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpToolStripMenuItem.Text = "Ajuda";
            // 
            // chartPrincipal
            // 
            this.chartPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartPrincipal.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartPrincipal.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chartPrincipal.ChartAreas.Add(chartArea3);
            this.chartPrincipal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.chartPrincipal.Location = new System.Drawing.Point(234, 38);
            this.chartPrincipal.Name = "chartPrincipal";
            this.chartPrincipal.Size = new System.Drawing.Size(1022, 680);
            this.chartPrincipal.TabIndex = 5;
            this.chartPrincipal.Text = "ICBT 1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "ICBT 1";
            title3.Text = "ICBT 1";
            this.chartPrincipal.Titles.Add(title3);
            this.chartPrincipal.UseWaitCursor = true;
            this.chartPrincipal.Click += new System.EventHandler(this.chartPrincipal_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 730);
            this.Controls.Add(this.chartPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrincipal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem com1Menu;
        private System.Windows.Forms.ToolStripMenuItem com2Menu;
        private System.Windows.Forms.ToolStripMenuItem com3Menu;
        private System.Windows.Forms.ToolStripMenuItem com4Menu;
        private System.Windows.Forms.ToolStripMenuItem com5Menu;
        private System.Windows.Forms.ToolStripMenuItem com6Menu;
        private System.Windows.Forms.ToolStripMenuItem com7Menu;
        private System.Windows.Forms.ToolStripMenuItem com8Menu;
        private System.Windows.Forms.ToolStripMenuItem com9Menu;
        private System.Windows.Forms.ToolStripMenuItem conectarMenu;
        private System.Windows.Forms.ToolStripMenuItem desconectarMenu;
        private System.Windows.Forms.Label lblCom;
    }
}

