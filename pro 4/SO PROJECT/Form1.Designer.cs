namespace YoNunca
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.conectar = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.RadioButton();
            this.aceptar = new System.Windows.Forms.Button();
            this.ganador = new System.Windows.Forms.RadioButton();
            this.winrate = new System.Windows.Forms.RadioButton();
            this.desconectar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listacon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conectados = new System.Windows.Forms.Label();
            this.labnombre = new System.Windows.Forms.Label();
            this.nombre_dame = new System.Windows.Forms.TextBox();
            this.labfecha = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.TextBox();
            this.edadmedia = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(168, 97);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(167, 22);
            this.nombre.TabIndex = 12;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(168, 143);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(167, 22);
            this.contraseña.TabIndex = 13;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(17, 12);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(1258, 58);
            this.conectar.TabIndex = 15;
            this.conectar.Text = "CONNECT";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(127, 192);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(64, 21);
            this.login.TabIndex = 16;
            this.login.TabStop = true;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(17, 454);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(147, 47);
            this.aceptar.TabIndex = 17;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_click);
            // 
            // ganador
            // 
            this.ganador.AutoSize = true;
            this.ganador.Location = new System.Drawing.Point(12, 345);
            this.ganador.Name = "ganador";
            this.ganador.Size = new System.Drawing.Size(85, 21);
            this.ganador.TabIndex = 18;
            this.ganador.TabStop = true;
            this.ganador.Text = "Ganador";
            this.ganador.UseVisualStyleBackColor = true;
            this.ganador.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // winrate
            // 
            this.winrate.AutoSize = true;
            this.winrate.Location = new System.Drawing.Point(11, 397);
            this.winrate.Name = "winrate";
            this.winrate.Size = new System.Drawing.Size(117, 21);
            this.winrate.TabIndex = 19;
            this.winrate.TabStop = true;
            this.winrate.Text = "% de victorias";
            this.winrate.UseVisualStyleBackColor = true;
            this.winrate.CheckedChanged += new System.EventHandler(this.aceptar_click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(16, 507);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(1274, 58);
            this.desconectar.TabIndex = 20;
            this.desconectar.Text = "DISCONNECT";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listacon});
            this.dataGridView1.Location = new System.Drawing.Point(451, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(168, 225);
            this.dataGridView1.TabIndex = 27;
            // 
            // listacon
            // 
            this.listacon.HeaderText = "Lista de conectados";
            this.listacon.Name = "listacon";
            // 
            // Conectados
            // 
            this.Conectados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Conectados.Location = new System.Drawing.Point(1095, 425);
            this.Conectados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Conectados.Name = "Conectados";
            this.Conectados.Size = new System.Drawing.Size(195, 49);
            this.Conectados.TabIndex = 28;
            this.Conectados.Text = "Conectados";
            // 
            // labnombre
            // 
            this.labnombre.AutoSize = true;
            this.labnombre.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnombre.Location = new System.Drawing.Point(15, 275);
            this.labnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnombre.Name = "labnombre";
            this.labnombre.Size = new System.Drawing.Size(63, 20);
            this.labnombre.TabIndex = 32;
            this.labnombre.Text = "Nombre";
            // 
            // nombre_dame
            // 
            this.nombre_dame.Location = new System.Drawing.Point(86, 275);
            this.nombre_dame.Margin = new System.Windows.Forms.Padding(4);
            this.nombre_dame.Name = "nombre_dame";
            this.nombre_dame.Size = new System.Drawing.Size(167, 22);
            this.nombre_dame.TabIndex = 31;
            // 
            // labfecha
            // 
            this.labfecha.AutoSize = true;
            this.labfecha.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labfecha.Location = new System.Drawing.Point(12, 237);
            this.labfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labfecha.Name = "labfecha";
            this.labfecha.Size = new System.Drawing.Size(45, 20);
            this.labfecha.TabIndex = 29;
            this.labfecha.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(86, 237);
            this.fecha.Margin = new System.Windows.Forms.Padding(4);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(167, 22);
            this.fecha.TabIndex = 30;
            // 
            // edadmedia
            // 
            this.edadmedia.AutoSize = true;
            this.edadmedia.Location = new System.Drawing.Point(168, 345);
            this.edadmedia.Name = "edadmedia";
            this.edadmedia.Size = new System.Drawing.Size(199, 21);
            this.edadmedia.TabIndex = 33;
            this.edadmedia.TabStop = true;
            this.edadmedia.Text = "Edad media de registrados";
            this.edadmedia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 586);
            this.Controls.Add(this.edadmedia);
            this.Controls.Add(this.labnombre);
            this.Controls.Add(this.nombre_dame);
            this.Controls.Add(this.labfecha);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Conectados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.winrate);
            this.Controls.Add(this.ganador);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.login);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.RadioButton login;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.RadioButton ganador;
        private System.Windows.Forms.RadioButton winrate;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listacon;
        private System.Windows.Forms.Label Conectados;
        private System.Windows.Forms.Label labnombre;
        private System.Windows.Forms.TextBox nombre_dame;
        private System.Windows.Forms.Label labfecha;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.RadioButton edadmedia;
    }
}

