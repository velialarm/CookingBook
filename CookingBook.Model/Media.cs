using System.Collections.Generic;

namespace CookingService.Model
{
    public class Media
    {
        private ICollection<Receipt> receipts;
 
        public Media()
        {
            this.receipts = new HashSet<Receipt>();    
        }

        public int Id { get; set; }

        public MediaType MediaType { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

//        public byte[] Sourse { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }

        // TODO add extension and MIME type
    }
}
