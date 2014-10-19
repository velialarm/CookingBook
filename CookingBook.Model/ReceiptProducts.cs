namespace CookingService.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ReceiptProducts
    {

        [Key, Column(Order = 0)]
        public int ReceiptId { get; set; }

        public virtual Receipt Receipt { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public int MeasureId { get; set; }

        public virtual Measure Measure { get; set; }

        public string Note { get; set; }
    }
}
