using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePad.Test
{
    interface Flyable
    {
        void Fly();
    }

    abstract class Airplane : Flyable
    {
        public abstract void Fly(); // debe ser publico
    }

    abstract class Bird : Flyable
    {
        public abstract void Fly(); // si es protected no funciona

    }

    abstract class Airplane2
    {
        public abstract void fly();
    }

    abstract class Bird2 : Airplane
    {

    }
}
