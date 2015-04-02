// Copyright 2015 Stig Schmidt Nielsson. All rights reserved.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
namespace Ssn.Utils {
    public static class Reflect {
        public static IEnumerable<Type> GetImplementingTypes<T>(Assembly assembly = null) {
            Type type = typeof (T);
            Debug.Assert(type.IsInterface);
            assembly = assembly ?? Assembly.GetAssembly(type);
            IEnumerable<Type> result = assembly.GetTypes().Where(t => !t.IsInterface && t.GetInterfaces().Contains(type));
            return result;
        }
    }
}