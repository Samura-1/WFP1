namespace WpfApp1.ModelBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public int id { get; set; }

        public string First_name { get; set; }

        [StringLength(50)]
        public string Last_name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Gender_Code { get; set; }

        public string GenderImage { get; set; }
    }
}
