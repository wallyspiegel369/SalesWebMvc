using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedores (Vendedor vendedor) 
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas (DateTime initial, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(initial, final));
        }
    }
}
