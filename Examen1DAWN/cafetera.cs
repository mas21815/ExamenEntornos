
using System;


//namespace EDexamenT6a8

/// <summary>
/// Cambios y correccion de errores
/// * codigo bien identado
/// * he cambiado el nombre de la clase cafetera a Cafetera
/// 1. El constructor de cafetera tenia la llave de cierre mal situada, la he puesto en su sitio
/// 2. He situado los campos de la clase cafetera en la parte superior
/// 3. he cambiado el nombre a los campos de la clase cafetera para que sean mas legibles 
/// 4. he cambiado el nombre de los paramatros de entrada del constructor de cafetera para que se adecuen a el cambio anterior
/// 5. he pasado los campos de cafetera a privado y he creado sus propiedades asociadas
/// 6. he cambiado el nombre de el metodo consumoagua a ConsumoAgua y su parametro de entrada numerodecafe a numeroDeCafe
/// 7. he posicionado bien el codigo dentro de el metodo ConsumoAgua
/// 8. he tabulado bien el contenido de el else en el metodo ConsumoAgua
/// 9. he Cambiado el nombre de consumocapsulas a ConsumoCapsulas
/// 10. he cambiado en nombre al metodo reponercapsulas a ReponerCapsulas
/// 11. he cambiado el nombre al metodo llenardep a LlenarDeposito
/// 12. he cambiado un = a un += para optimizar el codigo
/// 13. he cambiado un = a un -= para optimizar el codigo
/// 14. el metodo verespecificacion no tiene un funcinamiento adecuado, hay que eliminarlo o modificarlo
/// 15. he eliminado la clase ejemplodemicafetera de el codigo de la clase Cafetera
/// 16. he creado la clase EjemploDeMiCafetera por separado 
/// 
/// </summary>

class Cafetera
{
    // 2, 3, 5
    private string marcaCafetera;
    private string referenciaModelo;
    private double cantidadAgua;
    private double totaldecapsulas;
    // 5
    public global::System.String MarcaCafetera { get => marcaCafetera; set => marcaCafetera = value; }
    public global::System.String ReferenciaModelo { get => referenciaModelo; set => referenciaModelo = value; }
    public global::System.Double CantidadAgua { get => cantidadAgua; set => cantidadAgua = value; }
    public global::System.Double Totaldecapsulas { get => totaldecapsulas; set => totaldecapsulas = value; }

    public Cafetera(string marcaCafetera, string referenciaModelo, double cantidadAgua, double totaldecapsulas) // 4
    {
        this.MarcaCafetera = marcaCafetera; //marca de la máquina cafetera
        this.ReferenciaModelo = referenciaModelo; //referencia del modelo
        this.Totaldecapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
        this.CantidadAgua = cantidadAgua; //Cantidad de agua en el recipiente. 
    } // 1

    public string ConsumoAgua(double numeroDeCafe) // 6  //numero de cafés a hacer
    {
        double constante = 0.1;
        this.CantidadAgua -= numeroDeCafe * constante; //13  
        if (this.CantidadAgua < 0.1)
        {   
            this.CantidadAgua = 0; // 7
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else
        { 
            return "Quedan" + this.CantidadAgua + " centilitros"; // 8
        }
    }

    public string ConsumoCapsulas(double numerodecafe)//9 //Hacer un café 
    {
        this.Totaldecapsulas -= numerodecafe; //13
        if (this.Totaldecapsulas < 0)
        {
            this.Totaldecapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else {
            return "Quedan" + this.Totaldecapsulas + "unidades";
        }
    }

    public double ReponerCapsulas(double cantidadcapsulas) // 10
    {
        this.Totaldecapsulas += cantidadcapsulas; // 12
        return this.Totaldecapsulas;
    }
    public double LlenarDeposito(double litros)// 11
    {
        this.CantidadAgua += litros; // 12
        return this.CantidadAgua;
    }


    public void verespecificacion(string r, string m) // 14
    {
        this.MarcaCafetera = m;
        this.ReferenciaModelo = r;
    }

}
// 15