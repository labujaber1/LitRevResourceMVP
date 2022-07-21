using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LitRevResourceMVP.Models
{
    public class AssignmentModel
    {
        private int assignIdNum;
        private string assignName;
        private DateTime dueDate;
        private int trimester;
        private int modIdNum;

        [Key]
        [DisplayName("Assignment ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Assign_IdNum { get => assignIdNum; set => assignIdNum = value; }

        [DisplayName("Assignment name")]
        [Required(ErrorMessage = "Assignment name is required so please enter one")]
        [StringLength(100, ErrorMessage = "Only 100 characters can be used")]
        public string Assign_Name { get => assignName; set => assignName = value; }

        [DisplayName("Due date")]
        [DataType(DataType.Date)]
        public DateTime Due_Date { get => dueDate; set => dueDate = value.Date; }

        [DisplayName("Trimester")]
        public int Assign_Trimester { get => trimester; set => trimester = value; }

        // ######
        [DisplayName("Module ID")]
        public int Mod_IdNum { get => modIdNum; set => modIdNum = value; }

        [ForeignKey("Mod_IdNum")]
        public virtual ICollection<ModuleModel> Module { get; set; }
    }
}
