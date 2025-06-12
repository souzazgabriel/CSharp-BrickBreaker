using System;
using System.Security.Cryptography.X509Certificates;

namespace BrickBreaker
{
    public abstract class GameObject
    {
        public double altura { get; set; }
        public double largura { get; set; }
        public double x { get; set; }
        public double y { get; set; }

        public abstract void moverObjeto(GameObject gameObject, double x, double y);
        public abstract void alterarTamanho(GameObject gameObject, double altura, double largura);
    }
}
