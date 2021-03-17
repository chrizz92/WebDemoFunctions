using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebDemoFunctions.Web.Services;

namespace WebDemoFunctions.Web.Validations
{
    public static class StringCheckerValidation
    {
        public static ValidationResult CheckString(string textToCheck)
        {
            if (textToCheck==null||textToCheck=="")
            {
                return new ValidationResult("Feld darf nicht leer sein!");
            }
            foreach (char c in textToCheck)
            {
                if (c >= '0' && c <= '9')
                {
                    return new ValidationResult("Ziffern sind nicht erlaubt!");
                }
            }
            return ValidationResult.Success;
        }
    }
}
