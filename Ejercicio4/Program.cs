internal class Program
{
    private static void Main(string[] args)
    {
        Alarma alarma = new Alarma("112");
        Casa casa = new Casa(0, 0);
        Persona persona = new Persona(20, 1);
        ConsoleKeyInfo tecla;

        casa.Evento += alarma.ActivarAlarma;
        while(!alarma.Activado) {
            Console.Clear();
            casa.ImprimirCasa();
            persona.ImprimirPersona();

            tecla = Console.ReadKey(true);
            switch(tecla.Key) {
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    persona.MoverIzquierda();
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if(persona.PosicionHorizontal < 50) persona.MoverDerecha(); // Establecemos un límite
                    break;
            }
            // Ha entrado en la casa
            if(persona.PosicionHorizontal <= 11) casa.ActivaAlarma();
        }
        Console.ReadKey(true);
    }
}