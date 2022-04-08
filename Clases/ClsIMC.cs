using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Andri.ClsIMC
{
    internal class ClsIMC
    {
        private const double KG = 2.2046;
        public String Nombre { get; set; }

        public int edad { get; set; }
        public char sexo { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }
        public double IMC { get; set; }


        public String resultado()

        {

            this.Nombre = "Andri";
            this.edad = 21;
            this.altura = 187;
            this.sexo = 'M';
            this.peso = 140;
            double pesoKG = this.peso / KG;
            double estaturainmts = (double)this.altura / 100;
            double altura = (Math.Pow(estaturainmts, 2));
            this.IMC = pesoKG / altura;


            if ((pesoKG < 53) && (this.IMC < 18.5) && (edad < 18) && (altura < 155))
            {
                return $"Este es el resultado \t" + Nombre + "\nPara tu edad:" + edad + "\t tu sexo:" + sexo + "\ttu altura:" + estaturainmts +"mts" + "\nTu IMC es:\t" + IMC + "\tTe encuentras en el rango DELGADO";
            }

            else if ((pesoKG < 85) && (this.IMC >= 18) && (this.IMC < 25) && (altura < 180))
            {
                return $"Este es el resultado \t" + Nombre + "\nPara tu edad:" + edad + "\t tu sexo:" + sexo + "\ttu altura:" + estaturainmts + "mts" + "\nTu IMC es:\t" + IMC + "\tTe encuentras en el rango NORMAL";
            }

            else if (pesoKG < 100  & this.IMC >= 25 && this.IMC < 27)
            {
                return $"Este es el resultado \t" + Nombre + "\nPara tu edad:" + edad + "\t tu sexo:" + sexo + "\ttu altura:" + estaturainmts + "mts" + "\nTu IMC es:\t" + IMC + "\tTe encuentras en el rango SOBREPESO";
            }

            else if (pesoKG > 120 && this.IMC > 27)
            {
                return $"Este es el resultado \t" + Nombre + "\nPara tu edad:" + edad + "\t tu sexo:" + sexo + "\ttu altura:" + estaturainmts + "mts" + "\nTu IMC es:\t" + IMC + "\tTe encuentras en el rango OBESIDAD";
            }

       
            return this.IMC.ToString();

        }
     
        }

    }
