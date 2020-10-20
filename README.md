# Flyweight


Juego de Ajedrez implementando el patrón de diseño Flyweight. (solo reglas básicas: mover,comer)

Objetivo: para no instanciar 32 objetos(piezas) distintos, se obtiene de cache las 6 piezas del juego y se reutilizan en el tablero para ahorrar memoria. Suponiendo que se estén jugando múltiples partidas en simultaneo el ahorro de memoria puede ser significativo.


Piezas:

P = Peon

C = Caballo

A = Alfil

T = Torre

R = Rey

r = Reina

Tablero:

Casillero negro = fila par y columna par o fila impar y columna impar.

Casillero blanco = fila par y columna impar o fila impar y columna par.

Juego de Damas(sin implementar)

# Factory

Objetivo: crear multiples instancias de distintos juegos de tablero por ej: ajedrez,damas,backdammon,etc.
