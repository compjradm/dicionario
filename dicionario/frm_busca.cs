﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicionario
{
    public partial class frm_busca : Form
    {
        frm_Edit objEditForm;
        public frm_busca()
        {
            //O Construtor esconde o ResultsBox, que só é mostrado depois de uma
            //busca.
            InitializeComponent();
            this.searchResultsListBox.Hide();
            this.objEditForm = new frm_Edit();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            //Por hora, cria uma nova instância do mesmo form.
            //Trocar o HomeForm para os Forms corretos.
            frm_contato contato = new frm_contato();
            contato.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string palavra = this.searchBox.Text;
            this.searchResultsListBox.Show();
            this.searchResultsListBox.Items.Add(palavra);
        }

        private void searchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void editModeButton_Click(object sender, EventArgs e)
        {
            this.objEditForm.Show(this);
            this.objEditForm.BringToFront();
            this.Hide();
        }
    }
}
