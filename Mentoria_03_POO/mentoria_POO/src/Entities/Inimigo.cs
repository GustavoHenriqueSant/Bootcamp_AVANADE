using System;

namespace mentoria_POO.src.Entities
{
    public class Inimigo : Hero
    {
        public Inimigo(string name, string classe) : base(name, classe)
        {
            this.name = name;
            this.nivel = 1;
            this.pontosDeVida = 150;
            this.pontosDeMagia = 50;
            this.classe = classe;
        }

        public override int atacar()
        {
            Random dado = new Random();
            return dado.Next(1, 13) * this.nivel;
        }
    }
}