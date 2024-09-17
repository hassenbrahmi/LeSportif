using LeSportif.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LeSportif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initForm();
            View.Connexion connexion = new Connexion();
            connexion.ShowDialog();
        }
        // Gestionnaire d'événements pour le premier élément de menu
        private void menuItem1_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void initForm()
        {
            LabelServer.Text = Program.server.ToString();
            labelDataBase.Text = Program.DataBase.ToString();
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            labelUser.Text = Program.user.ToString();
            labelVersion.Text = ModuleVersion.Version.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == connexionToolStripMenuItem)
            {
                Connexion connect = new Connexion();
                connect.ShowDialog();
            }
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.ShowDialog();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Inscription inscription = new Inscription();
            inscription.MdiParent = this;
            inscription.Dock = DockStyle.Fill;
            inscription.Show();
        }

        private void caisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Caisse caisse = new Caisse();
            caisse.MdiParent = this;
            caisse.Dock= DockStyle.Fill;
            caisse.WindowState = FormWindowState.Maximized; // Maximiser le formulaire enfant   
            caisse.Show();
        }
        private void CloseAllChildForms()
        {
            // Ferme tous les formulaires enfants ouverts
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sportifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            listeSportifs listesportifs = new listeSportifs();
            listesportifs.MdiParent = this;
            listesportifs.Dock = DockStyle.Fill;
            listesportifs.WindowState = FormWindowState.Maximized; // Maximiser le formulaire enfant   
            listesportifs.Show();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
