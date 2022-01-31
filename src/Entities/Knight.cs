namespace jogo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string nome, int level, string heroType) : base(nome, level, heroType)
        {
            this.Name = nome;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}