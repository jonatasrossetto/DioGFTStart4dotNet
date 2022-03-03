namespace Intro_OOP.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string type)
        {
            this.name = name;
            this.level = level;
            this.type = type;
        }
        public override string Attack()
        {
            return this.name + " lançou uma magia!!!!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 10)
            {
                return this.name + " lançou um SUPER ataque de magia com bonus " + bonus + " !!!";
            }
            else
            {
                return this.name + " está sem energia e lançou uma magia fraca com bonus " + bonus + " !!!";
            }
        }
    }
}