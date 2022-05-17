using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Polynom
    {
        private int a, b, c;
        public Polynom()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Polynom(int other_a, int other_b, int other_c)
        {
            a = other_a;
            b = other_b;
            c = other_c;
        }
        public int Set_Koef_a
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int Set_Koef_b
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int Set_Koef_c
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public static Polynom operator +(Polynom other1, Polynom other2)
        {
            return new Polynom(other1.a + other2.a, other1.b + other2.b, other1.c + other2.c);
        }
        public static Polynom operator -(Polynom other1, Polynom other2)
        {
            return new Polynom(other1.a - other2.a, other1.b - other2.b, other1.c - other2.c);
        }
        public static Polynom operator ++(Polynom other)
        {
            other.a += 1;
            other.b += 1;
            other.c += 1;
            return other;
        }
        public static Polynom operator --(Polynom other)
        {
            other.a -= 1;
            other.b -= 1;
            other.c -= 1;
            return other;
        }
        public static Polynom operator *(Polynom other, int koef)
        {
            return new Polynom(other.a * koef, other.b * koef, other.c * koef);
        }
        public static Polynom operator /(Polynom other, int koef)
        {
            return new Polynom(other.a / koef, other.b / koef, other.c / koef);
        }
        public static bool operator ==(Polynom other1, Polynom other2)
        {
            if (other1.a == other2.a && other1.b == other2.b && other1.c == other2.c)
                return true;
            else return false;
        }
        public static bool operator !=(Polynom other1, Polynom other2)
        {
            if (other1.a == other2.a && other1.b == other2.b && other1.c == other2.c)
                return false;
            else return true;
        }
        public override string ToString()
        {
            return string.Format("{0}x + {1}y + {2}z", a, b, c);
        }

        public static implicit operator int(Polynom other)
            => other.a;

        public static implicit operator Polynom(int other)
            => new Polynom(other, 0, 0);

    }
}
