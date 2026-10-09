public class Aprendiz : PersonaEjercicio
{
    private int numeroFicha;
    private string programaFormacion;

    public int NumeroFicha
    {
        get { return numeroFicha; }
        set { numeroFicha = value; }
    }

    public string ProgramaFormacion
    {
        get { return programaFormacion; }
        set { programaFormacion = value; }
    }

    public Aprendiz(string nombre, string apellidos, int documento, int numeroFicha, string programaFormacion) 
        : base(nombre, apellidos, documento)
    {
        this.numeroFicha = numeroFicha;
        this.programaFormacion = programaFormacion;
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} y estudio el programa {programaFormacion}.";
    }
}