using System;

namespace upravljac
{
    internal class DllImportAttribute : Attribute
    {
        private string v;

        public DllImportAttribute(string v)
        {
            this.v = v;
        }
    }
}