using Microsoft.Data.SqlClient;

namespace RestApi.Web.Patterns
{
    public sealed class Singleton
    {
        private static Singleton? _instance = null;
        private static int _counter = 0;
        private static readonly object InstanceLock = new object();

        

        private Singleton()
        {
            _counter++;
        }

        public static Singleton Instance
        {
            get
            {
                return _instance ?? (_instance = new Singleton());
            }
        }

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (InstanceLock)
                    {
                        return _instance ?? (_instance = new Singleton());
                    }
                }
                return _instance;
            }
        }

        
    }
    
}
