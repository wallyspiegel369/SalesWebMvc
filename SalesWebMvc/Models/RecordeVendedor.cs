using SalesWebMvc.Models.NovaPasta2;

namespace SalesWebMvc.Models
{
    public class RecordeVendedor
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double quantidade { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RecordeVendedor ()
        {

        }

        public RecordeVendedor(int id, DateTime data, double quantidade, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            this.quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
