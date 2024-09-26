namespace Home_Service
{
    partial class SendParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendParams));
            this.paramsHistoryGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Send = new System.Windows.Forms.Button();
            this.currentParams = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_SP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paramsHistoryGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paramsHistoryGridView
            // 
            this.paramsHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paramsHistoryGridView.Location = new System.Drawing.Point(12, 94);
            this.paramsHistoryGridView.Name = "paramsHistoryGridView";
            this.paramsHistoryGridView.Size = new System.Drawing.Size(496, 139);
            this.paramsHistoryGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Send);
            this.groupBox1.Controls.Add(this.currentParams);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.serviceComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(514, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Передача данных";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(36, 337);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(168, 28);
            this.Send.TabIndex = 6;
            this.Send.Text = "Передать показания";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // currentParams
            // 
            this.currentParams.Location = new System.Drawing.Point(14, 292);
            this.currentParams.Name = "currentParams";
            this.currentParams.Size = new System.Drawing.Size(189, 29);
            this.currentParams.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(14, 196);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(190, 26);
            this.datePicker.TabIndex = 4;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(14, 82);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(191, 29);
            this.serviceComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Текущие показания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуга";
            // 
            // Menu_SP
            // 
            this.Menu_SP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Menu_SP.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.Menu_SP.Location = new System.Drawing.Point(683, 12);
            this.Menu_SP.Name = "Menu_SP";
            this.Menu_SP.Size = new System.Drawing.Size(95, 37);
            this.Menu_SP.TabIndex = 3;
            this.Menu_SP.Text = "Меню";
            this.Menu_SP.UseVisualStyleBackColor = false;
            this.Menu_SP.Click += new System.EventHandler(this.MenuSP_Click);
            // 
            // SendParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.Menu_SP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paramsHistoryGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendParams";
            this.Text = "Отправка параметров";
            this.Load += new System.EventHandler(this.SendParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paramsHistoryGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paramsHistoryGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox currentParams;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button Menu_SP;
    }
}