using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_5___Accessibility
{
    public class Circle : Shape
    {
        public sealed override double CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
