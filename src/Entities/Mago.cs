namespace POO.src.Entities
{
    public class Mago : Hero
    {
        public Mago(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " Lançou Magia Super Forte com Bonus: " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia com Bonus: " + Bonus;
            }
        }
        
    }
}