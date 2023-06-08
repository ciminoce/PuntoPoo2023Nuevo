namespace PuntoPoo2023Nuevo.Entidades
{
    public class Punto
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public Cuadrante Cuadrante { get; private set; }
        public Punto(int coordX, int coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
            Cuadrante = SetCuadrante();
        }

        private Cuadrante SetCuadrante()
        {
            if (this.CoordX>=0 && this.CoordY>=0)
            {
                return Cuadrante.Primero;
            }
            else if (this.CoordX<0 && this.CoordY>0)
            {
                return Cuadrante.Segundo;
            }else if(this.CoordX<0 && this.CoordY < 0)
            {
                return Cuadrante.Tercero;
            }
            else
            {
                return Cuadrante.Cuarto;
            }
        }

        public double GetDistanciaOrigen() => Math.Sqrt(Math.Pow(CoordX, 2) 
            + Math.Pow(CoordY, 2));

        public override string ToString()
        {
            return $"({CoordX},{CoordY})";
        }

        public string GetCoordPolares()
        {
            var distancia=this.GetDistanciaOrigen();
            var phi = Math.Atan(this.CoordY / this.CoordX);
            return $"D={distancia}, Phi={phi}";
        }
    }
}