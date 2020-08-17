using System;
using System.IO;
using HtmlAgilityPack;

namespace cotacaodolar {
    class Program {
        static void Main(string[] args) {

            var doc = new HtmlWeb().Load("https://valor.globo.com/valor-data/");

            var cotDolares = doc.DocumentNode.SelectNodes("//main/div/div/div/div/div/div");
            int total = 1;

            string CaminhoNome = "cotdolar.txt";
            StreamWriter x = File.CreateText(CaminhoNome);

            foreach (var cotDolar in cotDolares) {
                if (total == 1) {
                    x.WriteLine(cotDolar.InnerText);
                }
                else {
                    break;
                }
                total = total + 1;
            }

            x.Close();

        }
    }
}
