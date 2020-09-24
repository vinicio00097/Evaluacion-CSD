using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.ViewModel
{
    class OperacionesNumerosViewModel
    {
        public float promedioNumeros(Numbers numbers)
        {
            return numbers.numbersInput.Sum()/numbers.numbersInput.Count;
        }

        public float sumatoriaNumeros(Numbers numbers)
        {
            return numbers.numbersInput.Sum();
        }

        public List<float> getNumerosFromText()
        {
            String[] lines=File.ReadAllLines(@".\file.txt");
            List<float> lista = new List<float>();

            foreach (String line in lines)
            {
                lista.Add(float.Parse(Regex.Match(line, "(\\d)+\\.(\\d)+").Value));
            }

            return lista;
        }
    }
}
