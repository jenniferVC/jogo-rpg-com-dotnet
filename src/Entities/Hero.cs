namespace jogo_rpg.src.Entities
{
    public class Hero
    {
        public Hero(string nome, int level, string heroType)
        {
            this.Name = nome;
            this.Level = level;
            this.HeroType = heroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return $"{Name} {Level} {HeroType}";
        }
         public virtual string Attack()
        {
            return $"{Name} atacou com a sua espada!";
        }
    }
}