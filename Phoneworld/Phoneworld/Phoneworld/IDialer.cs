using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Phoneworld
{
    public interface IDialer{
        Task<bool> DialAsync(string number);
    }
}
