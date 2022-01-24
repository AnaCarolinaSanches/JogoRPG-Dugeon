namespace JogoRPG
{
    public class Ninja : Hero
    {
       public Ninja(string Name, int Level, string Herotype) : base (Name, Level, Herotype)
       {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = Herotype;
       }
       public override string Attack()
        {
            return this.Name + " Atacou com sua Lança!";
        }   
    }
}