using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitRevResourceMVP.Models
{
    public class ResourceModel
    {
        private int idNum;
        private string webLink;
        private string resType;
        private string doiNum;
        private DateTime dateAccessed;
        private string category;
        private string reference;
        private string mainPoint;
        private string notes;
        private int assignIdNum;

        [Key]
        [DisplayName("Resource ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Num { get { return idNum; } set { idNum = value; } }
        
        [DisplayName("Web link")]
        [StringLength(100, ErrorMessage = "Only 100 characters can be used")]
        [Required(ErrorMessage = "Web link is useful so please enter one ")]
        public string Web_Link { get { return webLink; } set { webLink = value; } }

        [DisplayName("Resource type")]
        [StringLength(20, ErrorMessage = "Only 20 characters can be used")]
        [Required(ErrorMessage = "Resource name is useful so please enter one ")]
        public string Resource_Type { get { return resType; } set { resType = value; } }

        [DisplayName("DOI number")]
        public string DOI_Num { get { return doiNum; } set { doiNum = value; } }

        [DisplayName("Date accessed")]
        [Required(ErrorMessage = "A date is useful please select one")]
        public DateTime Date_Accessed { get { return dateAccessed; } set { dateAccessed = value; } }

        [DisplayName("Resource category")]
        [StringLength(20, ErrorMessage = "Only 20 characters can be used")]
        [Required(ErrorMessage = "A resource category is needed so please enter one ")]
        public string Category { get { return category; } set { category = value; } }

        [DisplayName("Resource reference")]
        [StringLength(100, ErrorMessage = "Only 100 characters can be used")]
        [Required(ErrorMessage = "Please enter a valid formatted reference")]
        public string Reference { get { return reference; } set { reference = value; } }

        [DisplayName("Main point")]
        [StringLength(2000, ErrorMessage = "Only 2000 characters can be used")]
        [Required(ErrorMessage = "Please enter what the main point is")]
        public string Main_Point { get { return mainPoint; } set { mainPoint = value; } }

        [DisplayName("Main notes")]
        [Required(ErrorMessage = "Notes are needed so please enter some")]
        [StringLength(4000,ErrorMessage = "Only 4000 characters can be used")]
        public string Main_Notes { get { return notes; } set { notes = value; } }

        // ######
        [Display(Name = "Assignment ID")]
        public int Assign_IdNum { get => assignIdNum; set => assignIdNum = value; }

        [ForeignKey("Assign_IdNum")]
        public virtual ICollection< AssignmentModel> Assignments { get; set; }
    }
}
