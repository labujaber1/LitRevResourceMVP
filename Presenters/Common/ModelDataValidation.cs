using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitRevResourceMVP.Presenters.Common
{
    public class ModelDataValidation
    {
        /// <summary>
        /// Used to print error messages assigned in resourcemodel for each [required] message type
        /// </summary>
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> vResults = new List<ValidationResult>();
            ValidationContext vContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, vContext, vResults, true);
            if (isValid == false)
            {
                foreach (var item in vResults)
                    errorMessage += "- " + item.ErrorMessage + "\n";
                
                throw new Exception(errorMessage);
            }
            

        }

    }
}
