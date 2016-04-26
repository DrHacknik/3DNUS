using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DNUS.i18n
{
    public class LocalizedForm : Form
    {
        public LocalizedForm()
        {
            Localizer.SubscribeHook(this);
            this.Load += LocalizedForm_Load;
        }

        private void LocalizedForm_Load(object sender, EventArgs e)
        {
            Localizer.PleaseTrigger(this);
        }

        ~LocalizedForm()
        {
            this.Load -= LocalizedForm_Load;
            Localizer.UnsubscribeHook(this);
        }

        public virtual IEnumerable<Control> TranslationTrigger()
        {
            return null;
        }
    }
}
