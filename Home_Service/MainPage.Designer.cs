namespace Home_Service
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.pricesDataGrid = new System.Windows.Forms.DataGridView();
            this.ServiceDB = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.AddServiceToClient = new System.Windows.Forms.Button();
            this.ClientDB = new System.Windows.Forms.Button();
            this.SendParameters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуги ЖКХ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricesDataGrid
            // 
            this.pricesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricesDataGrid.Location = new System.Drawing.Point(28, 105);
            this.pricesDataGrid.Name = "pricesDataGrid";
            this.pricesDataGrid.Size = new System.Drawing.Size(347, 145);
            this.pricesDataGrid.TabIndex = 1;
            // 
            // ServiceDB
            // 
            this.ServiceDB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ServiceDB.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.ServiceDB.Location = new System.Drawing.Point(410, 304);
            this.ServiceDB.Name = "ServiceDB";
            this.ServiceDB.Size = new System.Drawing.Size(190, 57);
            this.ServiceDB.TabIndex = 4;
            this.ServiceDB.Text = "База ЖКУ";
            this.ServiceDB.UseVisualStyleBackColor = false;
            this.ServiceDB.Click += new System.EventHandler(this.ServiceDB_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.Exit.Location = new System.Drawing.Point(410, 404);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 57);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddServiceToClient
            // 
            this.AddServiceToClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddServiceToClient.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.AddServiceToClient.Location = new System.Drawing.Point(410, 206);
            this.AddServiceToClient.Name = "AddServiceToClient";
            this.AddServiceToClient.Size = new System.Drawing.Size(190, 57);
            this.AddServiceToClient.TabIndex = 3;
            this.AddServiceToClient.Text = "Добавление услуг потребителю";
            this.AddServiceToClient.UseVisualStyleBackColor = false;
            this.AddServiceToClient.Click += new System.EventHandler(this.AddServiceToClient_Click);
            // 
            // ClientDB
            // 
            this.ClientDB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientDB.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientDB.Location = new System.Drawing.Point(410, 105);
            this.ClientDB.Name = "ClientDB";
            this.ClientDB.Size = new System.Drawing.Size(190, 57);
            this.ClientDB.TabIndex = 2;
            this.ClientDB.Text = "База потребителей";
            this.ClientDB.UseVisualStyleBackColor = false;
            this.ClientDB.Click += new System.EventHandler(this.ClientDB_Click);
            // 
            // SendParameters
            // 
            this.SendParameters.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SendParameters.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.SendParameters.Location = new System.Drawing.Point(410, 155);
            this.SendParameters.Name = "SendParameters";
            this.SendParameters.Size = new System.Drawing.Size(190, 57);
            this.SendParameters.TabIndex = 6;
            this.SendParameters.Text = "Подать показания";
            this.SendParameters.UseVisualStyleBackColor = false;
            this.SendParameters.Click += new System.EventHandler(this.SendParameters_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 492);
            this.Controls.Add(this.SendParameters);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ServiceDB);
            this.Controls.Add(this.AddServiceToClient);
            this.Controls.Add(this.ClientDB);
            this.Controls.Add(this.pricesDataGrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pricesDataGrid;
        private System.Windows.Forms.Button ServiceDB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddServiceToClient;
        private System.Windows.Forms.Button ClientDB;
        private System.Windows.Forms.Button SendParameters;
    }
}