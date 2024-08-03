namespace windows_form_II
{
    partial class Form1
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_estagio = new System.Windows.Forms.RadioButton();
            this.rdb_efetivo = new System.Windows.Forms.RadioButton();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_java = new System.Windows.Forms.CheckBox();
            this.chk_ts = new System.Windows.Forms.CheckBox();
            this.chk_php = new System.Windows.Forms.CheckBox();
            this.chk_python = new System.Windows.Forms.CheckBox();
            this.chk_cs = new System.Windows.Forms.CheckBox();
            this.chk_sql = new System.Windows.Forms.CheckBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(117, 31);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(131, 20);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_efetivo);
            this.groupBox1.Controls.Add(this.rdb_estagio);
            this.groupBox1.Location = new System.Drawing.Point(79, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Contrato";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_estagio
            // 
            this.rdb_estagio.AutoSize = true;
            this.rdb_estagio.Location = new System.Drawing.Point(17, 34);
            this.rdb_estagio.Name = "rdb_estagio";
            this.rdb_estagio.Size = new System.Drawing.Size(60, 17);
            this.rdb_estagio.TabIndex = 0;
            this.rdb_estagio.TabStop = true;
            this.rdb_estagio.Text = "Estagio";
            this.rdb_estagio.UseVisualStyleBackColor = true;
            this.rdb_estagio.CheckedChanged += new System.EventHandler(this.rdb_estagio_CheckedChanged);
            // 
            // rdb_efetivo
            // 
            this.rdb_efetivo.AutoSize = true;
            this.rdb_efetivo.Location = new System.Drawing.Point(88, 34);
            this.rdb_efetivo.Name = "rdb_efetivo";
            this.rdb_efetivo.Size = new System.Drawing.Size(58, 17);
            this.rdb_efetivo.TabIndex = 1;
            this.rdb_efetivo.TabStop = true;
            this.rdb_efetivo.Text = "Efetivo";
            this.rdb_efetivo.UseVisualStyleBackColor = true;
            this.rdb_efetivo.CheckedChanged += new System.EventHandler(this.rdb_eletivo_CheckedChanged);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(80, 155);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(168, 30);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registros";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // txt_registro
            // 
            this.txt_registro.Location = new System.Drawing.Point(81, 226);
            this.txt_registro.Multiline = true;
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(583, 167);
            this.txt_registro.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_sql);
            this.groupBox2.Controls.Add(this.chk_cs);
            this.groupBox2.Controls.Add(this.chk_python);
            this.groupBox2.Controls.Add(this.chk_php);
            this.groupBox2.Controls.Add(this.chk_ts);
            this.groupBox2.Controls.Add(this.chk_java);
            this.groupBox2.Location = new System.Drawing.Point(284, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 118);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experiências";
            // 
            // chk_java
            // 
            this.chk_java.AutoSize = true;
            this.chk_java.Location = new System.Drawing.Point(7, 20);
            this.chk_java.Name = "chk_java";
            this.chk_java.Size = new System.Drawing.Size(49, 17);
            this.chk_java.TabIndex = 0;
            this.chk_java.Text = "Java";
            this.chk_java.UseVisualStyleBackColor = true;
            // 
            // chk_ts
            // 
            this.chk_ts.AutoSize = true;
            this.chk_ts.Location = new System.Drawing.Point(7, 53);
            this.chk_ts.Name = "chk_ts";
            this.chk_ts.Size = new System.Drawing.Size(77, 17);
            this.chk_ts.TabIndex = 1;
            this.chk_ts.Text = "TypeScript";
            this.chk_ts.UseVisualStyleBackColor = true;
            // 
            // chk_php
            // 
            this.chk_php.AutoSize = true;
            this.chk_php.Location = new System.Drawing.Point(7, 84);
            this.chk_php.Name = "chk_php";
            this.chk_php.Size = new System.Drawing.Size(48, 17);
            this.chk_php.TabIndex = 2;
            this.chk_php.Text = "PHP";
            this.chk_php.UseVisualStyleBackColor = true;
            // 
            // chk_python
            // 
            this.chk_python.AutoSize = true;
            this.chk_python.Location = new System.Drawing.Point(109, 20);
            this.chk_python.Name = "chk_python";
            this.chk_python.Size = new System.Drawing.Size(59, 17);
            this.chk_python.TabIndex = 3;
            this.chk_python.Text = "Python";
            this.chk_python.UseVisualStyleBackColor = true;
            // 
            // chk_cs
            // 
            this.chk_cs.AutoSize = true;
            this.chk_cs.Location = new System.Drawing.Point(109, 53);
            this.chk_cs.Name = "chk_cs";
            this.chk_cs.Size = new System.Drawing.Size(40, 17);
            this.chk_cs.TabIndex = 4;
            this.chk_cs.Text = "C#";
            this.chk_cs.UseVisualStyleBackColor = true;
            // 
            // chk_sql
            // 
            this.chk_sql.AutoSize = true;
            this.chk_sql.Location = new System.Drawing.Point(109, 84);
            this.chk_sql.Name = "chk_sql";
            this.chk_sql.Size = new System.Drawing.Size(47, 17);
            this.chk_sql.TabIndex = 5;
            this.chk_sql.Text = "SQL";
            this.chk_sql.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(284, 155);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(200, 30);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_registro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_efetivo;
        private System.Windows.Forms.RadioButton rdb_estagio;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_sql;
        private System.Windows.Forms.CheckBox chk_cs;
        private System.Windows.Forms.CheckBox chk_python;
        private System.Windows.Forms.CheckBox chk_php;
        private System.Windows.Forms.CheckBox chk_ts;
        private System.Windows.Forms.CheckBox chk_java;
        private System.Windows.Forms.Button btn_limpar;
    }
}

