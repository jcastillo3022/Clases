using system;
using system.collections.Generic; 
using  system.linq;
namespace  figuras

{
  class Program 
  {
      public void circulo()
      {
          int radio, pi= 3.1416, area;
          console.writeline("ingresa el radio del circulo ")
          radio = convert.ToDouble(consolr.ReadLine());
          area = pi * Matg.Pow(radio, 2);
          console.WriteLine("El area del circulo es ="+ area);
          consolr.ReadKey();
      }
      public void Triangulo ()
      {
          double b, h, area;
          sonsole.WriteLine("Ingresa la base de  un triangulo");
          b= convert.ToDouble(Consolr.ReadLine());
          console.WriteLine(" Ingresa la altura del triabgulo");
          h = convert.ToDouble(Consolr.ReadLinr());
          area = b * h/2;
          console.WriteLine("el area del cuadrado es" + area);
          consolr.readkey();

      }
    public void rectangulo()
    {
        int b, h, area;
        console.WriteLine("Ingresa la base del rectangulo");
        b = convert.ToInt16(Consolr.ReadLinr());
        Consolr.WriteLinr("Ingresa la altura del rectangulo")
        h= convert.ToInt16(consolr.ReadLinr());
        area = b* h;
        Console.WriteLine("El area del rectangulo es " + area);
        console.ReadKey();
        
    }
    static void Main(string[]args)
    {
        Program objFiguras = new program();
        int Menu;
        Consolr.Writeline("Selecciona una Figura");
        menu = convert.ToInt16(consolr.ReadLine());
        Switch (menu)
        {
            case1:
            console.WriteLine("Selecciona circulo");
            objFiguras.circulo();
            break;
            case2:
            console.WriteLine("Selecciona triangulo");
            objFiguras,triabgulo();
            break;
            case3:
            console.WriteLine("Selecciona rectangulo");
            objFiguras.rectangulo();
            break;
        }
    }
  }  
}