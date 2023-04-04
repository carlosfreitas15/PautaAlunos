namespace exPauta
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
            this.dgvPauta = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freguesia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quimica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filosofia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educacao_fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaAlunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numNegativasAlunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContarRaparigas = new System.Windows.Forms.Button();
            this.btnContarRapazesMaximinos = new System.Windows.Forms.Button();
            this.btnContarRapazesRaparigas = new System.Windows.Forms.Button();
            this.btnEncontrarMaisVelho = new System.Windows.Forms.Button();
            this.btnContarReprovadosComMediaSuperiorA12 = new System.Windows.Forms.Button();
            this.btnEncontrarMelhoresAlunos = new System.Windows.Forms.Button();
            this.btnEncontrarApelidos = new System.Windows.Forms.Button();
            this.lstReprovados = new System.Windows.Forms.ListBox();
            this.btnNomesFreguesias = new System.Windows.Forms.Button();
            this.lstNomesFreguesias = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPauta
            // 
            this.dgvPauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPauta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nomeAluno,
            this.Freguesia,
            this.Ano,
            this.Sexo,
            this.historia,
            this.moral,
            this.quimica,
            this.fisica,
            this.ingles,
            this.filosofia,
            this.geografia,
            this.educacao_fisica,
            this.dom1,
            this.dom2,
            this.mediaAlunos,
            this.numNegativasAlunos});
            this.dgvPauta.Location = new System.Drawing.Point(16, 15);
            this.dgvPauta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPauta.Name = "dgvPauta";
            this.dgvPauta.RowHeadersWidth = 51;
            this.dgvPauta.Size = new System.Drawing.Size(1705, 589);
            this.dgvPauta.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "Nº";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "NOME";
            this.nomeAluno.MinimumWidth = 6;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Width = 125;
            // 
            // Freguesia
            // 
            this.Freguesia.HeaderText = "FREGUESIA";
            this.Freguesia.MinimumWidth = 6;
            this.Freguesia.Name = "Freguesia";
            this.Freguesia.Width = 125;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "ANO";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 125;
            // 
            // historia
            // 
            this.historia.HeaderText = "HIS";
            this.historia.MinimumWidth = 6;
            this.historia.Name = "historia";
            this.historia.Width = 125;
            // 
            // moral
            // 
            this.moral.HeaderText = "MOR";
            this.moral.MinimumWidth = 6;
            this.moral.Name = "moral";
            this.moral.Width = 125;
            // 
            // quimica
            // 
            this.quimica.HeaderText = "QIM";
            this.quimica.MinimumWidth = 6;
            this.quimica.Name = "quimica";
            this.quimica.Width = 125;
            // 
            // fisica
            // 
            this.fisica.HeaderText = "FIS";
            this.fisica.MinimumWidth = 6;
            this.fisica.Name = "fisica";
            this.fisica.Width = 125;
            // 
            // ingles
            // 
            this.ingles.HeaderText = "ING";
            this.ingles.MinimumWidth = 6;
            this.ingles.Name = "ingles";
            this.ingles.Width = 125;
            // 
            // filosofia
            // 
            this.filosofia.HeaderText = "FIL";
            this.filosofia.MinimumWidth = 6;
            this.filosofia.Name = "filosofia";
            this.filosofia.Width = 125;
            // 
            // geografia
            // 
            this.geografia.HeaderText = "GEO";
            this.geografia.MinimumWidth = 6;
            this.geografia.Name = "geografia";
            this.geografia.Width = 125;
            // 
            // educacao_fisica
            // 
            this.educacao_fisica.HeaderText = "EDF";
            this.educacao_fisica.MinimumWidth = 6;
            this.educacao_fisica.Name = "educacao_fisica";
            this.educacao_fisica.Width = 125;
            // 
            // dom1
            // 
            this.dom1.HeaderText = "POR";
            this.dom1.MinimumWidth = 6;
            this.dom1.Name = "dom1";
            this.dom1.Width = 125;
            // 
            // dom2
            // 
            this.dom2.HeaderText = "MAT";
            this.dom2.MinimumWidth = 6;
            this.dom2.Name = "dom2";
            this.dom2.Width = 125;
            // 
            // mediaAlunos
            // 
            this.mediaAlunos.HeaderText = "MEDIA";
            this.mediaAlunos.MinimumWidth = 6;
            this.mediaAlunos.Name = "mediaAlunos";
            this.mediaAlunos.Width = 125;
            // 
            // numNegativasAlunos
            // 
            this.numNegativasAlunos.HeaderText = "NºNEGATIVAS";
            this.numNegativasAlunos.MinimumWidth = 6;
            this.numNegativasAlunos.Name = "numNegativasAlunos";
            this.numNegativasAlunos.Width = 125;
            // 
            // btnContarRaparigas
            // 
            this.btnContarRaparigas.Location = new System.Drawing.Point(16, 612);
            this.btnContarRaparigas.Margin = new System.Windows.Forms.Padding(4);
            this.btnContarRaparigas.Name = "btnContarRaparigas";
            this.btnContarRaparigas.Size = new System.Drawing.Size(133, 63);
            this.btnContarRaparigas.TabIndex = 1;
            this.btnContarRaparigas.Text = "QUANTAS RAPARIGAS HA?";
            this.btnContarRaparigas.UseVisualStyleBackColor = true;
            this.btnContarRaparigas.Click += new System.EventHandler(this.btnContarRaparigas_Click);
            // 
            // btnContarRapazesMaximinos
            // 
            this.btnContarRapazesMaximinos.Location = new System.Drawing.Point(157, 612);
            this.btnContarRapazesMaximinos.Margin = new System.Windows.Forms.Padding(4);
            this.btnContarRapazesMaximinos.Name = "btnContarRapazesMaximinos";
            this.btnContarRapazesMaximinos.Size = new System.Drawing.Size(133, 63);
            this.btnContarRapazesMaximinos.TabIndex = 2;
            this.btnContarRapazesMaximinos.Text = "QUANTOS RAPAZES SAO DE MAXIMINOS?";
            this.btnContarRapazesMaximinos.UseVisualStyleBackColor = true;
            this.btnContarRapazesMaximinos.Click += new System.EventHandler(this.btnContarRapazesMaximinos_Click);
            // 
            // btnContarRapazesRaparigas
            // 
            this.btnContarRapazesRaparigas.Location = new System.Drawing.Point(298, 612);
            this.btnContarRapazesRaparigas.Margin = new System.Windows.Forms.Padding(4);
            this.btnContarRapazesRaparigas.Name = "btnContarRapazesRaparigas";
            this.btnContarRapazesRaparigas.Size = new System.Drawing.Size(133, 63);
            this.btnContarRapazesRaparigas.TabIndex = 3;
            this.btnContarRapazesRaparigas.Text = "HA MAIS RAPAZES OU RAPARIGAS?";
            this.btnContarRapazesRaparigas.UseVisualStyleBackColor = true;
            this.btnContarRapazesRaparigas.Click += new System.EventHandler(this.btnContarRapazesRaparigas_Click);
            // 
            // btnEncontrarMaisVelho
            // 
            this.btnEncontrarMaisVelho.Location = new System.Drawing.Point(439, 612);
            this.btnEncontrarMaisVelho.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncontrarMaisVelho.Name = "btnEncontrarMaisVelho";
            this.btnEncontrarMaisVelho.Size = new System.Drawing.Size(133, 63);
            this.btnEncontrarMaisVelho.TabIndex = 4;
            this.btnEncontrarMaisVelho.Text = "QUEM E O MAIS VELHO?";
            this.btnEncontrarMaisVelho.UseVisualStyleBackColor = true;
            this.btnEncontrarMaisVelho.Click += new System.EventHandler(this.btnEncontrarMaisVelho_Click);
            // 
            // btnContarReprovadosComMediaSuperiorA12
            // 
            this.btnContarReprovadosComMediaSuperiorA12.Location = new System.Drawing.Point(580, 612);
            this.btnContarReprovadosComMediaSuperiorA12.Margin = new System.Windows.Forms.Padding(4);
            this.btnContarReprovadosComMediaSuperiorA12.Name = "btnContarReprovadosComMediaSuperiorA12";
            this.btnContarReprovadosComMediaSuperiorA12.Size = new System.Drawing.Size(172, 63);
            this.btnContarReprovadosComMediaSuperiorA12.TabIndex = 5;
            this.btnContarReprovadosComMediaSuperiorA12.Text = "QUANTOS REPROVADOS TÊM MEDIA SUPERIOR A 12?";
            this.btnContarReprovadosComMediaSuperiorA12.UseVisualStyleBackColor = true;
            this.btnContarReprovadosComMediaSuperiorA12.Click += new System.EventHandler(this.btnContarReprovadosComMediaSuperiorA12_Click);
            // 
            // btnEncontrarMelhoresAlunos
            // 
            this.btnEncontrarMelhoresAlunos.Location = new System.Drawing.Point(760, 612);
            this.btnEncontrarMelhoresAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncontrarMelhoresAlunos.Name = "btnEncontrarMelhoresAlunos";
            this.btnEncontrarMelhoresAlunos.Size = new System.Drawing.Size(133, 63);
            this.btnEncontrarMelhoresAlunos.TabIndex = 6;
            this.btnEncontrarMelhoresAlunos.Text = "3 MELHORES ALUNOS";
            this.btnEncontrarMelhoresAlunos.UseVisualStyleBackColor = true;
            this.btnEncontrarMelhoresAlunos.Click += new System.EventHandler(this.btnEncontrarMelhoresAlunos_Click);
            // 
            // btnEncontrarApelidos
            // 
            this.btnEncontrarApelidos.Location = new System.Drawing.Point(952, 611);
            this.btnEncontrarApelidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncontrarApelidos.Name = "btnEncontrarApelidos";
            this.btnEncontrarApelidos.Size = new System.Drawing.Size(133, 63);
            this.btnEncontrarApelidos.TabIndex = 7;
            this.btnEncontrarApelidos.Text = "APELIDOS REPROVADOS";
            this.btnEncontrarApelidos.UseVisualStyleBackColor = true;
            this.btnEncontrarApelidos.Click += new System.EventHandler(this.btnEncontrarApelidos_Click);
            // 
            // lstReprovados
            // 
            this.lstReprovados.FormattingEnabled = true;
            this.lstReprovados.ItemHeight = 16;
            this.lstReprovados.Location = new System.Drawing.Point(1093, 612);
            this.lstReprovados.Margin = new System.Windows.Forms.Padding(4);
            this.lstReprovados.Name = "lstReprovados";
            this.lstReprovados.Size = new System.Drawing.Size(128, 116);
            this.lstReprovados.TabIndex = 8;
            // 
            // btnNomesFreguesias
            // 
            this.btnNomesFreguesias.Location = new System.Drawing.Point(1294, 611);
            this.btnNomesFreguesias.Name = "btnNomesFreguesias";
            this.btnNomesFreguesias.Size = new System.Drawing.Size(133, 63);
            this.btnNomesFreguesias.TabIndex = 9;
            this.btnNomesFreguesias.Text = "NOMES E FREGUESIAS DOS ALUNOS";
            this.btnNomesFreguesias.UseVisualStyleBackColor = true;
            this.btnNomesFreguesias.Click += new System.EventHandler(this.btnNomesFreguesias_Click);
            // 
            // lstNomesFreguesias
            // 
            this.lstNomesFreguesias.FormattingEnabled = true;
            this.lstNomesFreguesias.ItemHeight = 16;
            this.lstNomesFreguesias.Location = new System.Drawing.Point(1433, 611);
            this.lstNomesFreguesias.Name = "lstNomesFreguesias";
            this.lstNomesFreguesias.Size = new System.Drawing.Size(288, 116);
            this.lstNomesFreguesias.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 741);
            this.Controls.Add(this.lstNomesFreguesias);
            this.Controls.Add(this.btnNomesFreguesias);
            this.Controls.Add(this.lstReprovados);
            this.Controls.Add(this.btnEncontrarApelidos);
            this.Controls.Add(this.btnEncontrarMelhoresAlunos);
            this.Controls.Add(this.btnContarReprovadosComMediaSuperiorA12);
            this.Controls.Add(this.btnEncontrarMaisVelho);
            this.Controls.Add(this.btnContarRapazesRaparigas);
            this.Controls.Add(this.btnContarRapazesMaximinos);
            this.Controls.Add(this.btnContarRaparigas);
            this.Controls.Add(this.dgvPauta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "I";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPauta;
        private System.Windows.Forms.Button btnContarRaparigas;
        private System.Windows.Forms.Button btnContarRapazesMaximinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freguesia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn historia;
        private System.Windows.Forms.DataGridViewTextBoxColumn moral;
        private System.Windows.Forms.DataGridViewTextBoxColumn quimica;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingles;
        private System.Windows.Forms.DataGridViewTextBoxColumn filosofia;
        private System.Windows.Forms.DataGridViewTextBoxColumn geografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn educacao_fisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numNegativasAlunos;
        private System.Windows.Forms.Button btnContarRapazesRaparigas;
        private System.Windows.Forms.Button btnEncontrarMaisVelho;
        private System.Windows.Forms.Button btnContarReprovadosComMediaSuperiorA12;
        private System.Windows.Forms.Button btnEncontrarMelhoresAlunos;
        private System.Windows.Forms.Button btnEncontrarApelidos;
        private System.Windows.Forms.ListBox lstReprovados;
        private System.Windows.Forms.Button btnNomesFreguesias;
        private System.Windows.Forms.ListBox lstNomesFreguesias;
    }
}

