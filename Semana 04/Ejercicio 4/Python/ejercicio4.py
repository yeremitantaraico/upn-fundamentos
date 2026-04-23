# Ejercicio 4: Sueldo final de un empleado (condición anidada)
# Enunciado: Este ejercicio combina dos estructuras de control: una para asignar la tarifa horaria
# según la categoría y otra para asignar el porcentaje de bonificación por antigüedad.
# Se utiliza la función exit() para detener el programa si la categoría es incorrecta.

cat = input('Categoría (A/B/C): ').upper()
horas = float(input('Horas: '))
anios = int(input('Años de servicio: ')) # Completa: int

# Elige tarifa por categoría
if cat == "A": tarifa = 33.50    # Completa: "A" y 33.50
elif cat == "B": tarifa = 29.80  # Completa: "B" y 29.80
elif cat == "C": tarifa = 25.70  # Completa: "C" y 25.70
else: 
    print('Categoría inválida'); exit()

# Elige bonificación por años (Lógica simplificada de elif)
if anios <= 3: bono = 0.00       # Completa: 3
elif anios <= 10: bono = 0.10    # Completa: 10
elif anios <= 17: bono = 0.20    # Completa: 17
else: bono = 0.30

# Cálculo y salida con formato de 2 decimales (.2f)
print(f'Sueldo: S/. {tarifa * horas * (1 + bono):.2f}')