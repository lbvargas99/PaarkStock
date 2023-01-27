using Paark.Stock.Core.Domain.Models;
using Paark.Stock.Core.Domain.Validations;

namespace Paark.Stock.Core.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(ProductModel product)
        {
            Validate(product);
        }

        public void Validate(ProductModel product) {
            DomainValidationException.When(string.IsNullOrEmpty(product.Name), "Nome não informado");
            DomainValidationException.When(product.Quantity < 0, "Quantidade não informada");

            Name = product.Name;
            Quantity = product.Quantity;
        }
    }
}
