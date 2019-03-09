using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
* pd = PaddingThickness (Relleno del antebrazo)
*/

namespace Gualab
{


    public partial class Form1 : Form
    {

        Parser p = new Parser();
		//verifica si se generaron los archivos
        
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

        private void pd_nud_ValueChanged(object sender, EventArgs e)
        {
            pd_tb.Value = Convert.ToInt32(pd_nud.Value);
        }
        //<- Hasta aqui

        //Estas funciones cambian el calor de cada numeric up down segun cambia el valor de su respectivo trackbar
        //Desde aqui ->
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

        private void pd_tb_ValueChanged(object sender, EventArgs e)
        {
            pd_nud.Value = pd_tb.Value;
        }
        //<- Hasta aqui


        //boton generar
        private void button1_Click(object sender, EventArgs e)
        {
            //La variable iniciales contiene las iniciales del usaurio (duh)
            string iniciales;

            //Solo se podra crear un archivo scad si ya se ingresaron las inciales del usuario
            if (string.IsNullOrEmpty(iniciales_txt.Text))
            {
                MessageBox.Show("Ingrese las inciales del usuario de la protesis");
            }
            else
            {
                iniciales = iniciales_txt.Text;

                //path es donde se creara el nuevo archivo scad
                string path = p.npath(iniciales);

                //Crearf crea el nuevo archvio scad en el nuevo path
                p.crearf(path);

                //En la funcion parse los parametros se tiene que enviar en este orden exacto para que funcione. Quiza lo arregle mas tarde para que no importe el orden
                p.parse(lr_cb.Text, hw_nud.Value.ToString(), al_nud.Value.ToString(), fac_nud.Value.ToString(), bc_nud.Value.ToString(), pd_nud.Value.ToString(), path);

                MessageBox.Show("Archvio creado en " + path);
            }
        }


        //boton renderizar
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Verifica si el archivo generado existe
            if (File.Exists(p.getFile())) 
            {
				//los archivos redenderizados estaran en una capeta llamada ArchivosSTL(Nota: No borrarla) PATH:  ..\ArchivosOriginales\ArchivosModificados\ArchivosSTL
                p.EjecutarRender();
                
            }
            else
            {
				
                MessageBox.Show("Debe generar los archivos primero antes de Redenderizar");
            }
        }
    }
}
