namespace Task_1.Class_Chef_in_CSharp
{
    using System;
    using Task_1.Class_Chef_in_CSharp.Dishes;
    using Task_1.Class_Chef_in_CSharp.Products;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();            

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException("Must implement class Bowl"); 
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException("Must implement class Carrot");
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException("Must implement class Potato");
        }

        private void Cut(Vegetable potato)
        {
            ///...
        }        
    }
}
