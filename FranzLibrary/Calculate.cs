using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranzLibrary
{
    /// <summary>
    /// Rechenoperationen
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// Plus rechnen
        /// </summary>
        /// <param name="p">I</param>
        /// <returns>Ergebnis als String</returns>
        public static string plus(ref string p)
        {
            string eingabe1 = p.Substring(0, p.IndexOf("+"));
            string zwischen = p.Substring(p.IndexOf("+") + 1);
            Double zahl1 = Convert.ToDouble(eingabe1);
            Double zahl2 = Convert.ToDouble(zwischen);
            double ergebnis = zahl1 + zahl2;
            string answer = Convert.ToString(ergebnis);
            return answer;

        }
        /// <summary>
        /// Minus rechnen
        /// </summary>
        /// <param name="p">I</param>
        /// <returns>Ergebnis als String</returns>
        public static string minus(ref string p)
        {
            string eingabe1 = p.Substring(0, p.IndexOf("-"));
            string zwischen = p.Substring(p.IndexOf("-") + 1);
            Double zahl1 = Convert.ToDouble(eingabe1);
            Double zahl2 = Convert.ToDouble(zwischen);
            double ergebnis = zahl1 - zahl2;
            string answer = Convert.ToString(ergebnis);
            return answer;
        }

        /// <summary>
        /// Mal rechnen
        /// </summary>
        /// <param name="p">I</param>
        /// <returns>Ergebnis als String</returns>
        public static string mal(ref string p)
        {
            string eingabe1 = p.Substring(0, p.IndexOf("*"));
            string zwischen = p.Substring(p.IndexOf("*") + 1);
            Double zahl1 = Convert.ToDouble(eingabe1);
            Double zahl2 = Convert.ToDouble(zwischen);
            double ergebnis = zahl1 * zahl2;
            string answer = Convert.ToString(ergebnis);
            return answer;

        }

        /// <summary>
        /// Durch mit : rechnen
        /// </summary>
        /// <param name="p">I</param>
        /// <returns>Ergebnis als String</returns>
        public static string durch(ref string p)
        {
            string eingabe1 = p.Substring(0, p.IndexOf(":"));
            string zwischen = p.Substring(p.IndexOf(":") + 1);
            Double zahl1 = Convert.ToDouble(eingabe1);
            Double zahl2 = Convert.ToDouble(zwischen);
            double ergebnis = zahl1 / zahl2;
            string answer = Convert.ToString(ergebnis);
            return answer;
        }

        /// <summary>
        /// Durch mit / rechnen
        /// </summary>
        /// <param name="p">I</param>
        /// <returns>Ergebnis als String</returns>
        public static string durch2(ref string p)
        {
            string eingabe1 = p.Substring(0, p.IndexOf("/"));
            string zwischen = p.Substring(p.IndexOf("/") + 1);
            Double zahl1 = Convert.ToDouble(eingabe1);
            Double zahl2 = Convert.ToDouble(zwischen);
            double ergebnis = zahl1 / zahl2;
            string answer = Convert.ToString(ergebnis);
            return answer;
        }
    }
}
