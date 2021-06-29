using System;
using System.Collections.Generic;
using System.Text;

namespace Board.Exceptions
{
    class BoardException : ApplicationException
    {
        public BoardException(string messade) : base(messade) {  }
    }
}
