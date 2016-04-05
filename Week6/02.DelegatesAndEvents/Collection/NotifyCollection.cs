using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public delegate void ChangeEventHandler(object sender, NotifyArgs e);

    public class NotifyCollection : ArrayList
    {
        public event ChangeEventHandler CollectionChanged;

        public override int Add(object value)
        {
            int i = base.Add(value);
            string note = String.Format("Added new item with value {0}.", value);
            NotifyArgs notify = new NotifyArgs(note);
            this.OnChanged(notify);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            string note = String.Format("Collection has cleared.");
            NotifyArgs notify = new NotifyArgs(note);
            this.OnChanged(notify);
        }

        public override object this[int index]
        {
            set
            {
                string note = String.Format("The value {0} of index {1} has changed to {2}", this[index], index, value);
                NotifyArgs notify = new NotifyArgs(note);
                base[index] = value;
                this.OnChanged(notify);
            }
        }

        private void OnChanged(NotifyArgs note)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, note);
            }
        }
    }
}
