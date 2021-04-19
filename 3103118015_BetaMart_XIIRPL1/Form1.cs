using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3103118015_BetaMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                txtNB.Focus();
                this.betaData.Beta.AddBetaRow(this.betaData.Beta.NewBetaRow());
                betaBindingSource1.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaBindingSource1.ResetBindings(false);
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            betaBindingSource1.ResetBindings(false);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            try
            {
                betaBindingSource1.EndEdit();
                betaTableAdapter.Update(this.betaData.Beta);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaBindingSource1.ResetBindings(false);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Menghapusnya ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                betaBindingSource1.RemoveCurrent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'betaData.Beta' table. You can move, or remove it, as needed.
            this.betaTableAdapter.Fill(this.betaData.Beta);
            // TODO: This line of code loads data into the 'betaData.Beta' table. You can move, or remove it, as needed.
            this.betaTableAdapter.Fill(this.betaData.Beta);
            // TODO: This line of code loads data into the 'betaData.Beta' table. You can move, or remove it, as needed.
            this.betaTableAdapter.Fill(this.betaData.Beta);
            betaBindingSource1.DataSource = this.betaData.Beta;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Anda Yakin Ingin Menghapusnya ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    betaBindingSource1.RemoveCurrent();
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox9.Text)) dataGridView1.DataSource = betaBindingSource1;
                else
                {
                    var query = from o in this.betaData.Beta
                                where o.NamaBarang.Contains(textBox9.Text) || o.KodeBarang.Contains(textBox9.Text) ||
                                o.BeratBarang.Contains(textBox9.Text) || o.Kategori.Contains(textBox9.Text) ||
                                o.TanggalMasuk.Contains(textBox9.Text) || o.Supplier.Contains(textBox9.Text) ||
                                o.Penerima.Contains(textBox9.Text) || o.StockBarang.Contains(textBox9.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void betaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
