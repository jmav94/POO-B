using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._2
{
    class Empresa
    {
        public Empresa()
        {
            rfc = "";
            razonSocial = "";
            gerente = "";
            ListaDepartamentos = new List<Departamento>();
        }
        private string rfc;

        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }
        private string razonSocial;

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        private string gerente;

        public string Gerente
        {
            get { return gerente; }
            set { gerente = value; }
        }
        List<Departamento> ListaDepartamentos;
        public void InsertarDepartamento(Departamento departamento)
        {
            ListaDepartamentos.Add(departamento);
        }
        public IEnumerator<Departamento> GetEnumerator()
        {
            return ListaDepartamentos.GetEnumerator();
        }
        public void EliminarDepartamento(int index)
        {
            ListaDepartamentos.RemoveAt(index);
        }
        ~Empresa()
        {
            ListaDepartamentos.Clear();
        }

    }
}
