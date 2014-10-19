
namespace CookingService.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        private ICollection<ReceiptProducts> receipts;
        private ICollection<Media> medies;

        public Product()
        {
            this.receipts = new HashSet<ReceiptProducts>();
            this.medies = new HashSet<Media>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }

        public virtual ICollection<ReceiptProducts> Receipts
        {
            get { return this.receipts; }
            set { this.receipts = value; }
        }

        public virtual ICollection<Media> Medies
        {
            get { return this.medies; }
            set { this.medies = value; }
        }
    }
}
