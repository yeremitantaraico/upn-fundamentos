# Ejercicio 5: Acceso a un servicio por edad (condicional doble)
# Enunciado: El sistema verifica la mayoría de edad (18 años).
# En caso de no cumplirla, muestra el mensaje de denegación y utiliza la 
# función integrada abs() para mostrar los años restantes de forma positiva.

# Entrada de datos
edad = int(input("Ingrese su edad: "))

# Proceso: Evaluación de la mayoría de edad
if edad >= 18:
    print("Acceso permitido. Bienvenido.")
else:
    # abs() es una función nativa de Python (no requiere importar librerías)
    faltantes = abs(edad - 18)
    
    print("Acceso denegado.")
    print(f"Te faltan {faltantes} año(s) para registrarte.")