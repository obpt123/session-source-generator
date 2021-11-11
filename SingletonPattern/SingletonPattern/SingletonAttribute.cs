using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false, Inherited =false)]
    public sealed class SingletonAttribute:Attribute
    {

    }
}
