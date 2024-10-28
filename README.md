# .

![Aplicación Escritor Gestión de Biblioteca.png](Untitled%20f21944cc385643169095429fecbc6dae/Aplicacin_Escritor_Gestin_de_Biblioteca.png)

# Gestión biblioteca: Letras

### Requisitos

- Formularios: 8-14
- BBDD: CRUD → 1-4 clases
- Controladores: 10-18
- MVC
- Compilación, ejecución y estándares de codificación

### Estándares mínimos

- 8 formularios
- L/E en formato
- Complir MVC
- Compilación correcta
- Sin errores en tiempo de ejecución
- Consulta, modificación, inserción y borrado
- Configuración para general ejecutables
- Configuración para generar documentación XML

### Controladores obligatorios

- Label
- Text box
- Button
- Combo box
- Group box
- Date time picker
- Numeric hup down
- Menu strip
- Data grid view

## Clases y funciones principales:

- `Usuario`: Información de usuario
- `Préstamo`: Información del préstamo como el libro, el usuario y las fechas de préstamo y devolución.
- `Libro`: Información del libro.
- `Categoria`: Categoria a la que pertenece el libro.

![Imagen (1).png](Untitled%20f21944cc385643169095429fecbc6dae/Imagen_(1).png)

## Ventanas

1. `Login`: El usuario introduce su correo y contraseña y si está registrado se valora si es administrador o no para llevarle a una ventana principal de usuario o de administrado.
2. `Registro usuario`: Si el usuario no esta registrado aparece una opción para registrarse, y si acepta aparece la ventana.
3. `Principal administrador`: El usuario puede acceder a las listas de los diferentes campos, libros, usuarios o prestamos.
4. `Listas`: Cada clase que lo precisa dispone de su propia pantalla lista donde poder, modificar, borrar y actualizar los datos pertinentes de cada clase (`Data grid view`).
5. `Formularios`: Cada clase dispone de su formulario de creación.
6. `Auxiliares`: ventanas extra que ofrecen información necesaria al usuario.

[https://www.figma.com/file/YDeozWJrW4mD2U1EwLX8qq/Untitled?type=design&node-id=0%3A1&mode=design&t=ZxdW1vlDOnSUMjca-1](https://www.figma.com/file/YDeozWJrW4mD2U1EwLX8qq/Untitled?type=design&node-id=0%3A1&mode=design&t=ZxdW1vlDOnSUMjca-1)

## Error sin resolver:

<aside>
⚠️ **Registro usuario:**

Cuando se registra un usuario nuevo, este aparece en el data gridview pero al tratar de borrarlo devuelve null, he intentado buscarlo por la lista y por la bbdd y en ambos casos sigue permaneciendo el mismo error. He introducido un mensaje de aviso para que no se pare la ejecución. AL cerrarlo y volver a abrir ya te permite eliminarlo.

</aside>

![error1.PNG](Untitled%20f21944cc385643169095429fecbc6dae/error1.png)

<aside>
⚠️ **Dificultades y otros errores resueltos:**

- `DELETE ON CASCADE`: Para que al borrar un usuario o libro no saltase un error al estar como claves foráneas en los prestamos.
- Modificar los libros disponibles cuándo se crean, borran o cambian de estado los prestamos.
- Búsquedas: crear `querys` para buscar datos en la base de datos que contemplen cualquier valor que se asemeje, pudiendo buscar por cualquier criterio.
</aside>