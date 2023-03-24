using System;

namespace TMS.LTS
{
	public class LTSDC : LTSBase, IDisposable
    {
        public LTSDC() : base(Properties.Settings.Default.ssmsConnectionString) { }

        public LTSDC(string ConnectionString) : base(ConnectionString) { }

        public static LTSDC Context
        {
            get { return new LTSDC(); }
        }
    }
}
