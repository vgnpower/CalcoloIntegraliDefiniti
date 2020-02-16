using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoreSoft.MathExpressions;
using System.Diagnostics;

namespace CalcoloIntegraliDefiniti
{
    public class IntegrazioneNum
    {
        private MathEvaluator _eval = new MathEvaluator();
        private bool metodoArea;
        public bool MetodoArea
        {
            get { return metodoArea; }
            set { metodoArea = value; }
        }

        public string CalcolaAreaTotale(string _eq, int _a, int _b, int _n)
        {
            double altezza = ((double)_b - (double)_a) / (double)_n;
            double risSomme2 = 0; double risSomme1 = 0;

            for (int i = 0; i < _n; i++)
            {
                risSomme2 += CalcoloSingolaArea(_eq, altezza * i);
            }

            for (int i = 1; i < _n + 1; i++)
            {
                risSomme1 += CalcoloSingolaArea(_eq, altezza * i);
            }

            risSomme1 = altezza * risSomme1;
            risSomme2 = altezza * risSomme2;

            if (metodoArea)
            {
                return risSomme1 + Environment.NewLine + risSomme2;
            }
            else
            {
                double risTrapezio = (risSomme1 + risSomme2) / 2;
                return risTrapezio.ToString();
            }
        }

        public double CalcoloSingolaArea(string _eq, double _h)
        {
            char[] caratteriEq = _eq.ToCharArray();
            double risolvi = 0; int lastSplit = 0;
            List<string> listaOperazioni = new List<string>();
            //Spezzetta l'equazione per ogni segno di operazione
            for (int i = 0; i < caratteriEq.Length; i++)
            {
                if ((caratteriEq[i] == '+') || (caratteriEq[i] == '-') || (caratteriEq[i] == '*') || (caratteriEq[i] == '/'))
                {
                    listaOperazioni.Add(_eq.Substring(lastSplit, (i) - lastSplit));
                    listaOperazioni.Add(_eq[i].ToString());
                    lastSplit = i + 1;
                }
            }
            listaOperazioni.Add(_eq.Substring(lastSplit, _eq.Length - lastSplit));

            //sostituisco alla x il valore di h
            for (int i = 0; i < listaOperazioni.Count; i++)
            {
                if (listaOperazioni[i].Contains("x"))
                {
                    string numero = listaOperazioni[i].Substring(0, listaOperazioni[i].IndexOf('x'));
                    string altriChar = listaOperazioni[i].Substring(listaOperazioni[i].IndexOf('x') + 1, listaOperazioni[i].Length - listaOperazioni[i].IndexOf('x') - 1);
                    if ((numero == "") || !numero[numero.Length - 1].ToString().Any(char.IsDigit))
                    {
                        double calcolo = (double)1 * (double)_h;
                        listaOperazioni[i] = numero + calcolo.ToString() + altriChar;
                    }
                    else
                    {
                        double calcolo = Convert.ToDouble(numero) * (double)_h;
                        listaOperazioni[i] = numero + calcolo.ToString() + altriChar;
                    }
                }
            }

            string rebuild = "";
            //ricostruisco la stringa con la x calcolata:
            foreach (string elm in listaOperazioni)
            {
                rebuild += elm;
            }

            try
            {
                risolvi = _eval.Evaluate(rebuild);
            }
            catch (Exception ex) {  }

            return risolvi;
        }
    }
}