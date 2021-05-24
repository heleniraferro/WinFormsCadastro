using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTela.Model;

namespace WinFormsTela
{
    public partial class frmCadastroPessoas : Form
    {
        private bool selecionado;
        public frmCadastroPessoas()
        {
            InitializeComponent();
        }

        #region Eventos

        /// <summary>
        /// Evento Botão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string validacampos = ValidaCampos();
            if(!string.IsNullOrEmpty(validacampos))
            {
                MessageBox.Show(validacampos);
                return;
            }

            lstwPessoas.Items.Add(new ListViewItem(Items()));
            Limpar();
            MessageBox.Show("Cadastro Realizado com sucesso!");

        }
        /// <summary>
        /// Verifica o que foi digitado em txtIdade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstwPessoas.Items)
            {
                if (item.Selected)
                {
                    lstwPessoas.Items.RemoveAt(item.Index);
                    btnAdicionar.Show();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (selecionado)
            {
                string validacampos = ValidaCampos();
                if (!string.IsNullOrEmpty(validacampos))
                {
                    MessageBox.Show(validacampos);
                    return;
                }
                string[] item = new string[6];
                item[0] = txtName.Text;
                item[1] = txtIdade.Text;
                item[2] = txtTelefone.Text;
                item[3] = txtEmail.Text;
                item[4] = cbbxProfissao.SelectedItem.ToString();
                item[5] = txtFormacao.Text;
                int selectIndex = lstwPessoas.SelectedIndices[0];
                lstwPessoas.Items.RemoveAt(selectIndex);
                lstwPessoas.Items.Insert(selectIndex, new ListViewItem(item));
                Limpar();
                MessageBox.Show("Cadastro aterado com sucesso!");
            }
        }

        private void lstwPessoas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                txtName.Text = lstwPessoas.SelectedItems[0].SubItems[0].Text;
                txtIdade.Text = lstwPessoas.SelectedItems[0].SubItems[1].Text;
                txtTelefone.Text = lstwPessoas.SelectedItems[0].SubItems[2].Text;
                txtEmail.Text = lstwPessoas.SelectedItems[0].SubItems[3].Text;
                cbbxProfissao.SelectedItem = lstwPessoas.SelectedItems[0].SubItems[4].Text;
                txtFormacao.Text = lstwPessoas.SelectedItems[0].SubItems[5].Text;
                selecionado = true;
                btnAdicionar.Hide();
            }
            else
            { 
                selecionado = false;
                btnAdicionar.Show();
                Limpar();
            }
        }

        #endregion

        #region Metodos
        public void Limpar()
        {
            txtName.Text = "";
            txtIdade.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            cbbxProfissao.SelectedIndex = -1;
            txtFormacao.Text = "";
        }
        public string[] Items()
        {
            string[] item = new string[6];
            item[0] = txtName.Text;
            item[1] = txtIdade.Text;
            item[2] = txtTelefone.Text;
            item[3] = txtEmail.Text;
            item[4] = cbbxProfissao.SelectedItem.ToString();
            item[5] = txtFormacao.Text;
            return item;
        }
        public string ValidaCampos()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                return (MensagemRetorno("Nome"));
            }
            else if (string.IsNullOrEmpty(txtIdade.Text))
            {
                return (MensagemRetorno("Idade"));
            }
            else if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                return (MensagemRetorno("Telefone"));
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                return (MensagemRetorno("E-mail"));
            }
            else if (cbbxProfissao.SelectedItem==null)
            {
                return (MensagemRetorno("Profissão"));
            }
            else if (string.IsNullOrEmpty(txtFormacao.Text))
            {
                return (MensagemRetorno("Formação"));
            }
            else
                return "";

        }
        public string MensagemRetorno(string campo)
        {
            return $"Você deve informar o campo {campo}";
        }


        #endregion


    }
}
