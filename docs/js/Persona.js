class Persona
{
    #nombre;
    #apellido;
    #edad;

    constructor()
    {

    }
    

    set nombre(newNombre)
    {
        this.#nombre = newNombre;
    }

    get getNombre()
    {
        return this.#nombre;
    }

    set apellido(newApellido)
    {
        this.#apellido = newApellido;
    }

    get getApellido()
    {
        return this.#apellido;
    }

    set edad(newEdad)
    {
        this.#edad = newEdad;
    }

    get getEdad()
    {
        return this.#edad;
    }

    toString()
    {
        return 'Mi nombre es ' + this.#nombre + ' ' + this.#apellido + ' y tengo ' + this.#edad + ' de edad.';  
    }

}