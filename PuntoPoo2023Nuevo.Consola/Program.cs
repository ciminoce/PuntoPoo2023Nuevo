using PuntoPoo2023Nuevo.Entidades;

namespace PuntoPoo2023Nuevo.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajar con Puntos");
            var coordX = PedirInt("Ingrese la coord. X del punto:");
            var coordY = PedirInt("Ingrese la coord. Y del punto:");

            Punto punto=new Punto(coordX,coordY);
            
            Console.WriteLine($"El punto {punto.ToString()} se encuentra en el {punto.Cuadrante} cuadrante");
            Console.WriteLine($" y su distancia al origen es {punto.GetDistanciaOrigen()}");
            Console.WriteLine($"Coordenadas polares del punto={punto.GetCoordPolares()}");

        }

        private static int PedirInt(string mensaje)
        {
            int nro;
            do
            {
                string str;
                Console.Write(mensaje);
                str = Console.ReadLine();
                if (int.TryParse(str, out nro))
                {
                    break;
                }
                Console.WriteLine("Número no válido");

            } while (true);
            return nro;
        }
    }
}