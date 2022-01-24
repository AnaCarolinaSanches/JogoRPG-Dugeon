namespace JogoRPG
{
    public class Knight : Hero
    {
      public Knight (string Name, int Level, string Herotype) : base (Name, Level, Herotype) //chama o construtor da classe pai que tem os mesmos tipos de argumentos
        {
            this.Name     = Name;
            this.Level    = Level;
            this.HeroType = Herotype; 
        } 
         
    }
}