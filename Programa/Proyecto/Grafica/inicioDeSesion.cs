﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 segundoForm = new Form2("Camionero");
            segundoForm.Show();
            
            ;
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form2 segundoForm = new Form2("Cliente");
            segundoForm.Show();
            







        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 segundoForm = new Form2("Pers.Almacen");
            segundoForm.Show();
            




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 segundoForm = new Form2("Oficinista");
            segundoForm.Show();
            


           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void seleccionUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
