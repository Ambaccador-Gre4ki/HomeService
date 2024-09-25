namespace Home_Service
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.serviceDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceValue = new System.Windows.Forms.TextBox();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddService = new System.Windows.Forms.Button();
            this.ChangeService = new System.Windows.Forms.Button();
            this.DeleteService = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceDataGrid
            // 
            this.serviceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGrid.Location = new System.Drawing.Point(12, 63);
            this.serviceDataGrid.Name = "serviceDataGrid";
            this.serviceDataGrid.Size = new System.Drawing.Size(345, 354);
            this.serviceDataGrid.TabIndex = 0;
            this.serviceDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.serviceDataGrid_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceValue);
            this.groupBox1.Controls.Add(this.serviceName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(379, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // priceValue
            // 
            this.priceValue.BackColor = System.Drawing.SystemColors.Control;
            this.priceValue.Location = new System.Drawing.Point(158, 87);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(173, 29);
            this.priceValue.TabIndex = 3;
            // 
            // serviceName
            // 
            this.serviceName.BackColor = System.Drawing.SystemColors.Control;
            this.serviceName.Location = new System.Drawing.Point(158, 40);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(173, 29);
            this.serviceName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тариф (руб./ед.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название услуги";
            // 
            // AddService
            // 
            this.AddService.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.AddService.Location = new System.Drawing.Point(458, 225);
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(192, 44);
            this.AddService.TabIndex = 2;
            this.AddService.Text = "Добавить услугу";
            this.AddService.UseVisualStyleBackColor = true;
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // ChangeService
            // 
            this.ChangeService.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.ChangeService.Location = new System.Drawing.Point(458, 299);
            this.ChangeService.Name = "ChangeService";
            this.ChangeService.Size = new System.Drawing.Size(192, 44);
            this.ChangeService.TabIndex = 3;
            this.ChangeService.Text = "Редактировать услугу";
            this.ChangeService.UseVisualStyleBackColor = true;
            this.ChangeService.Click += new System.EventHandler(this.ChangeService_Click);
            // 
            // DeleteService
            // 
            this.DeleteService.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.DeleteService.Location = new System.Drawing.Point(458, 373);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(192, 44);
            this.DeleteService.TabIndex = 4;
            this.DeleteService.Text = "Удалить услугу";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.button4.Location = new System.Drawing.Point(602, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Меню";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.ChangeService);
            this.Controls.Add(this.AddService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serviceDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Service";
            this.Text = "База жилищно-коммунальных услуг";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView serviceDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceValue;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddService;
        private System.Windows.Forms.Button ChangeService;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.Button button4;
    }
}