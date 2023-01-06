using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ClaseSingleton
    {
        private static ClaseSingleton instance = null;
        public string mensajeSingleton;

        protected ClaseSingleton()
        {
            mensajeSingleton = "Saludos de vuelta mundo exterior, son un Singleton";
        }

        public static ClaseSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClaseSingleton();

                return instance;
            }
        }

    }
}
