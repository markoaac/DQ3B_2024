using Unidad_II_Clases;
//Lectura l = new Lectura("C:/Pruebas/dq3b.txt");
//string[] lineas = l.Leer();
//for (int i = 0; i < lineas.Length - 1; i++)
//{
//    Console.WriteLine(lineas[i]);
//}
//l.Cerrar();
Escritura esc = 
    new Escritura("C:/Pruebas/dq3b.txt", true);
esc.Escribir("Hoy es lunes 12 de febrero 2024");
esc.Cerrar();