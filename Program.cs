using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using System.Linq;

namespace jsonNoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> linhas = new List<string>();
            List<string> funcJson = new List<string>();
            List<Funcionario> funcionarioCsharp = new List<Funcionario>();
            Funcionario func = new Funcionario();
            // Todos os atributos devem estar acessíveis na classe Funcionario
            func.id = "1";
            func.nome = "Julio";
            func.sobrenome = "de Oliveira Neto";
            func.genero = "Masculino";
            func.email = "juliosfro@gmail.com";
            func.pais = "Brasil";
            func.cidade = "Cianorte";
            func.empresa = "BrasilTec";
            func.salario = 3820;
            string objJson = JsonConvert.SerializeObject(func);
            // Console.WriteLine(objJson);

            string path = Directory.GetCurrentDirectory();
            StreamReader reader = new StreamReader(path + "//funcionarios.json");
            string linha = null;
            while ((linha = reader.ReadLine()) != null)
            {
                linhas.Add(linha.Replace("[", ""));
            }

            linhas.ForEach(x => funcJson.Add(x.Substring(0, x.Length - 1)));

            funcJson.ForEach(x =>
            {
                var ms = new MemoryStream(Encoding.Unicode.GetBytes(x));
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Funcionario));
                Funcionario func2 = (Funcionario)deserializer.ReadObject(ms);
                funcionarioCsharp.Add(func2);
            });

            // funcionarioCsharp.ForEach(x => Console.WriteLine(x.nome));
            List<Funcionario> chineses = funcionarioCsharp.Where(x => x.pais.Equals("China")).ToList();
            List<Funcionario> mulheresChinesas = chineses.Where(x => x.genero.Equals("F")).ToList();
            List<Funcionario> ascSalarioMulherChinesa = mulheresChinesas.OrderBy(x => x.salario).ToList();
            Console.WriteLine($"Nome: {ascSalarioMulherChinesa.FirstOrDefault().nome}");
            Console.WriteLine($"Valor: {ascSalarioMulherChinesa.FirstOrDefault().salario}");
            // Console.ReadKey();
        }
    }
}