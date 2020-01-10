# Introducción a los scripts en Unity

- Movimiento del personaje :
  Variable "spped" es un campo público que permita graduar la velocidad del movimiento.
  
  Entrada de teclados con awsd o flecha : 
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
  Desplazamiento : player.transform.Translate(move * Time.deltaTime * speed); ya que los input recibe valor entre 0 y 1 ó 0 y -1
  
  -Rotación del personaje : 
     player.transform.Rotate(0,10,0);

![Screenshot](p3.gif)
