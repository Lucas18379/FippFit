namespace FippFit
{
    partial class Busca
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSair = new System.Windows.Forms.Button();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lId = new System.Windows.Forms.Label();
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.bSair);
            this.panel1.Controls.Add(this.bPesquisar);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.lId);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 87);
            this.panel1.TabIndex = 0;
            // 
            // bSair
            // 
            this.bSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bSair.Location = new System.Drawing.Point(379, 26);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(82, 38);
            this.bSair.TabIndex = 2;
            this.bSair.Text = "Sair";
            this.bSair.UseVisualStyleBackColor = false;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // bPesquisar
            // 
            this.bPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bPesquisar.Location = new System.Drawing.Point(190, 26);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(81, 38);
            this.bPesquisar.TabIndex = 2;
            this.bPesquisar.Text = "Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = false;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(17, 36);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(157, 20);
            this.tbId.TabIndex = 1;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(14, 20);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(24, 16);
            this.lId.TabIndex = 0;
            this.lId.Text = "ID:";
            // 
            // dgvBusca
            // 
            this.dgvBusca.AllowUserToAddRows = false;
            this.dgvBusca.AllowUserToDeleteRows = false;
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Idade,
            this.DatCad,
            this.RG,
            this.CPF,
            this.Sexo,
            this.Telefone,
            this.Email});
            this.dgvBusca.Location = new System.Drawing.Point(12, 105);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.ReadOnly = true;
            this.dgvBusca.Size = new System.Drawing.Size(476, 268);
            this.dgvBusca.TabIndex = 1;
            this.dgvBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // DatCad
            // 
            this.DatCad.DataPropertyName = "Da.tCad.";
            this.DatCad.HeaderText = "DatCad";
            this.DatCad.Name = "DatCad";
            this.DatCad.ReadOnly = true;
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
            // Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(501, 386);
            this.Controls.Add(this.dgvBusca);
            this.Controls.Add(this.panel1);
            this.Name = "Busca";
            this.Text = "Busca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPesquisar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button bSair;
        private System.Windows.Forms.DataGridView dgvBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}