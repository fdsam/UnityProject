# Físicas en Unity

- colisione con una esfera ,  incrementar un contador , cambio de color.

    Creamos 2 esferas uno de ellos es controlado por el jugador mediante entradas por el teclado, luego a añadimos un rigidboy a la esfera, eso tambien hacemos con la otra esfera con un rigidbody, pero esta esfera su rigidbody es Kinematic.
    La velocidad de la esfera del jugador va moviendo mediante  AddForce(move * speed);
    
    Creamos un atributo contador va incrementando si colisiona con un objeto mediante la funcion OnCollisionEnter.
    
    Para cambiar el color de la esfera usamos Trigger, cada vez el jugador produce un trigger cambia de color dependiente la duracion del trigger.
    
    
    private void OnTriggerEnter(Collider other)
    {
        player.transform.GetComponent<Renderer>().material.color = redcolor;
    }

    private void OnTriggerExit(Collider other)
    {
        player.transform.GetComponent<Renderer>().material.color = bluecolor;
    }

    private void OnTriggerStay(Collider other)
    {
        player.transform.GetComponent<Renderer>().material.color = blackcolor;
    }

![Screenshot](f1.gif)

- tercer objeto que detectar colisiones y que se mueva con las teclas: I, L, J, M

Creamos otro script y le asignamos al tercer objeto , esta vez las entradas por el teclado los cambiamos mediante Input.GetKeyDown(KeyCode - I,L,J,M) y le asignamos un rigidbody , para moverse usamos AddForce(0, 0, dependiendo la posicion, ForceMode.Impulse) .

![Screenshot](f2.gif)
