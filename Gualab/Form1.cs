using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
*Los objetos con el sufijo "_lbl" son labels 
*Los objetos con sufijo "_tb" son trackbars
*Los objetos con sufijo "_nud" son nummeric up down
*Los objetos con sufijo "_cb" son domain up down
* 
* hw = HandWidth (Ancho de la mano)
* al = ArmLength (Largo del brazo)
* fac = ForeArmCircumference (Circumferencia del antebrazo)
* bc = BicepCircumference (Circumferencia del bicep)
*/

namespace Gualab
{


    public partial class Form1 : Form
    {

        Parser p = new Parser();
        bool checkGenerar = false;
        public Form1()
        {
            InitializeComponent();
            //Prevenir que el usuario altere el valor del domain up down
       
            //Agregar elemntos al domain up down
            lr_cb.Items.Add("Derecha");
            lr_cb.Items.Add("Izquierda");
            //Valor inicial del domain up down
            lr_cb.Text = "Izquierda";
        }

        //Estas funciones cambian el valor de cada trackbar cuando cambia el valor de su respectivo numeric up down
        //Desde aqui ->
        private void hw_nud_ValueChanged(object sender, EventArgs e)
        {
            hw_tb.Value = Convert.ToInt32(hw_nud.Value);
        }

        private void al_nud_ValueChanged(object sender, EventArgs e)
        {
            al_tb.Value = Convert.ToInt32(al_nud.Value);
        }

        private void fac_nud_ValueChanged(object sender, EventArgs e)
        {
            fac_tb.Value = Convert.ToInt32(fac_nud.Value);
        }

        private void bc_nud_ValueChanged(object sender, EventArgs e)
        {
            bc_tb.Value = Convert.ToInt32(bc_nud.Value);
        }
        //<- Hasta aqui

        //Estas funciones cambian el calor de cada numeric up down segun cambia el valor de su respectivo trackbar
        private void hw_tb_ValueChanged(object sender, EventArgs e)
        {
            hw_nud.Value = hw_tb.Value;
        }

        private void al_tb_ValueChanged(object sender, EventArgs e)
        {
            al_nud.Value = al_tb.Value;
        }

        private void fac_tb_ValueChanged(object sender, EventArgs e)
        {
            fac_nud.Value = fac_tb.Value;
        }

        private void bc_tb_ValueChanged(object sender, EventArgs e)
        {
            bc_nud.Value = bc_tb.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            p.crearf();

            //En la funcion parse los parametros se tiene que enviar en este orden exacto para que funcione. Quiza lo arregle mas tarde para que no importe el orden
            p.parse(lr_cb.Text, hw_nud.Value.ToString(), al_nud.Value.ToString(), fac_nud.Value.ToString(), bc_nud.Value.ToString());
            MessageBox.Show("Archvios creados y .scad modificado");
            checkGenerar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkGenerar)
            {
                p.EjecutarRender();
                checkGenerar = false;
            }
            else
            {
                MessageBox.Show("Debe generar los archivos primero antes de Redenderizar");
            }
        }
    }
}
