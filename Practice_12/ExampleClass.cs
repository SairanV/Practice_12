using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_12
{
    public class ExClass : IPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChange(nameof(Name));
                }
            }
        }

        public event PropertyEventHandler PropertyChanged;

        protected virtual void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }
}
