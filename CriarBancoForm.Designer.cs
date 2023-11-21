namespace Controle_Financeiro
{
    partial class CriarBancoForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            btnIniciar = new Button();
            btnCancelar = new Button();
            informaProgesso = new Label();
            btnAbrir = new Button();
            label1 = new Label();
            caminhoDoBanco = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 204);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(440, 23);
            progressBar1.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(65, 50);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(107, 59);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(255, 50);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 59);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // informaProgesso
            // 
            informaProgesso.AutoSize = true;
            informaProgesso.Location = new Point(16, 186);
            informaProgesso.Name = "informaProgesso";
            informaProgesso.Size = new Size(0, 15);
            informaProgesso.TabIndex = 3;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(107, 115);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(223, 59);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir Aplicação";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Visible = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 23);
            label1.Name = "label1";
            label1.Size = new Size(329, 15);
            label1.TabIndex = 5;
            label1.Text = "Clique em iniciar, para começar a criação do Banco de Dados";
            label1.Click += label1_Click;
            // 
            // caminhoDoBanco
            // 
            caminhoDoBanco.AutoSize = true;
            caminhoDoBanco.Location = new Point(18, 233);
            caminhoDoBanco.Name = "caminhoDoBanco";
            caminhoDoBanco.Size = new Size(0, 15);
            caminhoDoBanco.TabIndex = 6;
            // 
            // CriarBancoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 261);
            Controls.Add(caminhoDoBanco);
            Controls.Add(label1);
            Controls.Add(btnAbrir);
            Controls.Add(informaProgesso);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(progressBar1);
            Name = "CriarBancoForm";
            Text = "CriarBancoForm";
            Load += CriarBancoForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Button btnIniciar;
        private Button btnCancelar;
        private Label informaProgesso;
        private Button btnAbrir;
        private Label label1;
        private Label caminhoDoBanco;
    }
}