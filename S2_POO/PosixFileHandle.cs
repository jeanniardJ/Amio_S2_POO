using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO
{
    internal class PosixFileHandle
    {

        int _fd;

        //Destruction called by Garbage Collector
        ~PosixFileHandle()
        {
            Console.WriteLine($"[Closed] fd={_fd} fermé pour '/'");
        }

        private void ReleaseHandle()
        {
            if(_fd >= 0)
            {
                NativeMethods.close(_fd);
                _fd = -1;
            }
        }
    }
}
