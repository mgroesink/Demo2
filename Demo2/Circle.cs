using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Circle
    {
        #region Fields
        private double _radius;
        private Color _color;
        private Random _rnd = new Random(); 
        #endregion

        #region Properties
        public Color Color
        {
            get { return _color; }
        }

        public double Area
        {
            get { return Math.PI * _radius * _radius; }
        }

        public double Circumference
        {
            get { return Math.PI * 2 * _radius; }
        }

        public double Radius
        {
            get { return _radius; }
        }
        #endregion

        #region Constructors
        public Circle(string input)
        {
            input = input.ToLower();
            if(input.Trim().Length == 0)
            {
                throw new ArgumentException("Je moet een grootte opgeven voor de cirkel");
            }
            if (input[1] != ':')
            {
                throw new ArgumentException("Er ontbrfeekt een dubbele punt");
            }
            if (input[0] != 'd' && input[0] != 's')
            {
                throw new ArgumentException("Moet met een d (diameter) of s (straal) beginnen");
            }

            if (int.Parse(input.Split(':')[1]) < 1)
            {
                throw new ArgumentException("Alleen positieve getallen zijn toegestaan");
            }
            if (input[0] == 'd')
            {
                _radius = double.Parse(input.Split(':')[1]) / 2;
            }
            else
            {
                _radius = int.Parse(input.Split(':')[1]);
            }
            switch (_rnd.Next(0, 4))
            {
                case 0:
                    _color = Color.Red;
                    break;
                case 1:
                    _color = Color.Green;
                    break;
                case 2:
                    _color = Color.Blue;
                    break;
                case 3:
                    _color = Color.Yellow;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Show circle information.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"De cirkel is {Color} en heeft een straal van {_radius} en een diameter van {_radius * 2}";
        } 
        #endregion

    }
}
