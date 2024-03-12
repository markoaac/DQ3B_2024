//Paso 1. Declarar la librería de hilos (Threads)
using System.Threading;

//Paso 2. Seleccionar el método que utilizaremos
//para el hilo
// Se selecciona el método ImprimirY();

//Paso 3. Definir el hilo
//Paso 3.1 el constructor del hilo recibe una función
Thread hilo = new Thread(ImprimirY);
//Nota: la función como parámetro NO LLEVA PARÉNTESIS

hilo.Start();
ImprimirX();
//Paso 4. Iniciar el hilo
//ImprimirY();// <-



void ImprimirX()
{
    for(int i = 0; i < 100; i++)
    {
        Console.Write("X");
    }
}

void ImprimirY()
{
    for (int i = 0; i < 100; i++)
    {
        Console.Write("Y");
    }
}
