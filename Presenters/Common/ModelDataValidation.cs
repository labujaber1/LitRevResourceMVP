using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LitRevResourceMVP.Presenters.Common
{
    /// <summary>
    /// Include low level user input validation in each model class. 
    /// </summary>
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
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                    
                }
                throw new Exception(errorMessage);
            }
        }

    }
}
