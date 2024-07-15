namespace Open_Closed_Principle
{
    internal class Rice : IRecepie
    {
        public string Ingredients { get; set; }
        public string Boiling { get; set; }

        public string GetIngredients ()
        {
            return Ingredients + Boiling;
        }
    }
}
