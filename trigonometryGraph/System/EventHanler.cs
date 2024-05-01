
namespace System
{
    internal class EventHanler
    {
        private Action<object, EventArgs> form1_Load;

        public EventHanler(Action<object, EventArgs> form1_Load)
        {
            this.form1_Load = form1_Load;
        }
    }
}