# Ejercicio 1: Aplicar descuento por compra mínima.
# Si el monto es mayor o igual a 100, se aplica un 10% de descuento.
# En caso contrario, no se aplica ningún descuento.
# El total a pagar es el monto ingresado menos el descuento calculado.

# Solicitar al usuario que ingrese el monto de la compra
monto = float(input("Ingrese el monto de la compra: "))

# Inicializar el descuento
descuento = 0

# Verificar si el monto es mayor o igual a 100 para aplicar el descuento
if monto >= 100:
    descuento = monto * 0.10  # Calcular el descuento del 10%   

# Calcular el total a pagar
total = monto - descuento   

# Mostrar el resultado al usuario
print(f"El monto de la compra es: ${monto:.2f}")
print(f"El descuento aplicado es: ${descuento:.2f}")
print(f"El total a pagar es: ${total:.2f}")