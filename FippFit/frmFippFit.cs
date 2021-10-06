using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FippFit
{
    public partial class frmFippFit : Form
    {
        DataTable dt = new DataTable();
        public frmFippFit()
        {
            InitializeComponent();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Idade");
            dt.Columns.Add("Dat.Cad.");
            dt.Columns.Add("RG");
            dt.Columns.Add("CPF");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Obs");
            dt.TableName = "dados";

            dgvFippFit.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            if (tbId.TextLength > 0 && tbNome.TextLength > 0 && tbIdade.TextLength > 0 && tbRg.TextLength > 0 && tbCpf.TextLength > 0 /*&& cbSexo.SelectedValue != null */&& tbTelefone.TextLength > 0 && tbEmail.TextLength > 0)
            {
                dr["ID"] = Convert.ToInt32(tbId.Text);
                dr["Nome"] = tbNome.Text;
                dr["Idade"] = Convert.ToInt32(tbIdade.Text);
                dr["Dat.Cad."] = dtpDataCad.Text;
                dr["RG"] = tbRg.Text;
                dr["CPF"] = tbCpf.Text;
                dr["Sexo"] = cbSexo.Text;
                dr["Telefone"] = Convert.ToInt64(tbTelefone.Text);
                dr["Email"] = tbEmail.Text;
                dr["Obs"] = tbObservacao.Text;
                dt.Rows.Add(dr);
                tbId.Clear();
                tbNome.Clear();
                tbIdade.Clear();
                tbRg.Clear();
                tbCpf.Clear();
                tbTelefone.Clear();
                tbEmail.Clear();
                tbObservacao.Clear();

                bCancelar.PerformClick();
            }
            else
                MessageBox.Show("Não foram preenchidos todos os campos!");
        }

        private void bBusca_Click(object sender, EventArgs e)
        {
            Busca bc = new Busca (dgvFippFit,dt);
            bc.ShowDialog();
        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = -1;
            tbId.Enabled = true;
            tbNome.Enabled = true;
            tbIdade.Enabled = true;
            dtpDataCad.Enabled = true;
            tbRg.Enabled = true;
            tbCpf.Enabled = true;
            cbSexo.Enabled = true;
            tbTelefone.Enabled = true;
            tbEmail.Enabled = true;
            bNovo.Enabled = false;
            bExcluir.Enabled = false;
            bBusca.Enabled = false;
            bConfirmar.Enabled = true;
            bCancelar.Enabled = true;
            tbObservacao.Enabled = true;
            tbId.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = -1;
            tbId.Enabled = false;
            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            dtpDataCad.Enabled = false;
            tbRg.Enabled = false;
            tbCpf.Enabled = false;
            cbSexo.Enabled = false;
            tbTelefone.Enabled = false;
            tbEmail.Enabled = false;
            bNovo.Enabled = true;
            bExcluir.Enabled = true;
            bBusca.Enabled = true;
            bConfirmar.Enabled = false;
            bCancelar.Enabled = false;
            bImportarFoto.Enabled = false;
            bRetirarFoto.Enabled = false;
            tbObservacao.Enabled = false;
        }
        public bool validateRg(string rg)
        {
            rg = rg.Replace("-", "").Replace(".", "").Replace(",", "");

            if (rg.Length == 9)
            {
                int[] n = new int[9];

                try
                {
                    n[0] = Convert.ToInt32(rg.Substring(0, 1));
                    n[1] = Convert.ToInt32(rg.Substring(1, 1));
                    n[2] = Convert.ToInt32(rg.Substring(2, 1));
                    n[3] = Convert.ToInt32(rg.Substring(3, 1));
                    n[4] = Convert.ToInt32(rg.Substring(4, 1));
                    n[5] = Convert.ToInt32(rg.Substring(5, 1));
                    n[6] = Convert.ToInt32(rg.Substring(6, 1));
                    n[7] = Convert.ToInt32(rg.Substring(7, 1));
                    if (rg.Substring(8, 1).Equals("x") || rg.Substring(8, 1).Equals("X"))
                    {
                        n[8] = 10;
                    }
                    else
                    {
                        n[8] = Convert.ToInt32(rg.Substring(8, 1));
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                n[0] *= 2;
                n[1] *= 3;
                n[2] *= 4;
                n[3] *= 5;
                n[4] *= 6;
                n[5] *= 7;
                n[6] *= 8;
                n[7] *= 9;
                n[8] *= 100;

                int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7] + n[8];
                if ((somaFinal % 11) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            if (sfdSalvar.ShowDialog() == DialogResult.OK)
            {
               dt.WriteXml(sfdSalvar.FileName);
            }
            Close();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void bImportarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = file.FileName;
            }
        }

        private void bRetirarFoto_Click(object sender, EventArgs e)
        {
            pbFoto.ImageLocation = null;
        }

        private void frmFippFit_Load(object sender, EventArgs e)
        {
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (dgvFippFit.CurrentRow != null)
            {
                pos = dgvFippFit.CurrentRow.Index;
                dt.Rows[pos].Delete();
            }
        }

        public static bool validaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public bool validarEmail(String email)
        {
            bool emailValido = false;

            //Expressão regular retirada de
            //https://msdn.microsoft.com/pt-br/library/01escwtf(v=vs.110).aspx
            string emailRegex = string.Format("{0}{1}",
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            try
            {
                emailValido = Regex.IsMatch(
                    email,
                    emailRegex);
            }
            catch (RegexMatchTimeoutException)
            {
                emailValido = false;
            }

            return emailValido;
        }
        private void tbId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbId_Leave(object sender, EventArgs e)
        {
            int i;
            if(tbId.TextLength > 0)
            if (!int.TryParse(tbId.Text, out i))
            {
                MessageBox.Show(tbId.Text + " ID Inválido");
                tbId.Clear();
                tbId.Focus();
            }
        }

        private void tbNome_Leave(object sender, EventArgs e)
        {
            if (tbNome.TextLength > 0)
                if (tbNome.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    MessageBox.Show(tbNome.Text + " Nome Inválido");
                    tbNome.Clear();
                    tbNome.Focus();
                }
        }

        private void tbIdade_Leave(object sender, EventArgs e)
        {
            int i;
            if (tbIdade.TextLength > 0)
                if (!int.TryParse(tbIdade.Text, out i))
                {
                    MessageBox.Show(tbIdade.Text + " Idade Inválida");
                    tbIdade.Clear();
                    tbIdade.Focus();
                }
        }

        private void tbRg_Leave(object sender, EventArgs e)
        {
            if (tbRg.TextLength > 0)
                if(!validateRg(tbRg.Text))
                {
                    MessageBox.Show(tbRg.Text + " RG Inválido");
                    tbRg.Clear();
                    tbRg.Focus();
                }
        }

        private void tbCpf_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tbCpf_Leave(object sender, EventArgs e)
        {
            if(tbCpf.TextLength > 0)
                if(!validaCPF(tbCpf.Text))
                {
                    MessageBox.Show(tbCpf.Text + " CPF Inválido");
                    tbCpf.Clear();
                    tbCpf.Focus();
                }
        }

        private void tbTelefone_Leave(object sender, EventArgs e)
        {
            if (tbTelefone.TextLength > 0)
            {
                string phonePattern = @"^"
                        + @"(?<countryCode>[+]?\d{1,3}\s?)?"
                        + @"(?<areaCode>[(]?\d{1,2}[)]?\s?)?"
                        + @"(?<numero>\d{3,4}[-]?\d{4})"
                        + @"$";

                Regex phoneValidator = new Regex(phonePattern);

                if (phoneValidator.IsMatch(tbTelefone.Text) == false)
                {
                    MessageBox.Show(tbTelefone.Text + " Telefone Inválido");
                    tbTelefone.Clear();
                    tbTelefone.Focus();
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if(tbEmail.TextLength > 0)
                if(!validarEmail(tbEmail.Text))
                {
                    MessageBox.Show(tbEmail.Text + " E-Mail Inválido");
                    tbEmail.Clear();
                    tbEmail.Focus();
                }
        }
    }
}
