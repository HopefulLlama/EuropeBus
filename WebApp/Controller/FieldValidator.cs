using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Controller
{
    public class FieldValidator
    {
        public static bool validateTextLength(string text, int upperBound)
        {
            return text.Length < upperBound;
        }
    }
}