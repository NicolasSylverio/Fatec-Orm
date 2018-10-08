using System;

namespace Fatec.Dominio.CrossCutting
{
    public static class Format
    {
        public static string FormatarMaskedTextBoxString(string texto)
        {
            return texto.Replace("-", "").Replace("_", "").Replace(" ", "").Replace(",", "").Replace(".", "");
        }

        public static decimal FormatarMaskedTextBoxDecimal(string texto)
        {
            return Convert.ToDecimal(texto.Replace("-", "").Replace("_", "").Replace(" ", ""));
        }

        public static int FormatarMaskedTextBoxInt(string texto)
        {
            return Convert.ToInt32(texto.Replace("-", "").Replace("_", "").Replace(" ", ""));
        }
    }
}
