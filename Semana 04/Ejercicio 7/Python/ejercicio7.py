# Ejercicio 7: Promedio final del alumno (2 mejores prácticas)
# Enunciado: Calcula el promedio final descartando la práctica más baja.
# La fórmula es: prom_final = (parcial + final + prom_prac) / 3.
# En Python, la función min() acepta múltiples argumentos directamente,
# lo que facilita encontrar el valor más pequeño.

# Entrada de datos
parcial = float(input("Ingresa examen parcial: "))
final = float(input("Ingresa examen final: "))
p1 = float(input("Ingresa práctica 1: "))
p2 = float(input("Ingresa práctica 2: "))
p3 = float(input("Ingresa práctica 3: "))

# Paso 1: Identificar la práctica más baja
practica_minima = min(p1, p2, p3)

# Paso 2: Calcular el promedio de las dos prácticas más altas
# Sumamos las tres y restamos la mínima para que queden las dos mejores
prom_prac = (p1 + p2 + p3 - practica_minima) / 2

# Paso 3: Calcular promedio final
prom_final = (parcial + final + prom_prac) / 3

print(f"\nPromedio de prácticas: {prom_prac}")
print(f"Promedio final: {round(prom_final)}")

# Clasificación mediante estructuras condicionales
if prom_final >= 18:
    print("Excelente")
elif prom_final >= 14:
    print("Bueno")
elif prom_final >= 10:
    print("Regular")
else:
    print("Deficiente")