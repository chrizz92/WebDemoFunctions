using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebDemoFunctions.Web.Validations;

namespace WebDemoFunctions.Web.Services
{
    public class InMemoryStringChecker : IStringChecker
    {
        [CustomValidation(typeof(StringCheckerValidation),nameof(StringCheckerValidation.CheckString))]
        public string FirstString { get; set; }

        [CustomValidation(typeof(StringCheckerValidation), nameof(StringCheckerValidation.CheckString))]
        public string SecondString { get; set; }

        private List<char> _Chars { get; set; }

        public List<char> LowerCaseLettersInBothStrings()
        {
            _Chars = new List<char>();
            foreach (char lcChar in FirstString)
            {
                if (lcChar >= 'a' && lcChar <= 'z')
                {
                    if (SecondString.Contains(lcChar)&& ! _Chars.Contains(lcChar))
                    {
                        _Chars.Add(lcChar);
                    }
                }
            }

            return _Chars;
        }

        
    }
}
