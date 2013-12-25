using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetRoutage;
using System.Diagnostics;
using System.IO;

namespace projetRoutageForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int nombre_d_interface=0; int i;
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            if (i <= nombre_d_interface)
            {
                interfaces interfaceAajouter = new interfaces();

                interfaceAajouter.type = tb_type_interface.Text;
                interfaceAajouter.nom = tb_nom_interface.Text;
                commande.listeDesInterfaces.Add(interfaceAajouter);
                lab_interface_ajoute.Text = " Interface " +i+ " : " + tb_nom_interface.Text + " (" + tb_type_interface.Text + ") " + " a été ajouté";
                i++;
                if (i == nombre_d_interface+1)
                {
                    lab_msg.Visible = true;
                    bt_ajouter.Text = "TERMIER";
                    panel2.Enabled = false;
                    lab_interface_ajoute.Text = "Les interfaces ajoutés :\n";

                    StreamWriter w = File.AppendText(@"C:\interfaces.txt");
                    
                    foreach (interfaces j in commande.listeDesInterfaces)
                    {
                        lab_interface_ajoute.Text =lab_interface_ajoute.Text +" - "+  j.nom + " (" + j.type + ")\n";
                          try
                            {
                                w.WriteLine("interface: " + j.nom + " type " + j.type);
                                w.Flush();
                            }catch (Exception v) { Console.WriteLine(v.Message); }
                    }
                    
                    w.Close();
                    bt_console.Visible = true;
                }
            }
            
        }

        private void cb_nombreInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = 1;
            nombre_d_interface = cb_nombreInterface.SelectedIndex + 1;
            panel2.Enabled = true;
            bt_ajouter.Text = "ajouter";
            tb_nom_interface.Clear();
            tb_type_interface.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process proc = Process.Start(new ProcessStartInfo(@"C:\Users\sekouzed\Documents\Visual Studio 2010\Projects\projetRoutage\projetRoutageConsole\bin\Debug\projetRoutageConsole.exe"));
            proc.WaitForExit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            i = 0;
            nombre_d_interface = 0;
            tb_nom_interface.Clear();
            tb_type_interface.Clear();
            commande.listeDesInterfaces.Clear();
        }


        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("hello");
            }

        }
    }
}
