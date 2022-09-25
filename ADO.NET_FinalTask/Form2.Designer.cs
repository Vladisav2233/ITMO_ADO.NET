namespace ITMO_124_16_ADO.NET_IvanovVA_MyDBApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet = new ITMO_124_16_ADO.NET_IvanovVA_MyDBApp._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet();
            this.iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxIdCompany = new System.Windows.Forms.TextBox();
            this.buttonFillTextBox = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonCloseConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet
            // 
            this._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet.DataSetName = "_ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet";
            this._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource
            // 
            this.iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource.DataSource = this._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet;
            this.iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добавить пользователя";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(773, 322);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 41);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(774, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 45);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 361);
            this.dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Возраст:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "CompanyID:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(773, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 22);
            this.textBoxName.TabIndex = 14;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(773, 117);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(121, 22);
            this.textBoxSurname.TabIndex = 15;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(773, 182);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(121, 22);
            this.textBoxAge.TabIndex = 16;
            // 
            // textBoxIdCompany
            // 
            this.textBoxIdCompany.Location = new System.Drawing.Point(773, 271);
            this.textBoxIdCompany.Name = "textBoxIdCompany";
            this.textBoxIdCompany.Size = new System.Drawing.Size(121, 22);
            this.textBoxIdCompany.TabIndex = 17;
            // 
            // buttonFillTextBox
            // 
            this.buttonFillTextBox.Location = new System.Drawing.Point(953, 47);
            this.buttonFillTextBox.Name = "buttonFillTextBox";
            this.buttonFillTextBox.Size = new System.Drawing.Size(148, 103);
            this.buttonFillTextBox.TabIndex = 18;
            this.buttonFillTextBox.Text = "Заполнить поля текущим значением";
            this.buttonFillTextBox.UseVisualStyleBackColor = true;
            this.buttonFillTextBox.Click += new System.EventHandler(this.buttonFillTextBox_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(953, 174);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(148, 98);
            this.buttonChange.TabIndex = 19;
            this.buttonChange.Text = "Изменить данные";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCloseConnection
            // 
            this.buttonCloseConnection.Location = new System.Drawing.Point(692, 455);
            this.buttonCloseConnection.Name = "buttonCloseConnection";
            this.buttonCloseConnection.Size = new System.Drawing.Size(409, 53);
            this.buttonCloseConnection.TabIndex = 20;
            this.buttonCloseConnection.Text = "Завершить работу и закрыть подключение";
            this.buttonCloseConnection.UseVisualStyleBackColor = true;
            this.buttonCloseConnection.Click += new System.EventHandler(this.buttonCloseConnection_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 520);
            this.Controls.Add(this.buttonCloseConnection);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonFillTextBox);
            this.Controls.Add(this.textBoxIdCompany);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet _ITMO_124_16_ADO_NET_IvanovVA_MyDBAppDataSet;
        private System.Windows.Forms.BindingSource iTMO12416ADONETIvanovVAMyDBAppDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxIdCompany;
        private System.Windows.Forms.Button buttonFillTextBox;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonCloseConnection;
    }
}