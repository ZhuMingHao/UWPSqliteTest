using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSqliteTest
{
    public class SingletonProvider<T> where T : new()
    {
        public SingletonProvider() { }
        public static T Instance
        {
            get
            {
                return SingletionCreator.instance;
            }
        }
        class SingletionCreator
        {
            static SingletionCreator() { }
            internal static readonly T instance = new T();

        }

    }
}
