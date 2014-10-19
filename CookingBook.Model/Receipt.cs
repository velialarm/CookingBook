using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingService.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Receipt
    {

        private ICollection<ReceiptProducts> products;
        private ICollection<Receipt> similarReceipts;
        private ICollection<Media> medies;

        public Receipt()
        {
            this.products = new HashSet<ReceiptProducts>();
            this.similarReceipts = new HashSet<Receipt>();
            this.medies = new HashSet<Media>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int PrepareTime { get; set; }

        public int CookTime { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Portions { get; set; }

        public int? Difficulty { get; set; }

        public string Preparation { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int NationalityId { get; set; }

        public virtual Nationality Nationality { get; set; }

        public int SourceReceiptId { get; set; }

        public virtual SourceReceipt SourceReceipt { get; set; }

        public int? HolidayId { get; set; }

        public virtual Holiday Holiday { get; set; }

        //        public int CourseTypeId { get; set; }
        //
        //        public virtual CourseType CourseType { get; set; }

        public virtual ICollection<ReceiptProducts> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }

        //        public virtual Receipt Similar { get; set; }
        //
        //        [InverseProperty("Similar")]
        public virtual ICollection<Receipt> SimilarReceipts
        {
            get { return this.similarReceipts; }
            set { this.similarReceipts = value; }
        }

        public virtual ICollection<Media> Medies
        {
            get { return this.medies; }
            set { this.medies = value; }
        }
    }
}
