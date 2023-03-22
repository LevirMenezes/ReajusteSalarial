
namespace Reajuste_Salarial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnNoturno = new System.Windows.Forms.RadioButton();
            this.rbnVespertino = new System.Windows.Forms.RadioButton();
            this.rbnMatutino = new System.Windows.Forms.RadioButton();
            this.lstInformes = new System.Windows.Forms.ListBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Minímo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas trabalhadas:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(176, 16);
            this.txtSalarioMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(132, 22);
            this.txtSalarioMinimo.TabIndex = 2;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(176, 62);
            this.txtHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(132, 22);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnVeterano);
            this.groupBox1.Controls.Add(this.rbnCalouro);
            this.groupBox1.Location = new System.Drawing.Point(43, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.Location = new System.Drawing.Point(145, 23);
            this.rbnVeterano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(83, 20);
            this.rbnVeterano.TabIndex = 1;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            this.rbnVeterano.CheckedChanged += new System.EventHandler(this.rbnVeterano_CheckedChanged);
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.Location = new System.Drawing.Point(8, 23);
            this.rbnCalouro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(75, 20);
            this.rbnCalouro.TabIndex = 0;
            this.rbnCalouro.TabStop = true;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            this.rbnCalouro.CheckedChanged += new System.EventHandler(this.rbnCalouro_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnNoturno);
            this.groupBox2.Controls.Add(this.rbnVespertino);
            this.groupBox2.Controls.Add(this.rbnMatutino);
            this.groupBox2.Location = new System.Drawing.Point(395, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(171, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno";
            // 
            // rbnNoturno
            // 
            this.rbnNoturno.AutoSize = true;
            this.rbnNoturno.Location = new System.Drawing.Point(48, 149);
            this.rbnNoturno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnNoturno.Name = "rbnNoturno";
            this.rbnNoturno.Size = new System.Drawing.Size(75, 20);
            this.rbnNoturno.TabIndex = 2;
            this.rbnNoturno.TabStop = true;
            this.rbnNoturno.Text = "Noturno";
            this.rbnNoturno.UseVisualStyleBackColor = true;
            this.rbnNoturno.CheckedChanged += new System.EventHandler(this.rbnNoturno_CheckedChanged);
            // 
            // rbnVespertino
            // 
            this.rbnVespertino.AutoSize = true;
            this.rbnVespertino.Location = new System.Drawing.Point(48, 86);
            this.rbnVespertino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnVespertino.Name = "rbnVespertino";
            this.rbnVespertino.Size = new System.Drawing.Size(93, 20);
            this.rbnVespertino.TabIndex = 1;
            this.rbnVespertino.TabStop = true;
            this.rbnVespertino.Text = "Vespertino";
            this.rbnVespertino.UseVisualStyleBackColor = true;
            this.rbnVespertino.CheckedChanged += new System.EventHandler(this.rbnVespertino_CheckedChanged);
            // 
            // rbnMatutino
            // 
            this.rbnMatutino.AutoSize = true;
            this.rbnMatutino.Location = new System.Drawing.Point(48, 25);
            this.rbnMatutino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnMatutino.Name = "rbnMatutino";
            this.rbnMatutino.Size = new System.Drawing.Size(78, 20);
            this.rbnMatutino.TabIndex = 0;
            this.rbnMatutino.TabStop = true;
            this.rbnMatutino.Text = "Matutino";
            this.rbnMatutino.UseVisualStyleBackColor = true;
            this.rbnMatutino.CheckedChanged += new System.EventHandler(this.rbnMatutino_CheckedChanged);
            // 
            // lstInformes
            // 
            this.lstInformes.FormattingEnabled = true;
            this.lstInformes.ItemHeight = 16;
            this.lstInformes.Items.AddRange(new object[] {
            "Valor do coeficiente:",
            "Salário bruto:",
            "Valor do imposto:",
            "Valor da gratificação:",
            "Valor auxílio alimentação:",
            "Salário líquido:"});
            this.lstInformes.Location = new System.Drawing.Point(43, 210);
            this.lstInformes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstInformes.Name = "lstInformes";
            this.lstInformes.Size = new System.Drawing.Size(521, 148);
            this.lstInformes.TabIndex = 6;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.BackColor = System.Drawing.Color.Yellow;
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClassificacao.Location = new System.Drawing.Point(43, 382);
            this.txtClassificacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(384, 28);
            this.txtClassificacao.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(443, 382);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 28);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 427);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lstInformes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnVeterano;
        private System.Windows.Forms.RadioButton rbnCalouro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnNoturno;
        private System.Windows.Forms.RadioButton rbnVespertino;
        private System.Windows.Forms.RadioButton rbnMatutino;
        private System.Windows.Forms.ListBox lstInformes;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Button btnCalcular;
    }
}

