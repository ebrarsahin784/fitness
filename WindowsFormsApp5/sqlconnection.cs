using System.Data;

namespace WindowsFormsApp5
{
    internal class sqlconnection
    {
        internal readonly ConnectionState state;
        private string v;

        public sqlconnection(string v)
        {
            this.v = v;
        }
    }
}