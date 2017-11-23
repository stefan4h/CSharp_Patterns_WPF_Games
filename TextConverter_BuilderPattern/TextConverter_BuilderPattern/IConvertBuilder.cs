using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverter_BuilderPattern
{
    interface IConvertBuilder
    {
        IFileRepresentation ReformatFile(IFileRepresentation oldFile);
        IFileRepresentation GetFileRepresentation();
    }
}
