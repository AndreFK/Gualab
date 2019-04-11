using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gualab
{
    class Parser
    {
       //Varaible constantes con las valores que vamos a comparar en el archivo original
        const string lf = "LeftRight = \"Left\"";
        const string hw = "HandWidth = 186";
        const string al = "ArmLength = 564";
        const string fac = "ForearmCircumference = 271";
        const string bc = "BicepCircumference = 147";
        const string pt = "PaddingThickness = 2";
        
        //Un string privado donde se guarda el nuevo path
        private string pathnew;
        private string filenew;

        public string getFile()
        {
            return this.filenew;
        }

        //La funcion parse escribe los nuevos valores dentro del nuevo directorio
        public void parse(string l, string h, string a, string f, string b, string p, string path)
        {
            if (l == "Izquierda")
            {
                l = "Left";
            }
            else
            {
                l = "Right";
            }
            string text = File.ReadAllText("..\\..\\ArchivosOriginales\\Original.scad");
            text = text.Replace(lf, "LeftRight = " + "\"" + l + "\"");
            text = text.Replace(hw, "HandWidth = " + h);
            text = text.Replace(al, "ArmLength = " + a);
            text = text.Replace(fac, "ForearmCircumference = " + f);
            text = text.Replace(bc, "BicepCircumference = " + b);
            text = text.Replace(pt, "PaddingThickness = " + p);
            File.WriteAllText(path, text);
        }

        //En este string se abre el File Browser donde el usuario va a poder elegir en que path se crearan los nuevos archivos
        public string npath(string usuario)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();

            fd.ShowDialog();

            this.pathnew = fd.SelectedPath.ToString();

            this.filenew = fd.SelectedPath.ToString() + "\\" + usuario + "_Arm.scad"; //El "\\Original.scad" es el nombre del archivo a donde se va a escribir el codigo
            return pathnew;
        }

        //La funcion crearf crea el nuevo archivo scad donde la funcion parse va a escribir el nuevo codigo
        public void crearf(string path, string user)
        {
            try
            {
                string[] filePaths = Directory.GetFiles("..\\..\\ArchivosOriginales");
                foreach (var filename in filePaths)
                {
                    string file = filename.ToString();

                    string str = file.Replace("..\\..\\ArchivosOriginales", path);
                    if (!File.Exists(str))
                    {

                        File.Copy(file, str, true);
                    }
                }
                Directory.CreateDirectory(path + "..\\" + user + "_Renders");
                File.Delete(path + "..\\Original.scad");
            }
            catch
            {
                MessageBox.Show("Archivo Original no encontrado");
            }
        }
		
        private void nbatch(string path)
        {
            string file = "..\\..\\Automatizacion.bat";
            try
            {
                File.Copy(file, path, true);
            }
            catch
            {
                MessageBox.Show("Archivo de Automatizacion.bat no encontrado");
            }
        }

		//Funcion que manda ejecutar el comando de openscad en la terminal (Archivo .bat llamado automatizacion)
        public void EjecutarRender(string user)
        {   /*
            Esto de aqui abajo es lo que quiero hacer para reescribir el batc file. Pero antes hay que 
            hacer una copia exacta del batchfile y hacer el text.replace en esa copia;
            */

            nbatch("..\\..\\nuevo.bat");

            string path = pathnew.Replace("\\", "/");
            string file = filenew.Replace("\\", "/");
            
            string text = File.ReadAllText("..\\..\\nuevo.bat");

            text = text.Replace("ArchivosModificados/ArchivosSTL", path + "/" +user+ "_Renders");
            text = text.Replace("ArchivosModificados/Original.scad", file);
            File.WriteAllText("..\\..\\nuevo.bat", text);
            
            
            //directorio de ejecutable
            string workingDirectory = Environment.CurrentDirectory;
			// directorio del proyecto
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string commandToExecute = Path.Combine(projectDirectory, "nuevo.bat");
			//Direccion del archivo .bat
            //string commandToExecute = Path.Combine(projectDirectory, "Automatizacion.bat");
            string workingFolder = Path.GetDirectoryName(commandToExecute);

			// ejecuta el archivo .bat
            Process proc = new Process();
            proc.StartInfo.FileName = commandToExecute;
            proc.StartInfo.WorkingDirectory = workingFolder;
            proc.Start();
        }
    }
}
