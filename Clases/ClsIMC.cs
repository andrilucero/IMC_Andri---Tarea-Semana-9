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

        public String datos()
        {
            this.Nombre = "Andri";
            this.edad = 21;
            this.altura = 185;
            this.sexo = 'M';
            this.peso = 140;
            double pesoKG = this.peso / KG;

            return $"\n Nombre: {Nombre} \n Edad: {edad} \n Altura: {altura} \n Sexo: {sexo} \n Peso en Lbs:{peso} \n Peso en KG: {pesoKG}";

        }

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


            if (pesoKG < 40 && this.IMC < 18.5)
            {
                return $"Tu IMC es:\t" + IMC + "\tTe encuentras en el rango DELGADO";
            }

            else if (pesoKG < 85 & this.IMC >= 18 && this.IMC < 25)
            {
                return $"Tu IMC es:\t" + IMC + "\tTe encuentras en el rango NORMAL";
            }

            else if (pesoKG < 100  & this.IMC >= 25 && this.IMC < 27)
            {
                return $"TU IMC es:\t" + IMC + "\tTe encuentras en el rango SOBREPESO";
            }

            else if (pesoKG > 120 && this.IMC > 27)
            {
                return $"Tu IMC es: \t" + IMC + "\tTe encuentras en el rango OBESIDAD";
            }

       
            return this.IMC.ToString();

        }
    }
}
