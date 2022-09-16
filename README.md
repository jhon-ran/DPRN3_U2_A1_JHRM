# DPRN3_U2_A1_JHRM
Prrograma para dar de alta autos en inventario mediante una interfaz gráfica y conexión a BD.


## Interfaz gráfica
Consta de una sola ventana con campos y 2 botones

<p align="center">
  <img src="https://user-images.githubusercontent.com/38293508/190549188-9cdbba5c-1920-42b0-9c29-72e328777d4b.png"/>
</p>




El botón conectar permite hacer una prueba de conexión con la base de datos locales antes de intentar cualquier registro

## Base de datos
La conexión con la base de datos local está configurada con SQL Server. Si requiere otro manejador, se debe reconfigurar de acuerdo a dicho manejador. 
Para que los registros se carguen exitosamente, hay que crear la tabla de acuerdo al siguiente esquema:

<p align="center">
  <img src="https://user-images.githubusercontent.com/38293508/190549287-32c70750-7b43-4a4a-a6d3-ba7477d1fab1.png"/>
</p>

## Versiones y dependencias
* System.Data.SqlClient
* Visual Studio Community 2019 16.11.19
