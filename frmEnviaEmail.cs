using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Threading;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Envio_Email
{
    public partial class Email : Form
    {
        private void Email_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        public Email()
        {
            InitializeComponent();
            btnEnviar.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Preencha o Campo Quantidades de E-mails para continuar...");
                txtEmail.Focus();
            }
            else
            {
                EnviaEmail();
                Valida();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            btnEnviar.Enabled = true;
            txtEmail.Enabled = true;
            txtPara.Text = dgvEmail[0, 0].Value.ToString();
            txtID.Text = dgvEmail[1, 0].Value.ToString();
        }

        int contador = 0;
        int linha = 0;
        int contEmailEnviado = 0;

        public void EnviaEmail()
        {
            MailMessage msg = new MailMessage();
            System.Net.NetworkCredential aCred = new System.Net.NetworkCredential("usuario", "senha");
            SmtpClient smtp = new SmtpClient("smtplw.com.br", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = aCred;

            for (int i = contEmailEnviado; i < Convert.ToInt32(txtEmail.Text); i++)
            {               
                try
                {                  
                    msg.From = new MailAddress(txtDe.Text);
                    msg.Subject = txtAssunto.Text;
                    msg.Body = txtMsg.Text;

                    if (troca == true)
                    {                     
                        foreach (var address in txtPara.Text.Split(';'))
                        {                          
                            msg.To.Add(new MailAddress(address, ""));
                        }
                                       
                        if (dgvEmail.SelectedRows.Count > 0 && dgvEmail.SelectedColumns.Count > 0)
                        {
                            linha = dgvEmail.SelectedRows[0].Index;
                        }
                        else
                        {
                            if (dgvEmail.SelectedCells.Count > 0 || dgvEmail.SelectedColumns.Count > 0)
                            {
                                linha = dgvEmail.SelectedCells[0].RowIndex;
                            }
                        }

                        contador = linha;
                        troca = false;
                    }
                    else
                    {     
                        foreach (var address in dgvEmail[0, contador].Value.ToString().Split(';'))
                        {
                            msg.To.Add(new MailAddress(address, ""));
                        }
                    }

                    foreach (string file in listBox1.Items)
                    {
                        msg.Attachments.Add(new System.Net.Mail.Attachment(file));
                    }

                    ObterEmail(txtPara.Text);
                 
                    if (txtTesteEmail.Text == txtPara.Text)
                    {
                        contador++;

                        txtPara.Text = "";
                        txtPara.Text = dgvEmail[0, contador].Value.ToString();
                    }
                    else
                    {
                        smtp.Send(msg);
                        EnviaEmailTabela(txtPara.Text);                      

                        contador++;

                        txtPara.Text = "";
                        txtPara.Text = dgvEmail[0, contador].Value.ToString();
                    }
                    msg.To.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }
            msg.Dispose();
            smtp.Dispose();

            MessageBox.Show("Concluido!");
        }       

        public void Valida()
        {
            if (txtDe.Text == "" || txtAssunto.Text == "" || txtPara.Text == "")
            {
                MessageBox.Show("Os Campos De, Para e Assunto devem ser preenchidos corretamente...");
                txtDe.Clear();
                txtAssunto.Clear();
                txtPara.Clear();
                txtDe.Focus();
            }
        }

        //Método para trocar email do txtPara ao dar duplo click
        public bool troca = false;
        public void EnviaDados(DataGridViewRow row)
        {
            txtID.Text = row.Cells["cod_escritorio"].Value.ToString(); //servidor 99
            txtPara.Text = row.Cells["email"].Value.ToString();
            troca = true;
        }

        //troca email do txtPara ao dar duplo click
        public void dgvEmail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvEmail.Rows[e.RowIndex];
            EnviaDados(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPara.Clear();
            txtID.Clear();
            txtEmail.Clear();

            listBox1.ResetText();

            btnEnviar.Enabled = false;
            txtEmail.Enabled = false;
            contador = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        listBox1.Items.Add(file);
                    }
                }
            }
        }

        bool emailValido = false;
        public bool ValidarEmail(String email)
        {
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

        public void BuscaEmailRecente()
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                cn.ConnectionString = Dados.stringConexao;

                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "usp_EMAIL_RECENTE";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();

                da.SelectCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void ApagaTabela()
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                cn.ConnectionString = Dados.stringConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "usp_APAGA_TABELA";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();

                da.SelectCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public string SelecionaEmail()
        {
            DataTable EmailAtual = new DataTable();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            string sql = "select * from EMAIL_ATUAL where DATA_ABERTURA > '2016-01-01' order by DATA_ABERTURA desc";

            SqlCommand cmd = new SqlCommand(sql, cn);

            cn.Open();

            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(EmailAtual);

            dgvEmail.DataSource = EmailAtual;

            return Convert.ToString(EmailAtual);
        }
        private void btnEmailRecente_Click(object sender, EventArgs e)
        {
            btnEnviar.Enabled = true;
            txtEmail.Enabled = true;

            ApagaTabela();
            BuscaEmailRecente();
            SelecionaEmail();

            txtPara.Text = dgvEmail[0, 0].Value.ToString();
            txtID.Text = dgvEmail[1, 0].Value.ToString();
        }


        public void EnviaEmailTabela(string email)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.stringConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "INSERE_EMAIL";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pemail = new SqlParameter("@EMAIL", System.Data.SqlDbType.NVarChar, 100);
                pemail.Value = email;
                cmd.Parameters.Add(pemail);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnLimpaTabela_Click(object sender, EventArgs e)
        {
            //limpar tabela que armazena e-mails enviados com truncate table
        }

        public class RecebeEmail
        {
            public string Email { get; set; }
        }

        public string ObterEmail(string email)
        {
            RecebeEmail retornaEmail = new RecebeEmail();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.stringConexao;

            string sql = "select email from email_enviado where email = @Email";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Email", email);

            cn.Open();
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                try
                {
                    retornaEmail.Email = leitor["email"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
            cn.Close();

            txtTesteEmail.Text = retornaEmail.Email;

            return txtTesteEmail.Text;

        }

        public void ApagaTabelaBanco()
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                cn.ConnectionString = Dados.stringConexao;

                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "usp_APAGA_EMAIL_ENVIADO";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();

                da.SelectCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL ERRO: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnLimparTabela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar os dados dos E-mails já enviados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ApagaTabelaBanco();              
            }
         
        }
    }
}

