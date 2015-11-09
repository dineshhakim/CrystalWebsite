using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("Company")]
    public class Company
    {
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        public string CompanyName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string CompanyType { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string CompanyAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string EmaildId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ContactNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string BusinessHours { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string FacebookLink { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string LinkedInLink { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string TwitterLink { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string WebsiteLink { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ImageLogo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ImageSavePath { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string CopyRight { get; set; }
        public Company()
        {
            CompanyName = "Crystal Pvt. Ltd.";
            ImageLogo = "logo.jpg";
            ImageSavePath = "~/Images/";
            ContactNo = "9999999";
            Address = "Albany, CA, USA";
            CopyRight = System.DateTime.Now.Year + "-" + "All Rights Reserved";
            FacebookLink = "www.facebook.com";
            LinkedInLink = "www.linkedin.com";
            Description = "This company is great for finding great crystals that you are searching";
        }


    }
}