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

        //La funcion parse escribe los nuevos valores dentro del nuevo directorio
        public void parse(string l, string h, string a, string f, string b)
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
            File.WriteAllText("..\\..\\ArchivosOriginales\\ArchivosModificados\\Original.scad", text);
        }

        //La funcion crearf crea los nuevos archivos donde se van a escribir los nuevos valores
        public void crearf()
        {
            string[] filePaths = Directory.GetFiles("..\\..\\ArchivosOriginales");
            foreach (var filename in filePaths)
            {
                string file = filename.ToString();

                string str = file.Replace("..\\..\\ArchivosOriginales", "..\\..\\ArchivosOriginales\\ArchivosModificados");
                if (!File.Exists(str))
                {
                    File.Copy(file, str, true);
                }
            }
        }
		
		//Funcion que manda ejecutar el comando de openscad en la terminal (Archivo .bat llamado automatizacion)
        public void EjecutarRender()
        {
            //directorio de ejecutable
            string workingDirectory = Environment.CurrentDirectory;
			// directorio del proyecto
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
<<<<<<< HEAD
            string commandToExecute = Path.Combine(projectDirectory, "prueba.bat");
=======
			//Direccion del archivo .bat
            string commandToExecute = Path.Combine(projectDirectory, "Automatizacion.bat");
>>>>>>> 27a7413d1be01c921464dd5dbb974b2c327f62dc
            string workingFolder = Path.GetDirectoryName(commandToExecute);

			// ejecuta el archivo .bat
            Process proc = new Process();
            proc.StartInfo.FileName = commandToExecute;
            proc.StartInfo.WorkingDirectory = workingFolder;
            proc.Start();
        }
    }
}
