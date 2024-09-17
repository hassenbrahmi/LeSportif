using LeSportif.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeSportif.View
{
    public partial class Inscription : Form
    {
        private AppDbContext _context;
        public Inscription()
        {
            InitializeComponent();
            _context = new AppDbContext();
            this.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void Inscription_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Sportifs = new Sportifs
            {
                Nom = txtNom.Text,
                Prenom= txtPrenom.Text,
                Identifiant = TxtCin.Text,
                date_Naissance = txtDateNaissance.Value,
                Email= txtEmail.Text,
                Id = 113
            };
            _context.Sportifs.Add(Sportifs);
            _context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
