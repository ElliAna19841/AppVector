namespace AppVector
{
    partial class frmPrincipal
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmBasicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAsignar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLongitud = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarPosicion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAvanzado = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarDeMenorAMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirCadaElementoDelVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeElementosCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeElementosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarValor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(103, 143);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(153, 135);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 20);
            this.txtValor.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(342, 132);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 24);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(103, 186);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBasicos,
            this.tsmAvanzado,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmBasicos
            // 
            this.tsmBasicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMostrar,
            this.tsmAsignar,
            this.tsmLongitud,
            this.tsmEliminar,
            this.tsmEliminarPosicion});
            this.tsmBasicos.Name = "tsmBasicos";
            this.tsmBasicos.Size = new System.Drawing.Size(58, 20);
            this.tsmBasicos.Text = "Basicos";
            // 
            // tsmMostrar
            // 
            this.tsmMostrar.Name = "tsmMostrar";
            this.tsmMostrar.Size = new System.Drawing.Size(234, 22);
            this.tsmMostrar.Text = "Mostrar Valor";
            this.tsmMostrar.Click += new System.EventHandler(this.tsmMostrar_Click);
            // 
            // tsmAsignar
            // 
            this.tsmAsignar.Name = "tsmAsignar";
            this.tsmAsignar.Size = new System.Drawing.Size(234, 22);
            this.tsmAsignar.Text = "Asignar Vector";
            this.tsmAsignar.Click += new System.EventHandler(this.tsmAsignar_Click);
            // 
            // tsmLongitud
            // 
            this.tsmLongitud.Name = "tsmLongitud";
            this.tsmLongitud.Size = new System.Drawing.Size(234, 22);
            this.tsmLongitud.Text = "Longitud";
            this.tsmLongitud.Click += new System.EventHandler(this.tsmLongitud_Click);
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(234, 22);
            this.tsmEliminar.Text = "Eliminar Ultimo";
            this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
            // 
            // tsmEliminarPosicion
            // 
            this.tsmEliminarPosicion.Name = "tsmEliminarPosicion";
            this.tsmEliminarPosicion.Size = new System.Drawing.Size(234, 22);
            this.tsmEliminarPosicion.Text = "Eliminar Elemento en Posicion";
            this.tsmEliminarPosicion.Click += new System.EventHandler(this.tsmEliminarPosicion_Click);
            // 
            // tsmAvanzado
            // 
            this.tsmAvanzado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirToolStripMenuItem,
            this.cantDeParesToolStripMenuItem,
            this.ordenarDeMenorAMayorToolStripMenuItem,
            this.invertirCadaElementoDelVectorToolStripMenuItem,
            this.cantidadDeElementosCapicuaToolStripMenuItem,
            this.cantidadDeElementosPrimosToolStripMenuItem});
            this.tsmAvanzado.Name = "tsmAvanzado";
            this.tsmAvanzado.Size = new System.Drawing.Size(71, 20);
            this.tsmAvanzado.Text = "Avanzado";
            this.tsmAvanzado.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // cantDeParesToolStripMenuItem
            // 
            this.cantDeParesToolStripMenuItem.Name = "cantDeParesToolStripMenuItem";
            this.cantDeParesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cantDeParesToolStripMenuItem.Text = "Cant.De Pares";
            this.cantDeParesToolStripMenuItem.Click += new System.EventHandler(this.cantDeParesToolStripMenuItem_Click);
            // 
            // ordenarDeMenorAMayorToolStripMenuItem
            // 
            this.ordenarDeMenorAMayorToolStripMenuItem.Name = "ordenarDeMenorAMayorToolStripMenuItem";
            this.ordenarDeMenorAMayorToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ordenarDeMenorAMayorToolStripMenuItem.Text = "Ordenar de Menor a Mayor";
            this.ordenarDeMenorAMayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarDeMenorAMayorToolStripMenuItem_Click);
            // 
            // invertirCadaElementoDelVectorToolStripMenuItem
            // 
            this.invertirCadaElementoDelVectorToolStripMenuItem.Name = "invertirCadaElementoDelVectorToolStripMenuItem";
            this.invertirCadaElementoDelVectorToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.invertirCadaElementoDelVectorToolStripMenuItem.Text = "Invertir Cada Elemento del Vector";
            this.invertirCadaElementoDelVectorToolStripMenuItem.Click += new System.EventHandler(this.invertirCadaElementoDelVectorToolStripMenuItem_Click);
            // 
            // cantidadDeElementosCapicuaToolStripMenuItem
            // 
            this.cantidadDeElementosCapicuaToolStripMenuItem.Name = "cantidadDeElementosCapicuaToolStripMenuItem";
            this.cantidadDeElementosCapicuaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cantidadDeElementosCapicuaToolStripMenuItem.Text = "Cantidad de Elementos Capicua";
            this.cantidadDeElementosCapicuaToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeElementosCapicuaToolStripMenuItem_Click);
            // 
            // cantidadDeElementosPrimosToolStripMenuItem
            // 
            this.cantidadDeElementosPrimosToolStripMenuItem.Name = "cantidadDeElementosPrimosToolStripMenuItem";
            this.cantidadDeElementosPrimosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cantidadDeElementosPrimosToolStripMenuItem.Text = "Cantidad de Elementos Primos";
            this.cantidadDeElementosPrimosToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeElementosPrimosToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmSalir.Text = "Salir";
            // 
            // btnMostrarValor
            // 
            this.btnMostrarValor.Location = new System.Drawing.Point(106, 226);
            this.btnMostrarValor.Name = "btnMostrarValor";
            this.btnMostrarValor.Size = new System.Drawing.Size(117, 23);
            this.btnMostrarValor.TabIndex = 7;
            this.btnMostrarValor.Text = "Mostrar Valor";
            this.btnMostrarValor.UseVisualStyleBackColor = true;
            this.btnMostrarValor.Click += new System.EventHandler(this.btnMostrarValor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.btnMostrarValor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmBasicos;
        private System.Windows.Forms.ToolStripMenuItem tsmMostrar;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignar;
        private System.Windows.Forms.ToolStripMenuItem tsmLongitud;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarPosicion;
        private System.Windows.Forms.ToolStripMenuItem tsmAvanzado;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem cantDeParesToolStripMenuItem;
        private System.Windows.Forms.Button btnMostrarValor;
        private System.Windows.Forms.ToolStripMenuItem ordenarDeMenorAMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirCadaElementoDelVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeElementosCapicuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeElementosPrimosToolStripMenuItem;
    }
}

