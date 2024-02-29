using System;

public class Menu
{
    public void Exibir()
    {
        string operacao = "";

        while (operacao!="1" && operacao!="2" &&operacao!="3" &&operacao!="4" &&operacao!="5" &&operacao!="6"){
            Console.Clear();
            Console.WriteLine("1- soma");
            Console.WriteLine("2- subtracao");
            Console.WriteLine("3- multiplicacao");
            Console.WriteLine("4- divisao");
            Console.WriteLine("5- potencia");
            Console.WriteLine("6- sair");
            Console.WriteLine("Digite o número da operação desejada: ");

            operacao = Console.ReadLine();
        }
        Console.Clear();
        if(operacao != "6"){
            Console.WriteLine("Digite o Primeiro Valor");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o Segundo Valor");
            int b = Convert.ToInt32(Console.ReadLine());

            ControladorCalculadora calc= new ControladorCalculadora();
            int resultado=calc.calcular(operacao,a,b);

            Console.Clear();
            Console.WriteLine("Resultado: " + resultado);
        }
        
    }
}

