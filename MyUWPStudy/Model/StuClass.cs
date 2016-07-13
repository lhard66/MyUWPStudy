using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUWPStudy.Model
{
    public class StuClass : INotifyPropertyChanged
    {
        public string ClassName { get; set; }
        public int ClassNum { get; set; }
        private int classAge;

        public int ClassAge
        {
            get { return classAge; }
            set
            {
                classAge = value;
                PropertyChangedEventHandler handler = this.PropertyChanged;
                if (handler != null)
                {
                    //nameof的用法举例！
                    //handler.Invoke(this, new PropertyChangedEventArgs(nameof(ClassAge)));
                    handler.Invoke(this, new PropertyChangedEventArgs("ClassAge"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
