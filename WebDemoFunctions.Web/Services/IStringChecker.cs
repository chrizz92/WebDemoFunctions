using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemoFunctions.Web.Services
{
    public interface IStringChecker
    {
        public string FirstString { get; set; }
        public string SecondString { get; set; }
        public List<char> LowerCaseLettersInBothStrings();
    }
}
