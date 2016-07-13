using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace MyUWPStudy.CustomerControllers
{
    class PicAndWordTrigger:StateTriggerBase
    {
        public PicAndWordTrigger()
        {
            Window.Current.SizeChanged += (sender, e) =>
            {
                if (e.Size.Height <= 350)
                {
                    this.SetActive(true);
                }
                else
                {
                    this.SetActive(false);
                }
            };
        }

        private void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
