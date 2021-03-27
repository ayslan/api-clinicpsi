using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Psi.Infra.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string OnlyDigits(this string text)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            return digitsOnly.Replace(text, "");
        }
    }
}
