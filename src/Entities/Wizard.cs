namespace jogo_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string nome, int level, string heroType) : base(nome, level, heroType)
        {
            this.Name = nome;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return $"{Name} atacou com a sua espada!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {

                return $"{Name} lançou magia super efetiva com bônus de {Bonus}";
            }
            else
            {
                return $"{Name} lançou uma magia com força fraca com bônus de {Bonus}!";
            }
        }
    }
}