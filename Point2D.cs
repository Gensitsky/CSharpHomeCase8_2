﻿using System;

namespace CSharpHomeCase8_2
{
    class Point2D<T> where T : struct, IComparable<T>
    {
        T x;
        T y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point2D(T x, T y)
        {
            this.x = x; this.y = y;
        }

        public Point2D()
        {
            this.x = default(T); this.y = default(T);
        }
    }
}
