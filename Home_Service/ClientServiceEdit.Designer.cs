namespace Home_Service
{
    partial class ClientServiceEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientServiceEdit));
            this.Menu_CS = new System.Windows.Forms.Button();
            this.client_serviceDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCleintService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteClientService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.client_serviceDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_CS
            // 
            this.Menu_CS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Menu_CS.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.Menu_CS.Location = new System.Drawing.Point(673, 26);
            this.Menu_CS.Name = "Menu_CS";
            this.Menu_CS.Size = new System.Drawing.Size(99, 47);
            this.Menu_CS.TabIndex = 0;
            this.Menu_CS.Text = "Меню";
            this.Menu_CS.UseVisualStyleBackColor = false;
            this.Menu_CS.Click += new System.EventHandler(this.MenuCS_Click);
            // 
            // client_serviceDataGrid
            // 
            this.client_serviceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_serviceDataGrid.Location = new System.Drawing.Point(14, 79);
            this.client_serviceDataGrid.Name = "client_serviceDataGrid";
            this.client_serviceDataGrid.Size = new System.Drawing.Size(759, 214);
            this.client_serviceDataGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCleintService);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clientComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serviceComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление услуги";
            // 
            // AddCleintService
            // 
            this.AddCleintService.Location = new System.Drawing.Point(109, 102);
            this.AddCleintService.Name = "AddCleintService";
            this.AddCleintService.Size = new System.Drawing.Size(167, 32);
            this.AddCleintService.TabIndex = 4;
            this.AddCleintService.Text = "Добавить";
            this.AddCleintService.UseVisualStyleBackColor = true;
            this.AddCleintService.Click += new System.EventHandler(this.AddClientService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбор плательщика";
            // 
            // clientComboBox
            // 
            this.clientComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(206, 57);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(175, 29);
            this.clientComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор услуги";
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(6, 57);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(175, 29);
            this.serviceComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteClientService);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(426, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление услуги";
            // 
            // DeleteClientService
            // 
            this.DeleteClientService.Location = new System.Drawing.Point(97, 102);
            this.DeleteClientService.Name = "DeleteClientService";
            this.DeleteClientService.Size = new System.Drawing.Size(167, 32);
            this.DeleteClientService.TabIndex = 1;
            this.DeleteClientService.Text = "Удалить";
            this.DeleteClientService.UseVisualStyleBackColor = true;
            this.DeleteClientService.Click += new System.EventHandler(this.DeleteClientService_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Для удаления записи об услуге выделите её в таблице выше";
            // 
            // ClientServiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.client_serviceDataGrid);
            this.Controls.Add(this.Menu_CS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientServiceEdit";
            this.Text = "Услуги потребителя";
            this.Load += new System.EventHandler(this.ClientServiceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_serviceDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menu_CS;
        private System.Windows.Forms.DataGridView client_serviceDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Button AddCleintService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteClientService;
        private System.Windows.Forms.Label label3;
    }
}