﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharpArrow.Data
{
   public enum ArrowType : byte
   {
      NONE = 0,
      Null = 1,
      Int = 2,
      FloatingPoint = 3,
      Binary = 4,
      Utf8 = 5,
      Bool = 6,
      Decimal = 7,
      Date = 8,
      Time = 9,
      Timestamp = 10,
      Interval = 11,
      List = 12,
      Struct_ = 13,
      Union = 14,
      FixedSizeBinary = 15,
      FixedSizeList = 16,
      Map = 17
   };
}
