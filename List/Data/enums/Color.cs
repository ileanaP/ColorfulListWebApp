using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.enums
{
    public class Color
    {
        public string Value;
        private Color(string value) { this.Value = value; }
        public static Color DefaultBlue { get { return new Color("#9decfd"); } }
        public static Color DefaultDarkBlue { get { return new Color("#374193"); } }
        public static Color White { get { return new Color("#ffffff"); } }
        public static Color DirtyBlue { get { return new Color("#5078AF"); } }

    }
}
