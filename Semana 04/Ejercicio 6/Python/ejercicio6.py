# Ejercicio 6: Calificación cualitativa según promedio
# Enunciado: El programa recibe un promedio y asigna una categoría cualitativa.
# Se utiliza la estructura if - elif - else para manejar los rangos de forma ordenada.
# Es importante validar que el número esté entre 0 y 20 antes de calificar.

# Entrada de datos
promedio = float(input("Ingrese el promedio (0-20): "))

# Proceso: Validación y clasificación por rangos
if promedio < 0 or promedio > 20:
    print("Valor inválido")
    
elif promedio <= 5:
    # Rango de 0 a 5
    print("Calificación: Deficiente")
    
elif promedio <= 10:
    # Rango de 6 a 10
    print("Calificación: Regular")
    
elif promedio <= 14:
    # Rango de 11 a 14
    print("Calificación: Bueno")
    
else:
    # Rango de 15 a 20
    print("Calificación: Excelente")