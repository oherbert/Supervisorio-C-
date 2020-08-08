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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtSendArduino = new System.Windows.Forms.TextBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartPrincipal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(13, 64);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtSendArduino
            // 
            this.txtSendArduino.Location = new System.Drawing.Point(13, 36);
            this.txtSendArduino.Name = "txtSendArduino";
            this.txtSendArduino.Size = new System.Drawing.Size(100, 20);
            this.txtSendArduino.TabIndex = 1;
            // 
            // cboPort
            // 
            this.cboPort.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.cboPort.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cboPort.Location = new System.Drawing.Point(13, 8);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 2;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 535);
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
            this.tableLayoutPanel2.Controls.Add(this.cboPort, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSendData, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSendArduino, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(173, 101);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
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
            this.menuStrip1.Size = new System.Drawing.Size(1307, 24);
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
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offsetsToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicaçãoToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // offsetsToolStripMenuItem
            // 
            this.offsetsToolStripMenuItem.Name = "offsetsToolStripMenuItem";
            this.offsetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.offsetsToolStripMenuItem.Text = "Offsets";
            // 
            // comunicaçãoToolStripMenuItem
            // 
            this.comunicaçãoToolStripMenuItem.Name = "comunicaçãoToolStripMenuItem";
            this.comunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comunicaçãoToolStripMenuItem.Text = "Comunicação";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // chartPrincipal
            // 
            this.chartPrincipal.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartPrincipal.ChartAreas.Add(chartArea1);
            this.chartPrincipal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            legend1.Name = "Legend1";
            this.chartPrincipal.Legends.Add(legend1);
            this.chartPrincipal.Location = new System.Drawing.Point(203, 41);
            this.chartPrincipal.Name = "chartPrincipal";
            this.chartPrincipal.Size = new System.Drawing.Size(1092, 520);
            this.chartPrincipal.TabIndex = 5;
            this.chartPrincipal.Text = "ICBT 1";
            this.chartPrincipal.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 588);
            this.Controls.Add(this.chartPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtSendArduino;
        private System.Windows.Forms.ComboBox cboPort;
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
    }
}

