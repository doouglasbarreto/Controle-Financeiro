namespace Controle_Financeiro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem = new ToolStripMenuItem();
            oDSToolStripMenuItem = new ToolStripMenuItem();
            xLSXToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            alterarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            excluirUsuárioToolStripMenuItem = new ToolStripMenuItem();
            grupoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarGrupoToolStripMenuItem = new ToolStripMenuItem();
            editarGrupoToolStripMenuItem = new ToolStripMenuItem();
            excluirGrupoToolStripMenuItem = new ToolStripMenuItem();
            contasToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            vScrollBar1 = new VScrollBar();
            toolTipInfo = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ContextMenuStrip = contextMenuStrip1;
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(vScrollBar1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 70);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(118, 22);
            toolStripMenuItem1.Text = "Copiar";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(118, 22);
            toolStripMenuItem2.Text = "Recortar";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(118, 22);
            toolStripMenuItem3.Text = "Colar";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastroToolStripMenuItem, contasToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imprimirToolStripMenuItem, exportarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 21);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(120, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDFToolStripMenuItem, cSVToolStripMenuItem, oDSToolStripMenuItem, xLSXToolStripMenuItem });
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(120, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(100, 22);
            pDFToolStripMenuItem.Text = "PDF";
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(100, 22);
            cSVToolStripMenuItem.Text = "CSV";
            // 
            // oDSToolStripMenuItem
            // 
            oDSToolStripMenuItem.Name = "oDSToolStripMenuItem";
            oDSToolStripMenuItem.Size = new Size(100, 22);
            oDSToolStripMenuItem.Text = "ODS";
            // 
            // xLSXToolStripMenuItem
            // 
            xLSXToolStripMenuItem.Name = "xLSXToolStripMenuItem";
            xLSXToolStripMenuItem.Size = new Size(100, 22);
            xLSXToolStripMenuItem.Text = "XLSX";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, grupoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 21);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuárioToolStripMenuItem, alterarUsuárioToolStripMenuItem, excluirUsuárioToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(119, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            cadastrarUsuárioToolStripMenuItem.Size = new Size(167, 22);
            cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            cadastrarUsuárioToolStripMenuItem.ToolTipText = "Para realizar o cadastramento de Usuários";
            cadastrarUsuárioToolStripMenuItem.Click += cadastrarUsuárioToolStripMenuItem_Click;
            // 
            // alterarUsuárioToolStripMenuItem
            // 
            alterarUsuárioToolStripMenuItem.Name = "alterarUsuárioToolStripMenuItem";
            alterarUsuárioToolStripMenuItem.Size = new Size(167, 22);
            alterarUsuárioToolStripMenuItem.Text = "Alterar Usuário";
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            excluirUsuárioToolStripMenuItem.Size = new Size(167, 22);
            excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
            // 
            // grupoToolStripMenuItem
            // 
            grupoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarGrupoToolStripMenuItem, editarGrupoToolStripMenuItem, excluirGrupoToolStripMenuItem });
            grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            grupoToolStripMenuItem.Size = new Size(119, 22);
            grupoToolStripMenuItem.Text = "Grupo";
            // 
            // cadastrarGrupoToolStripMenuItem
            // 
            cadastrarGrupoToolStripMenuItem.Name = "cadastrarGrupoToolStripMenuItem";
            cadastrarGrupoToolStripMenuItem.Size = new Size(160, 22);
            cadastrarGrupoToolStripMenuItem.Text = "Cadastrar Grupo";
            // 
            // editarGrupoToolStripMenuItem
            // 
            editarGrupoToolStripMenuItem.Name = "editarGrupoToolStripMenuItem";
            editarGrupoToolStripMenuItem.Size = new Size(160, 22);
            editarGrupoToolStripMenuItem.Text = "Editar Grupo";
            // 
            // excluirGrupoToolStripMenuItem
            // 
            excluirGrupoToolStripMenuItem.Name = "excluirGrupoToolStripMenuItem";
            excluirGrupoToolStripMenuItem.Size = new Size(160, 22);
            excluirGrupoToolStripMenuItem.Text = "Excluir Grupo";
            // 
            // contasToolStripMenuItem
            // 
            contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            contasToolStripMenuItem.Size = new Size(56, 21);
            contasToolStripMenuItem.Text = "Contas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 21);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vScrollBar1.Enabled = false;
            vScrollBar1.Location = new Point(783, 25);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 425);
            vScrollBar1.TabIndex = 1;
            // 
            // toolTipInfo
            // 
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Controle Financeiro";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem contasToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private ToolStripMenuItem alterarUsuárioToolStripMenuItem;
        private ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem oDSToolStripMenuItem;
        private ToolStripMenuItem xLSXToolStripMenuItem;
        private ToolStripMenuItem grupoToolStripMenuItem;
        private ToolStripMenuItem cadastrarGrupoToolStripMenuItem;
        private ToolStripMenuItem editarGrupoToolStripMenuItem;
        private ToolStripMenuItem excluirGrupoToolStripMenuItem;
        private ToolTip toolTipInfo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private VScrollBar vScrollBar1;
    }
}