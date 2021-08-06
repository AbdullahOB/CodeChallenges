using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitmapPlayground.Filters
{
    /// <summary>
    /// Filters the Greyscale component from an image.
    /// </summary>
    public class GreyscaleFilter : IFilter
    {
        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            int rgb;
            Color[,] result = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var p = input[x, y];
                    rgb = (int)((p.R + p.G + p.B) / 3); // take the values of rgb and divide it by 3
                    result[x, y] = Color.FromArgb(rgb, rgb, rgb);
                }
            }

            return result;
        }

        public string Name => "Greyscale Filter";

        public override string ToString()
            => Name;
    }
}
