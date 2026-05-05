// crear una calculadora post fija
//debe pedirse al usuario que ingrese un numero o un signo de operacion: +, -, *, /
//si es un numero se agrega a la pila
//si es una operacion, se quitan los 2 ultimo numneros de la pila,
//se les opera y el resultado se devuelve a la pila. Ese resultado se mostrara en pantalla

using PilaArreglo;

PilaAr pila = new PilaAr();
string entrada;

Console.WriteLine("CALCULADORA POSTFIJA");
Console.WriteLine("Ingrese números u operadores (+ - * /)");

double res = 0;
while (true) {
    Console.Write("Entrada: ");
    entrada = Console.ReadLine();

    if (entrada.Trim() == "+") {
        double b = pila.Pop();
        double a = pila.Pop();
        res = a + b;
        pila.Push(res);
        Console.WriteLine($"= {res}");
    } else if (entrada.Trim() == "-") {
        double b = pila.Pop();
        double a = pila.Pop();
        res = a - b;
        pila.Push(res);
        Console.WriteLine($"= {res}");
    } else if (entrada.Trim() == "/") {
        double b = pila.Pop();
        double a = pila.Pop();
        res = a / b;
        pila.Push(res);
        Console.WriteLine($"= {res}");
    } else if (entrada.Trim() == "*") {
        double b = pila.Pop();
        double a = pila.Pop();
        res = a * b;
        pila.Push(res);
        Console.WriteLine($"= {res}");

        pila.Push(res);
        Console.WriteLine($"Resultado: {res}");
    } else if (double.TryParse(entrada, out double numero)) {
            pila.Push(numero);
    } else {
        Console.WriteLine("Entrada no válida");
    }
}