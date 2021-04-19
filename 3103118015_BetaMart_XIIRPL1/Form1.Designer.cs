namespace _3103118015_BetaMart
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.betaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnew = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.betaData = new _3103118015_BetaMart_XIIRPL1.betaData();
            this.betaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.betaTableAdapter = new _3103118015_BetaMart_XIIRPL1.betaDataTableAdapters.BetaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.betaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 194);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // betaBindingSource
            // 
            this.betaBindingSource.DataMember = "Beta";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(98, 11);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(715, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(12, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Search";
            // 
            // btnew
            // 
            this.btnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnew.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnew.Location = new System.Drawing.Point(431, 379);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(91, 34);
            this.btnew.TabIndex = 1;
            this.btnew.Text = "NEW";
            this.btnew.UseVisualStyleBackColor = false;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btedit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.Location = new System.Drawing.Point(528, 379);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(91, 34);
            this.btedit.TabIndex = 2;
            this.btedit.Text = "EDIT";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btsave.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Location = new System.Drawing.Point(625, 379);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(91, 34);
            this.btsave.TabIndex = 3;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btdelete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(722, 379);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(91, 34);
            this.btdelete.TabIndex = 4;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(405, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock Barang";
            // 
            // txtNB
            // 
            this.txtNB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "NamaBarang", true));
            this.txtNB.Location = new System.Drawing.Point(166, 23);
            this.txtNB.Multiline = true;
            this.txtNB.Name = "txtNB";
            this.txtNB.Size = new System.Drawing.Size(224, 20);
            this.txtNB.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(405, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Penerima";
            // 
            // txtKB
            // 
            this.txtKB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "KodeBarang", true));
            this.txtKB.Location = new System.Drawing.Point(166, 48);
            this.txtKB.Multiline = true;
            this.txtKB.Name = "txtKB";
            this.txtKB.Size = new System.Drawing.Size(224, 20);
            this.txtKB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(405, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier";
            // 
            // txtBB
            // 
            this.txtBB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "BeratBarang", true));
            this.txtBB.Location = new System.Drawing.Point(166, 73);
            this.txtBB.Multiline = true;
            this.txtBB.Name = "txtBB";
            this.txtBB.Size = new System.Drawing.Size(224, 20);
            this.txtBB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(405, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Masuk";
            // 
            // txtKat
            // 
            this.txtKat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "Kategori", true));
            this.txtKat.Location = new System.Drawing.Point(166, 98);
            this.txtKat.Multiline = true;
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(224, 20);
            this.txtKat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // txtTM
            // 
            this.txtTM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "TanggalMasuk", true));
            this.txtTM.Location = new System.Drawing.Point(568, 23);
            this.txtTM.Multiline = true;
            this.txtTM.Name = "txtTM";
            this.txtTM.Size = new System.Drawing.Size(224, 20);
            this.txtTM.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(4, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Berat Barang";
            // 
            // txtsup
            // 
            this.txtsup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "Supplier", true));
            this.txtsup.Location = new System.Drawing.Point(568, 48);
            this.txtsup.Multiline = true;
            this.txtsup.Name = "txtsup";
            this.txtsup.Size = new System.Drawing.Size(224, 20);
            this.txtsup.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // txtPen
            // 
            this.txtPen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "Penerima", true));
            this.txtPen.Location = new System.Drawing.Point(568, 73);
            this.txtPen.Multiline = true;
            this.txtPen.Name = "txtPen";
            this.txtPen.Size = new System.Drawing.Size(224, 20);
            this.txtPen.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 14.24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // txtSB
            // 
            this.txtSB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaBindingSource1, "StockBarang", true));
            this.txtSB.Location = new System.Drawing.Point(568, 98);
            this.txtSB.Multiline = true;
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(224, 20);
            this.txtSB.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNB);
            this.panel1.Controls.Add(this.txtKat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtsup);
            this.panel1.Controls.Add(this.txtTM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtKB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPen);
            this.panel1.Location = new System.Drawing.Point(12, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 136);
            this.panel1.TabIndex = 22;
            // 
            // betaData
            // 
            this.betaData.DataSetName = "betaData";
            this.betaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betaBindingSource1
            // 
            this.betaBindingSource1.DataMember = "Beta";
            this.betaBindingSource1.DataSource = this.betaData;
            // 
            // betaTableAdapter
            // 
            this.betaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BetaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BetaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaBarang";
            this.dataGridViewTextBoxColumn2.HeaderText = "NamaBarang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KodeBarang";
            this.dataGridViewTextBoxColumn3.HeaderText = "KodeBarang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BeratBarang";
            this.dataGridViewTextBoxColumn4.HeaderText = "BeratBarang";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kategori";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kategori";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TanggalMasuk";
            this.dataGridViewTextBoxColumn6.HeaderText = "TanggalMasuk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn7.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Penerima";
            this.dataGridViewTextBoxColumn8.HeaderText = "Penerima";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StockBarang";
            this.dataGridViewTextBoxColumn9.HeaderText = "StockBarang";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource betaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn betaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beratBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockBarangDataGridViewTextBoxColumn;
        private _3103118015_BetaMart_XIIRPL1.betaData betaData;
        private System.Windows.Forms.BindingSource betaBindingSource1;
        private _3103118015_BetaMart_XIIRPL1.betaDataTableAdapters.BetaTableAdapter betaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

