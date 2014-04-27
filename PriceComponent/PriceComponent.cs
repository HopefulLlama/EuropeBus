using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceComponent
{
    // Adapted from http://msdn.microsoft.com/en-us/library/ms229644(v=vs.90).aspx
    public class PriceComponent : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) )
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            else
            {
                e.Handled = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.LongValue > 10000 || this.DecimalValue > 10000)
            {
                this.ForeColor = Color.Red;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }

        // Try to get a LongValue
        public long LongValue
        {
            get
            {
                try
                {
                    return long.Parse(this.Text);
                }
                catch (FormatException fex)
                {
                    return 0;
                }
            }
        }

        // Try to get a Decimal value
        public decimal DecimalValue
        {
            get
            {
                try
                {
                    return Decimal.Parse(this.Text);
                }
                catch (FormatException fex)
                {
                    return 0;
                }
            }
        }

    }
}
