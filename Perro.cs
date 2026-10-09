class Perro : Animal
{
    public string nombre;
    public Perro(string pRaza, string pNombre, int pEdad) : base(pRaza, pEdad)
    {
        this.nombre = pNombre;
    }

    public string Ladrar()
    {
        return "Woff Woff";
    }
}