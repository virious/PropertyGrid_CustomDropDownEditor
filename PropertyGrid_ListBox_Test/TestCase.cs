using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;

namespace PropertyGrid_ListBox_Test
{
    class TestCase
    {
        public TestCase()
        {
            Manufacturer = new List<TypeCodes>();
        }

        [DisplayName("Manufacturer Preparation Type Code")]
        [Editor(typeof(TypeCodeEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(TypeCodeTypeConverter))]
        public List<TypeCodes> Manufacturer { get; set; }
    }
}
