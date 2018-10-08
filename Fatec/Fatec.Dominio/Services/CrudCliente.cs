using Fatec.Infra;
using System;
using System.Collections.Generic;
using System.Data;

namespace Fatec.Dominio.Servicos
{
    public class CrudCliente
    {
        public bool CadastrarCliente(Cliente cliente)
        {
            CrudClienteAdoNet obj = new CrudClienteAdoNet();

            var resultado = obj.CadastrarCliente(cliente);

            return resultado;
        }

        public List<Cliente> RetornarClientes()
        {
            CrudClienteAdoNet obj = new CrudClienteAdoNet();

            var dataSet = obj.GetCliente();

            var table = dataSet.Tables[0];

            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow item in table.Rows)
            {
                Cliente cliente = new Cliente()
                {
                    Id = Convert.ToInt32(item[0]),
                    Cpf = item[1].ToString(),
                    Nome = item[2].ToString(),
                    DataNascimento = Convert.ToDateTime(item[3]),
                    Endereco = item[4].ToString(),
                    Cidade = item[5].ToString()
                };
                clientes.Add(cliente);
            }

            return clientes;
        }
    }
}
