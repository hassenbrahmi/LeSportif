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
    public partial class listeSportifs : Form
    {
        private AppDbContext _context;
        public listeSportifs()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadSportifs();
        }
        private void LoadSportifs()
        {
            var sportifs = _context.Sportifs.ToList();
            dataGridView1.DataSource = sportifs;
            textBox1.Text = dataGridView1.RowCount.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            //var Sportifs = new Sportifs
            //{
            //    Nom = "Ahmed",
            //    Identifiant = "1122009",
            //    Id = 112
            //};
            //_context.Sportifs.Add(Sportifs);
            //_context.SaveChanges();
            LoadSportifs();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Désélectionner toutes les lignes
                dataGridView1.ClearSelection();

                // Sélectionner la ligne entière de la cellule cliquée
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var Sportifs = new Sportifs
            //{
            //    Nom = "Ahmed",
            //    Identifiant = "1122009",
            //    Id = 112
                
            //};
            
            //_context.Sportifs.Add(Sportifs);
            //_context.SaveChanges();
            LoadSportifs();
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }

        private void listeSportifs_Load(object sender, EventArgs e)
        {
            initForm();
            LoadSportifs();
        }
        private void initForm()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            // Désactiver la génération automatique de colonnes
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
