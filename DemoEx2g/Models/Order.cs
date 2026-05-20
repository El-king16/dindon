using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx2g.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } 
        public string ArticleOrder {  get; set; }
        public string DateOrder {  get; set; }
        public string DateDelivery { get; set; }
        public int AddressId {  get; set; }
        public string FullnameClient {  get; set; }
        public int Code {  get; set; }
        public string Status {  get; set; }

    }
}
