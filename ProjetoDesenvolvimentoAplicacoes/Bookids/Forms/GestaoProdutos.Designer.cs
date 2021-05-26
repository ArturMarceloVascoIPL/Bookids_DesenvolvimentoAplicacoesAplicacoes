﻿
namespace Bookids.Forms
{
    partial class GestaoProdutos
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Panel();
            this.buttonPesquisarProdutos = new System.Windows.Forms.Panel();
            this.textBoxPesquisaProdutos = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelEditProdutos = new System.Windows.Forms.Panel();
            this.textBoxDesignacao = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAddTipos = new System.Windows.Forms.Button();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelEditTipos = new System.Windows.Forms.Panel();
            this.buttonApagarTipo = new System.Windows.Forms.Button();
            this.textBoxNomeTipo = new System.Windows.Forms.TextBox();
            this.listBoxTipos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancelarTipo = new System.Windows.Forms.Button();
            this.buttonSalvarTipo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipPesquisa = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.panelEditProdutos.SuspendLayout();
            this.panelEditTipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(826, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Image = global::Bookids.Properties.Resources.baseline_home_black_24dp;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarRecenteToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // editarRecenteToolStripMenuItem
            // 
            this.editarRecenteToolStripMenuItem.Name = "editarRecenteToolStripMenuItem";
            this.editarRecenteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editarRecenteToolStripMenuItem.Text = "Editar Recente";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRecenteToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // verRecenteToolStripMenuItem
            // 
            this.verRecenteToolStripMenuItem.Name = "verRecenteToolStripMenuItem";
            this.verRecenteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verRecenteToolStripMenuItem.Text = "Ver Recente";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.editarTiposToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            // 
            // editarTiposToolStripMenuItem
            // 
            this.editarTiposToolStripMenuItem.Name = "editarTiposToolStripMenuItem";
            this.editarTiposToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editarTiposToolStripMenuItem.Text = "Editar Tipos";
            // 
            // panelProdutos
            // 
            this.panelProdutos.Controls.Add(this.buttonRefresh);
            this.panelProdutos.Controls.Add(this.buttonPesquisarProdutos);
            this.panelProdutos.Controls.Add(this.textBoxPesquisaProdutos);
            this.panelProdutos.Controls.Add(this.buttonApagar);
            this.panelProdutos.Controls.Add(this.buttonEditar);
            this.panelProdutos.Controls.Add(this.buttonNovo);
            this.panelProdutos.Controls.Add(this.listBoxProdutos);
            this.panelProdutos.Controls.Add(this.label4);
            this.panelProdutos.Location = new System.Drawing.Point(11, 30);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(334, 398);
            this.panelProdutos.TabIndex = 4;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRefresh.BackgroundImage = global::Bookids.Properties.Resources.baseline_autorenew_black_24dp;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(40, 26);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(22, 20);
            this.buttonRefresh.TabIndex = 61;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPesquisarProdutos
            // 
            this.buttonPesquisarProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPesquisarProdutos.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.buttonPesquisarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisarProdutos.Location = new System.Drawing.Point(14, 26);
            this.buttonPesquisarProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPesquisarProdutos.Name = "buttonPesquisarProdutos";
            this.buttonPesquisarProdutos.Size = new System.Drawing.Size(22, 20);
            this.buttonPesquisarProdutos.TabIndex = 60;
            this.buttonPesquisarProdutos.Click += new System.EventHandler(this.buttonPesquisarProdutos_Click);
            // 
            // textBoxPesquisaProdutos
            // 
            this.textBoxPesquisaProdutos.Location = new System.Drawing.Point(66, 26);
            this.textBoxPesquisaProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesquisaProdutos.Name = "textBoxPesquisaProdutos";
            this.textBoxPesquisaProdutos.Size = new System.Drawing.Size(257, 20);
            this.textBoxPesquisaProdutos.TabIndex = 59;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(222, 344);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(100, 52);
            this.buttonApagar.TabIndex = 20;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(118, 344);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 52);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(14, 344);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 52);
            this.buttonNovo.TabIndex = 18;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovoProduto_Click);
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.Location = new System.Drawing.Point(14, 50);
            this.listBoxProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(309, 290);
            this.listBoxProdutos.TabIndex = 16;
            this.listBoxProdutos.SelectedIndexChanged += new System.EventHandler(this.listBoxProdutos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Produtos";
            // 
            // panelEditProdutos
            // 
            this.panelEditProdutos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEditProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditProdutos.Controls.Add(this.textBoxDesignacao);
            this.panelEditProdutos.Controls.Add(this.buttonCancelar);
            this.panelEditProdutos.Controls.Add(this.buttonSalvar);
            this.panelEditProdutos.Controls.Add(this.buttonAddTipos);
            this.panelEditProdutos.Controls.Add(this.comboBoxTipoProduto);
            this.panelEditProdutos.Controls.Add(this.label5);
            this.panelEditProdutos.Controls.Add(this.textBoxStock);
            this.panelEditProdutos.Controls.Add(this.label2);
            this.panelEditProdutos.Controls.Add(this.label1);
            this.panelEditProdutos.Controls.Add(this.textBoxPreco);
            this.panelEditProdutos.Controls.Add(this.label3);
            this.panelEditProdutos.Enabled = false;
            this.panelEditProdutos.Location = new System.Drawing.Point(349, 128);
            this.panelEditProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.panelEditProdutos.Name = "panelEditProdutos";
            this.panelEditProdutos.Size = new System.Drawing.Size(291, 180);
            this.panelEditProdutos.TabIndex = 5;
            // 
            // textBoxDesignacao
            // 
            this.textBoxDesignacao.Location = new System.Drawing.Point(93, 12);
            this.textBoxDesignacao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDesignacao.Name = "textBoxDesignacao";
            this.textBoxDesignacao.Size = new System.Drawing.Size(192, 20);
            this.textBoxDesignacao.TabIndex = 33;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(185, 124);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 52);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(2, 124);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 52);
            this.buttonSalvar.TabIndex = 22;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonAddTipos
            // 
            this.buttonAddTipos.Location = new System.Drawing.Point(193, 61);
            this.buttonAddTipos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTipos.Name = "buttonAddTipos";
            this.buttonAddTipos.Size = new System.Drawing.Size(92, 21);
            this.buttonAddTipos.TabIndex = 32;
            this.buttonAddTipos.Text = "Editar Tipos +";
            this.buttonAddTipos.UseVisualStyleBackColor = true;
            this.buttonAddTipos.Click += new System.EventHandler(this.btnAddTipos_Click);
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(93, 61);
            this.comboBoxTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(96, 21);
            this.comboBoxTipoProduto.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo Prod:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(93, 86);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(96, 20);
            this.textBoxStock.TabIndex = 29;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Designação:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(93, 37);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(96, 20);
            this.textBoxPreco.TabIndex = 26;
            this.textBoxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPreco_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Preço:";
            // 
            // panelEditTipos
            // 
            this.panelEditTipos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEditTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditTipos.Controls.Add(this.buttonApagarTipo);
            this.panelEditTipos.Controls.Add(this.textBoxNomeTipo);
            this.panelEditTipos.Controls.Add(this.listBoxTipos);
            this.panelEditTipos.Controls.Add(this.label6);
            this.panelEditTipos.Controls.Add(this.buttonCancelarTipo);
            this.panelEditTipos.Controls.Add(this.buttonSalvarTipo);
            this.panelEditTipos.Controls.Add(this.label8);
            this.panelEditTipos.Enabled = false;
            this.panelEditTipos.Location = new System.Drawing.Point(644, 56);
            this.panelEditTipos.Margin = new System.Windows.Forms.Padding(2);
            this.panelEditTipos.Name = "panelEditTipos";
            this.panelEditTipos.Size = new System.Drawing.Size(175, 344);
            this.panelEditTipos.TabIndex = 33;
            // 
            // buttonApagarTipo
            // 
            this.buttonApagarTipo.Location = new System.Drawing.Point(94, 263);
            this.buttonApagarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarTipo.Name = "buttonApagarTipo";
            this.buttonApagarTipo.Size = new System.Drawing.Size(70, 35);
            this.buttonApagarTipo.TabIndex = 35;
            this.buttonApagarTipo.Text = "Apagar";
            this.buttonApagarTipo.UseVisualStyleBackColor = false;
            this.buttonApagarTipo.Click += new System.EventHandler(this.buttonApagarTipo_Click);
            // 
            // textBoxNomeTipo
            // 
            this.textBoxNomeTipo.Location = new System.Drawing.Point(57, 239);
            this.textBoxNomeTipo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeTipo.Name = "textBoxNomeTipo";
            this.textBoxNomeTipo.Size = new System.Drawing.Size(107, 20);
            this.textBoxNomeTipo.TabIndex = 34;
            // 
            // listBoxTipos
            // 
            this.listBoxTipos.FormattingEnabled = true;
            this.listBoxTipos.Location = new System.Drawing.Point(7, 23);
            this.listBoxTipos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTipos.Name = "listBoxTipos";
            this.listBoxTipos.Size = new System.Drawing.Size(157, 212);
            this.listBoxTipos.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nome:";
            // 
            // buttonCancelarTipo
            // 
            this.buttonCancelarTipo.Location = new System.Drawing.Point(7, 302);
            this.buttonCancelarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelarTipo.Name = "buttonCancelarTipo";
            this.buttonCancelarTipo.Size = new System.Drawing.Size(157, 35);
            this.buttonCancelarTipo.TabIndex = 23;
            this.buttonCancelarTipo.Text = "Cancelar";
            this.buttonCancelarTipo.UseVisualStyleBackColor = false;
            this.buttonCancelarTipo.Click += new System.EventHandler(this.buttonCancelarTipo_Click);
            // 
            // buttonSalvarTipo
            // 
            this.buttonSalvarTipo.Location = new System.Drawing.Point(7, 263);
            this.buttonSalvarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvarTipo.Name = "buttonSalvarTipo";
            this.buttonSalvarTipo.Size = new System.Drawing.Size(70, 35);
            this.buttonSalvarTipo.TabIndex = 22;
            this.buttonSalvarTipo.Text = "Salvar";
            this.buttonSalvarTipo.UseVisualStyleBackColor = false;
            this.buttonSalvarTipo.Click += new System.EventHandler(this.buttonSalvarTipo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "TIPOS";
            // 
            // toolTipPesquisa
            // 
            this.toolTipPesquisa.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPesquisa.ToolTipTitle = "Pesquisa por Designação";
            // 
            // toolTipRefresh
            // 
            this.toolTipRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipRefresh.ToolTipTitle = "Limpar Filtro";
            // 
            // GestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 431);
            this.Controls.Add(this.panelEditTipos);
            this.Controls.Add(this.panelEditProdutos);
            this.Controls.Add(this.panelProdutos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GestaoProdutos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GestaoProdutos";
            this.Load += new System.EventHandler(this.GestaoProdutos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.panelEditProdutos.ResumeLayout(false);
            this.panelEditProdutos.PerformLayout();
            this.panelEditTipos.ResumeLayout(false);
            this.panelEditTipos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTiposToolStripMenuItem;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelEditProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipoProduto;
        private System.Windows.Forms.Button buttonAddTipos;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel buttonRefresh;
        private System.Windows.Forms.Panel buttonPesquisarProdutos;
        private System.Windows.Forms.TextBox textBoxPesquisaProdutos;
        private System.Windows.Forms.TextBox textBoxDesignacao;
        private System.Windows.Forms.Panel panelEditTipos;
        private System.Windows.Forms.Button buttonApagarTipo;
        private System.Windows.Forms.TextBox textBoxNomeTipo;
        private System.Windows.Forms.ListBox listBoxTipos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancelarTipo;
        private System.Windows.Forms.Button buttonSalvarTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipPesquisa;
        private System.Windows.Forms.ToolTip toolTipRefresh;
    }
}