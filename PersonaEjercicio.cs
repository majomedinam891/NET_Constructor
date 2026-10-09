public class PersonaEjercicio
{
    private string nombre;
    private string apellidos;
    private int documento;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellidos
    {
        get { return apellidos; }
        set { apellidos = value; }
    }

    public int Documento
    {
        get { return documento; }
        set { documento = value; }
    }

    public PersonaEjercicio(string nombre, string apellidos, int documento)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.documento = documento;
    }


    public virtual string Presentarse()
    {
        return $"Hola, soy {nombre} {apellidos} {documento}.";
    }
}