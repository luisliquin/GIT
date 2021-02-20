enum Direccion{
    Arriba = "UP",
    Abajo = "DOWN",
    Derecha = "RIGHT",
    Izquierda = "LEFT"
}

interface Bola {
    size: number
    posicionInicial: Direccion
}

const bola: Bola = {
    size: 10,
    posicionInicial: Direccion.Abajo
}