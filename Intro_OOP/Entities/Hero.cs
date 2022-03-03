namespace Intro_OOP.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string type)
        {
            this.name = name;
            this.level = level;
            this.type = type;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return this.name + ", " + this.level + ", " + this.type;
        }

        public virtual string Attack()
        {
            return this.name + " atacou com a sua espada!!";
        }

        public string name;
        public int level;
        public string type;
    }
}