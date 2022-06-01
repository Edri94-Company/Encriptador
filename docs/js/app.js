
var persona;
$( document ).ready(function() {
    console.log("hola");
    persona = new Persona();

    persona.nombre = 'alan';
    persona.apellido = 'angulo';
    persona.edad = 27;

    console.log(persona.getNombre);

    $("#nombre").val(persona.getNombre);
    $("#apellido").val(persona.getApellido);
    $("#edad").val(persona.getEdad);

});




