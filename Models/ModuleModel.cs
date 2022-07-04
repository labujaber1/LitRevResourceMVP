using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LitRevResourceMVP.Models
{
    public class ModuleModel
    {
        private int modIdNum;
        private string modName;
        private string modDateYear;

        [Key]
        [DisplayName("Module ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Mod_IdNum { get => modIdNum; set => modIdNum = value; }

        [DisplayName("Module Name")]
        [Required(ErrorMessage = "Module name is required so please enter one")]
        [StringLength(50, ErrorMessage = "Only 50 characters can be used")]
        public string Mod_Name { get => modName; set => modName = value; }

        [DisplayName("Module DateYear")]
        [Required(ErrorMessage = "Module year date is required please enter yyyy")]
        [Range(2020, 2050, ErrorMessage = "Be serious, the allowed year range is 2020-2050, " +
            "and even thats ambitious for this app, try again \n(anyway apparently society will collapse by 2040," +
            " saw it on a youtube video so must be true!).")]
        public string Mod_DateYear { get => modDateYear; set => modDateYear = value; }

        public virtual ICollection<AssignmentModel> Assignment { get; set; }
    }
}
