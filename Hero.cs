namespace JogoRPG
{
    public class  Hero
    {
        public Hero (string Name, int Level, string Herotype)
        {
            this.Name     = Name;
            this.Level    = Level;
            this.HeroType = Herotype;  
        }
        public  string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " "+ this.Level + " " + this.HeroType;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada!";
        }


    }
}