namespace projetRoutageForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_type_interface = new System.Windows.Forms.TextBox();
            this.tb_nom_interface = new System.Windows.Forms.TextBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_interface_ajoute = new System.Windows.Forms.Label();
            this.cb_nombreInterface = new System.Windows.Forms.ComboBox();
            this.bt_console = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_msg = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::projetRoutageForms.Properties.Resources.fchhh;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lab_interface_ajoute);
            this.panel1.Controls.Add(this.cb_nombreInterface);
            this.panel1.Controls.Add(this.bt_console);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab_msg);
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 276);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::projetRoutageForms.Properties.Resources.ghghji;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_type_interface);
            this.panel2.Controls.Add(this.tb_nom_interface);
            this.panel2.Controls.Add(this.bt_ajouter);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(419, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 103);
            this.panel2.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Type :";
            // 
            // tb_type_interface
            // 
            this.tb_type_interface.Location = new System.Drawing.Point(75, 42);
            this.tb_type_interface.Name = "tb_type_interface";
            this.tb_type_interface.Size = new System.Drawing.Size(128, 20);
            this.tb_type_interface.TabIndex = 45;
            // 
            // tb_nom_interface
            // 
            this.tb_nom_interface.Location = new System.Drawing.Point(75, 17);
            this.tb_nom_interface.Name = "tb_nom_interface";
            this.tb_nom_interface.Size = new System.Drawing.Size(128, 20);
            this.tb_nom_interface.TabIndex = 42;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.Transparent;
            this.bt_ajouter.BackgroundImage = global::projetRoutageForms.Properties.Resources.fchhh;
            this.bt_ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter.Location = new System.Drawing.Point(131, 68);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(72, 23);
            this.bt_ajouter.TabIndex = 30;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(155, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "remettre tout à zéro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(626, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "CONFIGURATION                                                                    " +
                "                                                                                " +
                "                     ";
            // 
            // lab_interface_ajoute
            // 
            this.lab_interface_ajoute.AutoSize = true;
            this.lab_interface_ajoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_interface_ajoute.ForeColor = System.Drawing.SystemColors.Control;
            this.lab_interface_ajoute.Location = new System.Drawing.Point(35, 99);
            this.lab_interface_ajoute.Name = "lab_interface_ajoute";
            this.lab_interface_ajoute.Size = new System.Drawing.Size(0, 15);
            this.lab_interface_ajoute.TabIndex = 40;
            // 
            // cb_nombreInterface
            // 
            this.cb_nombreInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nombreInterface.FormattingEnabled = true;
            this.cb_nombreInterface.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_nombreInterface.Location = new System.Drawing.Point(158, 67);
            this.cb_nombreInterface.Name = "cb_nombreInterface";
            this.cb_nombreInterface.Size = new System.Drawing.Size(35, 24);
            this.cb_nombreInterface.TabIndex = 39;
            this.cb_nombreInterface.SelectedIndexChanged += new System.EventHandler(this.cb_nombreInterface_SelectedIndexChanged);
            // 
            // bt_console
            // 
            this.bt_console.BackgroundImage = global::projetRoutageForms.Properties.Resources.Image1;
            this.bt_console.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_console.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_console.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_console.Location = new System.Drawing.Point(419, 231);
            this.bt_console.Name = "bt_console";
            this.bt_console.Size = new System.Drawing.Size(229, 28);
            this.bt_console.TabIndex = 38;
            this.bt_console.Text = "Ligne de commande";
            this.bt_console.UseVisualStyleBackColor = true;
            this.bt_console.Visible = false;
            this.bt_console.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre d\'interface";
            // 
            // lab_msg
            // 
            this.lab_msg.AutoSize = true;
            this.lab_msg.BackColor = System.Drawing.Color.Transparent;
            this.lab_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_msg.Location = new System.Drawing.Point(198, 11);
            this.lab_msg.Name = "lab_msg";
            this.lab_msg.Size = new System.Drawing.Size(272, 24);
            this.lab_msg.TabIndex = 47;
            this.lab_msg.Text = "Tous les interfaces sont ajoutés";
            this.lab_msg.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::projetRoutageForms.Properties.Resources.Image2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::projetRoutageForms.Properties.Resources.scsc;
            this.pictureBox2.Location = new System.Drawing.Point(148, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(522, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "sekOuzed production";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 162);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetRoutageForms.Properties.Resources.Sanvh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(699, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(709, 469);
            this.MinimumSize = new System.Drawing.Size(709, 469);
            this.Name = "Form1";
            this.Text = "projet de routage | DIOUBATE SEKOU_LSI-1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_nombreInterface;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_interface_ajoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_console;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nom_interface;
        private System.Windows.Forms.TextBox tb_type_interface;
        private System.Windows.Forms.Label lab_msg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

