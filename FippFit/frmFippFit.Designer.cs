namespace FippFit
{
    partial class frmFippFit
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSair = new System.Windows.Forms.Button();
            this.bBusca = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lId = new System.Windows.Forms.Label();
            this.lNome = new System.Windows.Forms.Label();
            this.lIdade = new System.Windows.Forms.Label();
            this.lDataCad = new System.Windows.Forms.Label();
            this.lRg = new System.Windows.Forms.Label();
            this.lCpf = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.tbRg = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.lObservacao = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lTelefone = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.bImportarFoto = new System.Windows.Forms.Button();
            this.gbFoto = new System.Windows.Forms.GroupBox();
            this.bRetirarFoto = new System.Windows.Forms.Button();
            this.lSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.dgvFippFit = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfdSalvar = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFippFit)).BeginInit();
            this.SuspendLayout();
            // 
            // bNovo
            // 
            this.bNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNovo.Location = new System.Drawing.Point(15, 8);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(101, 46);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSair);
            this.panel1.Controls.Add(this.bBusca);
            this.panel1.Controls.Add(this.bExcluir);
            this.panel1.Controls.Add(this.bCancelar);
            this.panel1.Controls.Add(this.bConfirmar);
            this.panel1.Controls.Add(this.bNovo);
            this.panel1.Location = new System.Drawing.Point(12, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 60);
            this.panel1.TabIndex = 1;
            // 
            // bSair
            // 
            this.bSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSair.Location = new System.Drawing.Point(707, 9);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(111, 46);
            this.bSair.TabIndex = 1;
            this.bSair.Text = "Sair";
            this.bSair.UseVisualStyleBackColor = false;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // bBusca
            // 
            this.bBusca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBusca.Location = new System.Drawing.Point(590, 8);
            this.bBusca.Name = "bBusca";
            this.bBusca.Size = new System.Drawing.Size(111, 46);
            this.bBusca.TabIndex = 0;
            this.bBusca.Text = "Busca";
            this.bBusca.UseVisualStyleBackColor = false;
            this.bBusca.Click += new System.EventHandler(this.bBusca_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluir.Location = new System.Drawing.Point(366, 8);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(111, 46);
            this.bExcluir.TabIndex = 0;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = false;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCancelar.Enabled = false;
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(239, 8);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(111, 46);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bConfirmar.Enabled = false;
            this.bConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(122, 8);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(111, 46);
            this.bConfirmar.TabIndex = 0;
            this.bConfirmar.Text = "&Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(88, 50);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 2;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            this.tbId.Leave += new System.EventHandler(this.tbId_Leave);
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(56, 52);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(26, 18);
            this.lId.TabIndex = 3;
            this.lId.Text = "ID:";
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNome.Location = new System.Drawing.Point(29, 89);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(53, 18);
            this.lNome.TabIndex = 3;
            this.lNome.Text = "Nome:";
            // 
            // lIdade
            // 
            this.lIdade.AutoSize = true;
            this.lIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdade.Location = new System.Drawing.Point(35, 125);
            this.lIdade.Name = "lIdade";
            this.lIdade.Size = new System.Drawing.Size(47, 18);
            this.lIdade.TabIndex = 3;
            this.lIdade.Text = "Idade:";
            // 
            // lDataCad
            // 
            this.lDataCad.AutoSize = true;
            this.lDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataCad.Location = new System.Drawing.Point(4, 162);
            this.lDataCad.Name = "lDataCad";
            this.lDataCad.Size = new System.Drawing.Size(78, 18);
            this.lDataCad.TabIndex = 3;
            this.lDataCad.Text = "Data Cad.:";
            // 
            // lRg
            // 
            this.lRg.AutoSize = true;
            this.lRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRg.Location = new System.Drawing.Point(47, 203);
            this.lRg.Name = "lRg";
            this.lRg.Size = new System.Drawing.Size(35, 18);
            this.lRg.TabIndex = 3;
            this.lRg.Text = "RG:";
            // 
            // lCpf
            // 
            this.lCpf.AutoSize = true;
            this.lCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCpf.Location = new System.Drawing.Point(40, 243);
            this.lCpf.Name = "lCpf";
            this.lCpf.Size = new System.Drawing.Size(42, 18);
            this.lCpf.TabIndex = 3;
            this.lCpf.Text = "CPF:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(88, 87);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(326, 20);
            this.tbNome.TabIndex = 2;
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // tbIdade
            // 
            this.tbIdade.Enabled = false;
            this.tbIdade.Location = new System.Drawing.Point(88, 123);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(53, 20);
            this.tbIdade.TabIndex = 2;
            this.tbIdade.Leave += new System.EventHandler(this.tbIdade_Leave);
            // 
            // tbRg
            // 
            this.tbRg.Enabled = false;
            this.tbRg.Location = new System.Drawing.Point(88, 201);
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(124, 20);
            this.tbRg.TabIndex = 2;
            this.tbRg.Leave += new System.EventHandler(this.tbRg_Leave);
            // 
            // tbCpf
            // 
            this.tbCpf.Enabled = false;
            this.tbCpf.Location = new System.Drawing.Point(88, 241);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(124, 20);
            this.tbCpf.TabIndex = 2;
            this.tbCpf.Leave += new System.EventHandler(this.tbCpf_Leave);
            this.tbCpf.MouseLeave += new System.EventHandler(this.tbCpf_MouseLeave);
            // 
            // lObservacao
            // 
            this.lObservacao.AutoSize = true;
            this.lObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lObservacao.Location = new System.Drawing.Point(40, 282);
            this.lObservacao.Name = "lObservacao";
            this.lObservacao.Size = new System.Drawing.Size(101, 18);
            this.lObservacao.TabIndex = 3;
            this.lObservacao.Text = "Observações:";
            // 
            // tbObservacao
            // 
            this.tbObservacao.Enabled = false;
            this.tbObservacao.Location = new System.Drawing.Point(43, 303);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(552, 46);
            this.tbObservacao.TabIndex = 2;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pbFoto.Location = new System.Drawing.Point(31, 19);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(143, 165);
            this.pbFoto.TabIndex = 4;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // lTelefone
            // 
            this.lTelefone.AutoSize = true;
            this.lTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefone.Location = new System.Drawing.Point(230, 202);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(69, 18);
            this.lTelefone.TabIndex = 3;
            this.lTelefone.Text = "Telefone:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(245, 243);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(54, 18);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "E-mail:";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Location = new System.Drawing.Point(305, 200);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(136, 20);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.Leave += new System.EventHandler(this.tbTelefone_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(305, 244);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(227, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // bImportarFoto
            // 
            this.bImportarFoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bImportarFoto.Enabled = false;
            this.bImportarFoto.Location = new System.Drawing.Point(31, 190);
            this.bImportarFoto.Name = "bImportarFoto";
            this.bImportarFoto.Size = new System.Drawing.Size(143, 23);
            this.bImportarFoto.TabIndex = 5;
            this.bImportarFoto.Text = "Importar";
            this.bImportarFoto.UseVisualStyleBackColor = false;
            this.bImportarFoto.Click += new System.EventHandler(this.bImportarFoto_Click);
            // 
            // gbFoto
            // 
            this.gbFoto.Controls.Add(this.pbFoto);
            this.gbFoto.Controls.Add(this.bRetirarFoto);
            this.gbFoto.Controls.Add(this.bImportarFoto);
            this.gbFoto.Location = new System.Drawing.Point(645, 26);
            this.gbFoto.Name = "gbFoto";
            this.gbFoto.Size = new System.Drawing.Size(200, 259);
            this.gbFoto.TabIndex = 6;
            this.gbFoto.TabStop = false;
            this.gbFoto.Text = "Foto";
            // 
            // bRetirarFoto
            // 
            this.bRetirarFoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRetirarFoto.Enabled = false;
            this.bRetirarFoto.Location = new System.Drawing.Point(31, 215);
            this.bRetirarFoto.Name = "bRetirarFoto";
            this.bRetirarFoto.Size = new System.Drawing.Size(143, 23);
            this.bRetirarFoto.TabIndex = 5;
            this.bRetirarFoto.Text = "Retirar";
            this.bRetirarFoto.UseVisualStyleBackColor = false;
            this.bRetirarFoto.Click += new System.EventHandler(this.bRetirarFoto_Click);
            // 
            // lSexo
            // 
            this.lSexo.AutoSize = true;
            this.lSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSexo.Location = new System.Drawing.Point(253, 160);
            this.lSexo.Name = "lSexo";
            this.lSexo.Size = new System.Drawing.Size(46, 18);
            this.lSexo.TabIndex = 3;
            this.lSexo.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Enabled = false;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(306, 162);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(56, 21);
            this.cbSexo.TabIndex = 7;
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Enabled = false;
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(89, 162);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(123, 20);
            this.dtpDataCad.TabIndex = 4;
            // 
            // dgvFippFit
            // 
            this.dgvFippFit.AllowUserToAddRows = false;
            this.dgvFippFit.AllowUserToDeleteRows = false;
            this.dgvFippFit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFippFit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Idade,
            this.DataCad,
            this.RG,
            this.CPF,
            this.Sexo,
            this.Telefone,
            this.Email,
            this.Observação});
            this.dgvFippFit.Location = new System.Drawing.Point(43, 369);
            this.dgvFippFit.Name = "dgvFippFit";
            this.dgvFippFit.ReadOnly = true;
            this.dgvFippFit.Size = new System.Drawing.Size(776, 100);
            this.dgvFippFit.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // DataCad
            // 
            this.DataCad.DataPropertyName = "Dat.Cad.";
            this.DataCad.HeaderText = "Dat.Cad.";
            this.DataCad.Name = "DataCad";
            this.DataCad.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Observação
            // 
            this.Observação.DataPropertyName = "Obs";
            this.Observação.HeaderText = "Observação";
            this.Observação.Name = "Observação";
            this.Observação.ReadOnly = true;
            // 
            // sfdSalvar
            // 
            this.sfdSalvar.Filter = "ArquivoXML|*.xml";
            // 
            // frmFippFit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(857, 561);
            this.Controls.Add(this.dgvFippFit);
            this.Controls.Add(this.dtpDataCad);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.gbFoto);
            this.Controls.Add(this.lObservacao);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lSexo);
            this.Controls.Add(this.lTelefone);
            this.Controls.Add(this.lCpf);
            this.Controls.Add(this.lRg);
            this.Controls.Add(this.lDataCad);
            this.Controls.Add(this.lIdade);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbRg);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.panel1);
            this.Name = "frmFippFit";
            this.Text = "frmFippFit";
            this.Load += new System.EventHandler(this.frmFippFit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFippFit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBusca;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lIdade;
        private System.Windows.Forms.Label lDataCad;
        private System.Windows.Forms.Label lRg;
        private System.Windows.Forms.Label lCpf;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label lObservacao;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button bImportarFoto;
        private System.Windows.Forms.GroupBox gbFoto;
        private System.Windows.Forms.Button bRetirarFoto;
        private System.Windows.Forms.Label lSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.DataGridView dgvFippFit;
        private System.Windows.Forms.SaveFileDialog sfdSalvar;
        private System.Windows.Forms.Button bSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
    }
}

