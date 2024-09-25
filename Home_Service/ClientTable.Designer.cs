namespace Home_Service
{
    partial class ClientTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTable));
            this.clientsDataGrid = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accountSearchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsDataGrid
            // 
            this.clientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGrid.Location = new System.Drawing.Point(10, 95);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.Size = new System.Drawing.Size(776, 239);
            this.clientsDataGrid.TabIndex = 0;
            this.clientsDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientsDataGrid_RowHeaderMouseClick);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Menu.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.Menu.Location = new System.Drawing.Point(664, 21);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(99, 47);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.companyTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // companyTextBox
            // 
            this.companyTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.companyTextBox.Location = new System.Drawing.Point(12, 63);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(191, 29);
            this.companyTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Лицевой счёт";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.accountNumberTextBox.Location = new System.Drawing.Point(137, 180);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(191, 29);
            this.accountNumberTextBox.TabIndex = 10;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(12, 131);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(191, 29);
            this.phoneNumberTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addressTextBox.Location = new System.Drawing.Point(222, 131);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(174, 29);
            this.addressTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.fullNameTextBox.Location = new System.Drawing.Point(225, 63);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(174, 29);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управляющая компания";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accountSearchText);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.DeleteClient);
            this.groupBox2.Controls.Add(this.EditClient);
            this.groupBox2.Controls.Add(this.AddClient);
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(447, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 235);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функции";
            // 
            // accountSearchText
            // 
            this.accountSearchText.BackColor = System.Drawing.SystemColors.Control;
            this.accountSearchText.Location = new System.Drawing.Point(17, 28);
            this.accountSearchText.Name = "accountSearchText";
            this.accountSearchText.Size = new System.Drawing.Size(183, 29);
            this.accountSearchText.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(206, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(127, 29);
            this.Search.TabIndex = 3;
            this.Search.Text = "Поиск по л/с";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(36, 173);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(280, 32);
            this.DeleteClient.TabIndex = 2;
            this.DeleteClient.Text = "Удалить пользователя";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(36, 125);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(280, 32);
            this.EditClient.TabIndex = 1;
            this.EditClient.Text = "Редактировать пользователя";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(36, 78);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(280, 32);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Добавить пользователя";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ClientTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.clientsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientTable";
            this.Text = "База плательщиков";
            this.Load += new System.EventHandler(this.ClientTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsDataGrid;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountSearchText;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
    }
}