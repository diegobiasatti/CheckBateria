namespace Lenovo_G485_bateria_check
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_bat_actualiza = new System.Windows.Forms.Label();
            this.lbl_bat_status = new System.Windows.Forms.Label();
            this.lbl_bat = new System.Windows.Forms.Label();
            this.lbl_level_bat = new System.Windows.Forms.Label();
            this.pic_bat = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_descarga_bat = new System.Windows.Forms.Label();
            this.lbl_carga_bat = new System.Windows.Forms.Label();
            this.timer_bateria = new System.Windows.Forms.Timer(this.components);
            this.timer_carga = new System.Windows.Forms.Timer(this.components);
            this.timer_descarga = new System.Windows.Forms.Timer(this.components);
            this.timer_des = new System.Windows.Forms.Timer(this.components);
            this.timer_car = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.timer_reporta_estado = new System.Windows.Forms.Timer(this.components);
            this.t_uno = new System.Windows.Forms.Timer(this.components);
            this.t_dos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bat_actualiza
            // 
            this.lbl_bat_actualiza.AutoSize = true;
            this.lbl_bat_actualiza.Location = new System.Drawing.Point(9, 164);
            this.lbl_bat_actualiza.Name = "lbl_bat_actualiza";
            this.lbl_bat_actualiza.Size = new System.Drawing.Size(22, 13);
            this.lbl_bat_actualiza.TabIndex = 29;
            this.lbl_bat_actualiza.Text = " 10";
            this.lbl_bat_actualiza.Visible = false;
            // 
            // lbl_bat_status
            // 
            this.lbl_bat_status.AutoSize = true;
            this.lbl_bat_status.Location = new System.Drawing.Point(12, 137);
            this.lbl_bat_status.Name = "lbl_bat_status";
            this.lbl_bat_status.Size = new System.Drawing.Size(40, 13);
            this.lbl_bat_status.TabIndex = 28;
            this.lbl_bat_status.Text = "Bateria";
            this.lbl_bat_status.Visible = false;
            // 
            // lbl_bat
            // 
            this.lbl_bat.AutoSize = true;
            this.lbl_bat.Location = new System.Drawing.Point(12, 151);
            this.lbl_bat.Name = "lbl_bat";
            this.lbl_bat.Size = new System.Drawing.Size(19, 13);
            this.lbl_bat.TabIndex = 27;
            this.lbl_bat.Text = "80";
            this.lbl_bat.Visible = false;
            // 
            // lbl_level_bat
            // 
            this.lbl_level_bat.AutoSize = true;
            this.lbl_level_bat.BackColor = System.Drawing.Color.White;
            this.lbl_level_bat.Location = new System.Drawing.Point(57, 103);
            this.lbl_level_bat.Name = "lbl_level_bat";
            this.lbl_level_bat.Size = new System.Drawing.Size(15, 13);
            this.lbl_level_bat.TabIndex = 26;
            this.lbl_level_bat.Text = "%";
            this.lbl_level_bat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_bat
            // 
            this.pic_bat.Image = ((System.Drawing.Image)(resources.GetObject("pic_bat.Image")));
            this.pic_bat.Location = new System.Drawing.Point(34, 80);
            this.pic_bat.Name = "pic_bat";
            this.pic_bat.Size = new System.Drawing.Size(75, 140);
            this.pic_bat.TabIndex = 25;
            this.pic_bat.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "descarga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "carga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_descarga_bat
            // 
            this.lbl_descarga_bat.AutoSize = true;
            this.lbl_descarga_bat.Location = new System.Drawing.Point(9, 19);
            this.lbl_descarga_bat.Name = "lbl_descarga_bat";
            this.lbl_descarga_bat.Size = new System.Drawing.Size(115, 13);
            this.lbl_descarga_bat.TabIndex = 31;
            this.lbl_descarga_bat.Text = "Descarga de la Bateria";
            // 
            // lbl_carga_bat
            // 
            this.lbl_carga_bat.AutoSize = true;
            this.lbl_carga_bat.Location = new System.Drawing.Point(9, 53);
            this.lbl_carga_bat.Name = "lbl_carga_bat";
            this.lbl_carga_bat.Size = new System.Drawing.Size(97, 13);
            this.lbl_carga_bat.TabIndex = 30;
            this.lbl_carga_bat.Text = "Carga de la Bateria";
            // 
            // timer_bateria
            // 
            this.timer_bateria.Enabled = true;
            this.timer_bateria.Interval = 5400;
            this.timer_bateria.Tick += new System.EventHandler(this.timer_bateria_Tick);
            // 
            // timer_carga
            // 
            this.timer_carga.Enabled = true;
            this.timer_carga.Interval = 300;
            this.timer_carga.Tick += new System.EventHandler(this.timer_carga_Tick);
            // 
            // timer_descarga
            // 
            this.timer_descarga.Enabled = true;
            this.timer_descarga.Tick += new System.EventHandler(this.timer_descarga_Tick);
            // 
            // timer_des
            // 
            this.timer_des.Enabled = true;
            this.timer_des.Tick += new System.EventHandler(this.timer_des_Tick);
            // 
            // timer_car
            // 
            this.timer_car.Tick += new System.EventHandler(this.timer_car_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Descarga de la Bateria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Carga de la Bateria";
            // 
            // timer_check
            // 
            this.timer_check.Enabled = true;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // timer_reporta_estado
            // 
            this.timer_reporta_estado.Tick += new System.EventHandler(this.timer_reporta_estado_Tick);
            // 
            // t_uno
            // 
            this.t_uno.Enabled = true;
            this.t_uno.Tick += new System.EventHandler(this.t_uno_Tick);
            // 
            // t_dos
            // 
            this.t_dos.Enabled = true;
            this.t_dos.Tick += new System.EventHandler(this.t_dos_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_descarga_bat);
            this.Controls.Add(this.lbl_carga_bat);
            this.Controls.Add(this.lbl_bat_actualiza);
            this.Controls.Add(this.lbl_bat_status);
            this.Controls.Add(this.lbl_bat);
            this.Controls.Add(this.lbl_level_bat);
            this.Controls.Add(this.pic_bat);
            this.Location = new System.Drawing.Point(945, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bateria MT40II";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bat_actualiza;
        private System.Windows.Forms.Label lbl_bat_status;
        private System.Windows.Forms.Label lbl_bat;
        private System.Windows.Forms.Label lbl_level_bat;
        private System.Windows.Forms.PictureBox pic_bat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_descarga_bat;
        private System.Windows.Forms.Label lbl_carga_bat;
        private System.Windows.Forms.Timer timer_bateria;
        private System.Windows.Forms.Timer timer_carga;
        private System.Windows.Forms.Timer timer_descarga;
        private System.Windows.Forms.Timer timer_des;
        private System.Windows.Forms.Timer timer_car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Timer timer_reporta_estado;
        private System.Windows.Forms.Timer t_uno;
        private System.Windows.Forms.Timer t_dos;
    }
}

