using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_LINQ02
{
    internal class MatchCharsComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return string.Concat(x.OrderBy(c => c)) == string.Concat(y.OrderBy(c => c));
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return string.Concat(obj.OrderBy(c => c)).GetHashCode();
        }
    }
}
