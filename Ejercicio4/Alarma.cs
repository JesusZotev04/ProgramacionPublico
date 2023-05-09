class Alarma {
    public string NumeroTelefono { get; private set; }
    public bool Activado { get; private set; }

    public Alarma(in string NumeroTelefono) {
        this.NumeroTelefono = NumeroTelefono;
        this.Activado = false;
    }

    public void ActivarAlarma() {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Llamando a {NumeroTelefono}...");
        Console.BackgroundColor = ConsoleColor.Black;
        this.Activado = true;
    }
}