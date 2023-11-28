namespace Triangle
{
    public static class Triangle
    {
        /*Необходимо написать библиотеку, в которой будет один метод, 
         * который по трем сторонам треугольника будет определять, 
         * является треугольник остроугольным, прямоугольным или тупоугольным. 
         * Метод должен работать максимально быстро. */

        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            var aa = a * a;
            var bb = b * b;
            var cc = c * c;

            if(aa > bb+cc || bb > aa + cc || cc > aa + bb)
            {
                return TriangleType.Obtuse;
            }

            if (aa == bb + cc || bb == aa + cc || cc == aa + bb)
            {
                return TriangleType.Rectangular;
            }

            return TriangleType.Acute;
        }
    }
}