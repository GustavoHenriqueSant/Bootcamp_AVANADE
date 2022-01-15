using System;

namespace mentoria_POO.src.Entities
{
    public class Mago : Hero
    {
        public Mago(string name, string classe) : base(name, classe)
        {
            this.name = name;
            this.nivel = 1;
            this.pontosDeVida = 100;
            this.pontosDeMagia = 50;
            this.classe = classe;
        }

        public override int atacar()
        {
            Random dado = new Random();
            return this.nivel * dado.Next(1,10);
        }

        public int atacar(int magic_buff){
            Random dado = new Random();
            return (this.nivel * dado.Next(1,10)) + magic_buff;
        }
    }
}