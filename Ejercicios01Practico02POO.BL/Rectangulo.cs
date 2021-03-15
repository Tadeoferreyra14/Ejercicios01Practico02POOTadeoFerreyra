namespace Ejercicios01Practico02POO.BL
{
    public class Rectangulo
    {
        public double LadoMayor { get; set; }
        public double LadoMenor { get; set; }
        public Rectangulo()
        {

        }
        public double GetPerimetro()
        {
            return LadoMayor * 2 + LadoMenor * 2;
        }
        public double GetSuperficie()
        {
            return LadoMayor * LadoMenor;
        }
    }
}
