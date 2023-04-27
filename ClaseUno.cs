namespace practicarMocks
{
    public class ClaseUno
    {
        private readonly ClaseDos C2;

        public ClaseUno(ClaseDos c2)
        {
            C2 = c2;
        }

        public string HazCosas(int num)
        {
            var uwu = C2.DameString();
            return $"Numero {num} : {uwu}";
        }
    }
}
