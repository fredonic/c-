using System.Net.Http.Headers;

class tarea1
{ // se inicia siempre la clase
    public void ejercicio1()
    { // retornaremos un valor vacío

        Console.WriteLine("escibe tu nombre"); // se pide por pantalla un nombre 
        string nombre = Console.ReadLine();// se guarda lo que se pidio por pantalla en una variable string 
        Console.WriteLine("HOLA " + nombre);// mostramos en pantalla el valor y se concatena con un +
        Console.ReadKey(); // no deja que cierre el programa   
    }
    public void ejercicio2()
    {
        Console.WriteLine("Ingresa la base de un rectangulo: ");

        double baseR = Convert.ToInt32(Console.ReadLine());//base es una palabra reservada de c#  y se hace casteo Console.ReadLine()
        Console.WriteLine("Ingresa la altura de un rectangulo: ");
        double altura = Convert.ToInt32(Console.ReadLine());

        double perimetro = 2 * (baseR + altura);
        double area = baseR * altura;
        Console.WriteLine("El perimetro es: " + perimetro + " El area es: " + area);
        Console.ReadKey();

    }


    public void ejercicio3()
    {
        Console.WriteLine("Ingresa el cateto, A:");
        double catetoA = Convert.ToInt32(Console.ReadLine());
        catetoA = Math.Pow(catetoA, 2);
        Console.WriteLine("Ingresa el valor del cateto, B: ");
        double catetoB = Convert.ToInt32(Console.ReadLine());
        catetoB = Math.Pow(catetoB, 2);
        double hipotenusa = Math.Sqrt(catetoA + catetoB);
        Console.WriteLine("La hipotenusa de los catetos es: " + hipotenusa);
        Console.ReadKey();


    }// se pueden crear plantillas del void y no causan error 
    public void ejercicio4()

    {
        Console.WriteLine("Ingresa  el primer valor:");
        double valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo Valor");
        double valor2 = Convert.ToInt32(Console.ReadLine());
        double suma = valor1 + valor2;
        double resta = valor1 - valor2;
        double division = valor1 / valor2;
        double multiplicacion = valor2 * valor2;
        Console.WriteLine("La suma de los valores es: " + suma);
        Console.WriteLine("La resta de los valores es: " + resta);
        Console.WriteLine("La division de los valores es: " + division);
        Console.WriteLine("La multiplicacion de los valores es: " + multiplicacion);
        Console.ReadKey();

    }

    public void ejercicio5()

    {
      Console.WriteLine("Ingresa el valor en Fahrenheit");
    double farenheit = Convert.ToInt32(Console.ReadLine());
    double celcius = (farenheit - 32) * 5 / 9;
    Console.WriteLine("El valor en °C celcius es: " +celcius);
    Console.ReadKey();


    }

    public void ejercicio6()

    {

        Console.WriteLine("Ingresa el primer valor entero : ");
        int v1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo valor entero :");
        int v2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el tercer valor entero :");
        int v3 = Convert.ToInt32(Console.ReadLine());
        int media = (v1 + v2 + v3) / 3;
        Console.WriteLine("La media es :" + media);

        Console.ReadKey();
    }
    public void ejercicio7()

    {
        Console.WriteLine("Ingresa los minutos que desees : ");
        int minutos= Convert.ToInt32(Console.ReadLine());
        int horas= minutos/ 60;
        int minutosrestantes = minutos % 60;
        Console.WriteLine("son :"+horas+" Horas "+ 
            
            "   y  "+ minutosrestantes+" minutos ");
        



        

    }
    public void ejercicio8()

    {
        Console.WriteLine("Ingresa la catidad de tu sueldo : ");
        double sueldo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa tu 1ra venta : ");
        double venta1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa tu 2da venta : ");
        double venta2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa tu 3ra venta : ");
        double venta3= Convert.ToInt32(Console.ReadLine());
        double porciento = (venta1 + venta2 + venta3) * .10;
        double total = sueldo + porciento;
        Console.WriteLine("sueldo mensual : " + sueldo);
        Console.WriteLine("El total de tus ganancias en ventas es : "+porciento);
        Console.WriteLine("Tu sueldo mensual total es : ********"+"$"+total+" pesos"+"*********");
        Console.ReadKey();
    }
    public void ejercicio9()

    {

        Console.WriteLine("Ingresa la cantidad total que gastaste :");
        double gastos =Convert.ToInt32(Console.ReadLine());
        double descuento = (gastos )*.15;
        double pagar = gastos - descuento;
        Console.WriteLine("******Su descuesnto del 15% es : $" + descuento+" pesos");

        Console.WriteLine("******Tu total a pagar con descuento es : $" +pagar+" pesos");
        Console.ReadKey();

    }


    public void ejercicio10()

    {
        Console.WriteLine("Ingresa tu primera calificacion del parcial : ");
        float cali1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa tu segunda calificacion del parcial : ");
        float cali2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa tu tercera calificacion del parcial : ");
        float cali3 = Convert.ToInt32(Console.ReadLine());
        float promedio1 = (cali1 + cali2 + cali3)/3;
        float parcial1 = (float)((promedio1)*.55);
        Console.WriteLine("Ingresa tu calificacion de examen final : ");
        float examen1 = Convert.ToInt32(Console.ReadLine());
        float promedio2 =(float)( (examen1)*.30);
        Console.WriteLine("Ingresa tu  calificacion del proyecto final : ");
        float proyecto= Convert.ToInt32(Console.ReadLine());
        float promedio3 = (float)((proyecto) * .15);
        //float promedioFinal = (parcial1 + promedio2 + promedio3)*10;
         float promedioFinal = parcial1 + promedio2 + promedio3;
        Console.WriteLine(
            "De tu promedio parcial obtuviste :"+parcial1+"%    "+
            "En tu examen final  obtuviste :   "+promedio2+"%     "+
            "En tu proyecto final obtuviste :  "+promedio3+"%    "+
            "                                                    "+
            "**************"+
            "Tu promedio final es:"+promedioFinal+"%"+
            "**************");




        Console.WriteLine();



    }

    static void Main(String[] args)
    {// dentro del main se realiza lo que se va iniciar para ejecutar el programa
        tarea1 obj = new tarea1(); // intancia de clase 
                                  //obj.ejercicio1(); // se pueden agregar mas metodos de inicio solo algunos 
                                   //obj.ejercicio2();
                                   //obj.ejercicio3();
                                   //obj.ejercicio4();
                                   //obj.ejercicio5();
                                   //obj.ejercicio6();
                                   //obj.ejercicio7();
                                   //obj.ejercicio8();
                                   //obj.ejercicio9();
                                   obj.ejercicio10();
    }
}
