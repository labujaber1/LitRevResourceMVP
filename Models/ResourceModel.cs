using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitRevResourceMVP.Models
{
    /// <summary>
    /// Resource model conataining fields inline with database table
    /// </summary>
    public class ResourceModel
    {
        private int idNum;
        private string category;
        private string webLink;
        private string resType;
        private DateTime dateAccessed;
        private string reference;
        private string doiNum;
        private string mainPoint;
        private string notes;
        private int assignIdNum;

        [Key]
        [DisplayName("Resource ID")]
        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Num { get { return idNum; } set { idNum = value; } }

        [DisplayName("Resource category")]
        [StringLength(50, ErrorMessage = "Resource category - Only 50 characters can be used")]
        [Required(ErrorMessage = "A resource category is needed so please enter one ")]
        public string Category { get { return category; } set { category = value; } }

        [DisplayName("Web link")]
        [StringLength(300, ErrorMessage = "Web link - Only 300 characters can be used")]
        [Required(ErrorMessage = "Web link is useful so please enter one ")]
        public string Web_Link { get { return webLink; } set { webLink = value; } }

        [DisplayName("Resource type")]
        [StringLength(50, ErrorMessage = "Resource type - Only 50 characters can be used")]
        [Required(ErrorMessage = "Resource name is useful so please enter one ")]
        public string Resource_Type { get { return resType; } set { resType = value; } }

        [DisplayName("Date accessed")]
        [Required(ErrorMessage = "A date is useful please select one")]
        public DateTime Date_Accessed { get { return dateAccessed; } set { dateAccessed = value.Date; } }

        [DisplayName("Resource reference")]
        [StringLength(300, ErrorMessage = "Resource reference - Only 300 characters can be used")]
        [Required(ErrorMessage = "Please enter a valid formatted reference")]
        public string Reference { get { return reference; } set { reference = value; } }

        [DisplayName("DOI number")]
        [StringLength(50, ErrorMessage = "DOI number - Only 50 characters can be used")]
        public string DOI_Num { get { return doiNum; } set { doiNum = value; } }

        [DisplayName("Main point")]
        [StringLength(2000, ErrorMessage = "Main point - Only 2000 characters can be used")]
        [Required(ErrorMessage = "Please enter what the main point is")]
        public string Main_Point { get { return mainPoint; } set { mainPoint = value; } }

        [DisplayName("Main notes")]
        [Required(ErrorMessage = "Main notes - Notes are needed so please enter some")]
        [StringLength(4000,ErrorMessage = "Only 4000 characters can be used")]
        public string Main_Notes { get { return notes; } set { notes = value; } }

        // ######
        [Display(Name = "Assignment ID")]
        [ReadOnly(true)]
        public int Assign_IdNum { get => assignIdNum; set => assignIdNum = value; }
                
    }
}
