using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
            string text = File.ReadAllText("..\\..\\Arm\\Arm.scad");
            text = text.Replace(lf, "LeftRight = " + "\"" + l + "\"");
            text = text.Replace(hw, "HandWidth = " + h);
            text = text.Replace(al, "ArmLength = " + a);
            text = text.Replace(fac, "ForearmCircumferencer = " + f);
            text = text.Replace(bc, "BicepCircumference = " + b);
            File.WriteAllText("C:\\Users\\Usuario\\Documents\\Visual Studio 2017\\Projects\\Gualab\\Gualab\\Arm\\arm2\\Arm.scad", text);
        }

        //La funcion crearf crea los nuevos archivos donde se van a escribir los nuevos valores
        public void crearf()
        {
            string[] filePaths = Directory.GetFiles("..\\..\\Arm");
            foreach (var filename in filePaths)
            {
                string file = filename.ToString();

                string str = file.Replace("..\\..\\Arm", "..\\..\\Arm\\arm2");
                if (!File.Exists(str))
                {
                    File.Copy(file, str, true);
                }
            }
        }
    }
}
