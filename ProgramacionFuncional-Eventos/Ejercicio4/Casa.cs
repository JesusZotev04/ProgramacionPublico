class Casa {
    public int PosicionHorizontal { get; set; }
    public int PosicionVertical { get; set; }
    public delegate void ManejadorEvento();
    public event ManejadorEvento Evento;

    public Casa(in int PosicionHorizontal, in int PosicionVertical) {
        this.PosicionHorizontal = PosicionHorizontal;
        this.PosicionVertical = PosicionVertical;
    }

    public void ActivaAlarma() {
        Evento?.Invoke();
    }

    public void ImprimirCasa() {
        Console.SetCursorPosition(this.PosicionHorizontal, this.PosicionVertical);
        Console.WriteLine("    ▄██▄    ");
        Console.WriteLine("  ▄██████▄  ");
        Console.WriteLine(" ▀█┼█░░█┼█▀ ");
        Console.WriteLine("▄▄███▄▄███▄▄");
    }
}