using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace jsonNoCsharp
{
    public class Funcionario
    {
        private string _id { get; set; }
        private string _nome { get; set; }
        private string _sobrenome { get; set; }
        private string _email { get; set; }
        private string _genero { get; set; }
        private string _cidade { get; set; }
        private string _pais { get; set; }
        private string _empresa { get; set; }
        private double _salario { get; set; }

        // métodos getters e setters

        public string id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }

        public string sobrenome
        {
            get { return this._sobrenome; }
            set { this._sobrenome = value; }
        }

        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public string genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }

        public string cidade
        {
            get { return this._cidade; }
            set { this._cidade = value; }
        }

        public string pais
        {
            get { return this._pais; }
            set { this._pais = value; }
        }

        public string empresa
        {
            get { return this._empresa; }
            set { this._empresa = value; }
        }

        public double salario
        {
            get { return this._salario; }
            set { this._salario = value; }
        }
    }
}