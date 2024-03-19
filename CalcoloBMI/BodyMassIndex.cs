using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloBMI
{
    internal class BodyMassIndex
    {
        private readonly double _peso;
        private readonly double _altezza;

        public BodyMassIndex(double peso, double altezza)
        {
            _peso = peso;
            _altezza = altezza;
        }

        public double Bmi
        {
            get
            {
                return _peso / Math.Pow(_altezza, 2);
            }
        }

        public string Tipologia
        {
            get
            {
                string tipo = "";

                switch (Bmi)
                {
                    case < 18.5:
                        tipo = "sottopeso";
                        break;
                    case >= 18.5 and <= 24.9:
                        tipo = "normopeso";
                        break;
                    case > 24.9 and < 30:
                        tipo = "sovrappeso";
                        break;
                    case >= 30:
                        tipo = "obesità";
                        break;
                }

                return tipo;
            }
        }
    }
}
