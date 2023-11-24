using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_12
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);
    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
