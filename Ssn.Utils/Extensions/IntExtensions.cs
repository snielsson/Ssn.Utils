// Copyright 2015 Stig Schmidt Nielsson. All rights reserved.
namespace Ssn.Utils.Extensions {
    public static class IntExtensions {
        public static bool IsEven(this int @this) {
            return @this%2 == 0;
        }
    }
}