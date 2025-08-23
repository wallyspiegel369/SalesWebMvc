using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id {get; set;}
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RecordeVendedor> Vendedores { get; set; } = new List <RecordeVendedor>();
        public Vendedor()
        {

        }

        public Vendedor(int id, string name, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVendedor(RecordeVendedor rv)
        {
            Vendedores.Add(rv);
        }

        public void RemoverVendedor(RecordeVendedor rv)
        {
            Vendedores.Remove(rv);
        }

        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendedores.Where(rv => rv.Data >= initial && rv.Data <= final).Sum(rv => rv.quantidade);
        }
    }
}
