﻿using Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AgregarCategoriaMarca : Form
    {
        public AgregarCategoriaMarca()
        {
            InitializeComponent();
        }
        MarcaController marcaController = new MarcaController();
        CategoriaController categoriaController = new CategoriaController();

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agergarMarca_Click(object sender, EventArgs e)
        {

        }


    }
}
