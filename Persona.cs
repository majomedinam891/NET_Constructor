class Persona {
    public string nombre;
    public int edad;


public Persona() {
        nombre = "sin nombre";
        edad = 0;
}

public Persona(string nombre) {
        this.nombre = nombre;
        edad = 0;
}

public Persona(string nombre, int edad){
        this.nombre = nombre;
        this.edad = edad;
}
}
