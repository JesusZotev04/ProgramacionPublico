class Persona {
    public int PosicionHorizontal { get; private set; }
    public int PosicionVertical { get; private set; }

    public Persona(in int PosicionHorizontal, in int PosicionVertical) {
        this.PosicionHorizontal = PosicionHorizontal;
        this.PosicionVertical = PosicionVertical;
    }

    public void MoverIzquierda() => PosicionHorizontal--;
    public void MoverDerecha() => PosicionHorizontal++;

    public void ImprimirPersona() {
        Console.SetCursorPosition(PosicionHorizontal, PosicionVertical); 
        Console.WriteLine(" O");
        Console.SetCursorPosition(PosicionHorizontal, Console.CursorTop);
        Console.WriteLine("/|\\");
        Console.SetCursorPosition(PosicionHorizontal, Console.CursorTop);
        Console.WriteLine("/ \\");
    }
}