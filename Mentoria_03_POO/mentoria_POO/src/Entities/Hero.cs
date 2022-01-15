using System;

namespace mentoria_POO.src.Entities
{
    public class Hero
    {
        public string name { get; set; }
        public int nivel { get; set; }
        public int pontosDeVida { get; set; }
        public int pontosDeMagia { get; set; }
        public string classe { get; set; }

        public Hero(string name, string classe){
            this.name = name;
            this.nivel = 1;
            this.pontosDeVida = 100;
            this.pontosDeMagia = 50;
            this.classe = classe;
        }

        public override string ToString()
        {
            string result =  "Name: " + this.name + "\n";
            result += "Nivel: " + this.nivel + "\n";
            result += "Pontos de vida: " + this.pontosDeVida + "\n";
            result += "Pontos de magia: " + this.pontosDeMagia + "\n";
            result += "Classe: " + this.classe;

            return result;
        }

        public virtual int atacar(){
            Random random = new Random();
            return this.nivel * random.Next(1,20);      
        }

        public void batalhar(Inimigo inimigo){
            int my_damage = this.atacar(), enemy_damage = inimigo.atacar();

            if(my_damage == enemy_damage){
                this.pontosDeVida -= enemy_damage;
                inimigo.pontosDeVida -= my_damage;
                System.Console.WriteLine($"Ambos atacaram com a mesma força, CAUSANDO {my_damage} DE DANO!");
            } else if(my_damage > enemy_damage){
                inimigo.pontosDeVida -= my_damage;
                System.Console.WriteLine($"NOSSO HERÓIS LEVOU ESSA, causando {my_damage} de dano!");
            } else {
                this.pontosDeVida -= enemy_damage;
                System.Console.WriteLine($"Pelo jeito nem sempre o bem vence o mal, mas n perca as esperanças, o inimigo causou {enemy_damage} ponto de dano!");
            }
        }
    }
}