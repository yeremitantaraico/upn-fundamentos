# Ejercicio 3: Clasificación de IMC (rangos + funciones matemáticas)
# Enunciado: El Índice de Masa Corporal se calcula como IMC = peso / (estatura)^2. 
# Clasifica a la persona según la tabla de rangos de salud predefinidos.
# En Python, utilizamos el operador ** para potencias y la función round() para decimales.

# Entrada de datos convirtiendo a float (decimales)
peso = float(input("Ingrese el peso en kg: "))
estatura = float(input("Ingrese la estatura en metros: "))

# Cálculo de IMC: peso dividido por la estatura al cuadrado
imc = peso / (estatura ** 2)

# Redondeo del IMC a 2 decimales para una lectura limpia
imc_red = round(imc, 2)

print(f"\nTu IMC es: {imc_red}")

# Lógica de clasificación mediante if-elif-else
if imc < 18.5:
    print("Clasificación: Bajo peso (Color: Azul)")
elif imc < 25:
    print("Clasificación: Normal (Color: Verde)")
elif imc < 30:
    print("Clasificación: Sobrepeso (Color: Amarillo)")
else:
    print("Clasificación: Obesidad (Color: Rojo)")