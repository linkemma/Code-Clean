using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.Presentador
{
    public interface IPresentador<FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}
