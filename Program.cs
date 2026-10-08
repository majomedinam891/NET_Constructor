// var gato = new Mascota("Misu", 3);
// gato.Presentarse();

// Console.WriteLine(new Saludo().Decir("Ana"));

// Estudiante.Presentarse();
// var l1 = new Libro("Cien años de soledad", "García Márquez");
// var l2 = new Libro("El coronel no tiene quien le escriba");


Persona objPersona1 = new Persona();
Console.WriteLine($"Primer Ej: de objPersona1 {objPersona1.nombre}");

Persona objPersona2 = new Persona("María");
Console.WriteLine($"Segundo Ej: de objPersona2 {objPersona2.nombre}");

Persona objPersona3 = new Persona("Maria", 18);
Console.WriteLine($"Tercer Ej: de objPersona3 nombre {objPersona3.nombre} , edad: {objPersona3.edad}");

Estudiante ObjEstudiante1 = new Estudiante("Juan", "Once");
Console.WriteLine($"Ejemplo estudiante nombre {ObjEstudiante1.nombre} y grado {ObjEstudiante1.grado}" );

Perritos objPerritos1 = new Perritos("Bulldog", "Mediano");
Console.WriteLine($"Ejemplo perrito raza {objPerritos1.raza} y tamaño {objPerritos1.tamaño}");