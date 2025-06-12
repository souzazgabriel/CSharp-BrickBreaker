using System;

namespace BrickBreaker
{
    public class Raquete : GameObject
    {
        public override void moverObjeto(GameObject gameObject, double x, double y)
        {
            gameObject.y += y;
        }

        public override void alterarTamanho(GameObject gameObject, double altura, double largura)
        {
            gameObject.largura = largura;
        }
    }
}
