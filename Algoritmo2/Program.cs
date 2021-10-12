using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {

            ControleAcesso controleAcesso = new ControleAcesso();

            bool logado = controleAcesso.EfetuarLogin();

            if (logado)
                Console.WriteLine("LOGIN EFETUADO COM SUCESSO!");
            
            
            
            
            
            
            
            
            
            
            
            
            //Controle de acesso: usuário irá digitar um login e uma senha:::
            //Terá 3 tentativas para acessar a senha

            //string login = "Aldo";
            //string senha = "123";

            //Console.WriteLine("Digite o login: ");
            //string loginDigitado = Console.ReadLine();

            //if (loginDigitado == login)
            //{
            //    int count = 0;

            //    while (count < 3)
            //    {
            //        Console.WriteLine("Digite a senha: ");
            //        string senhaDigitada = Console.ReadLine();

            //        if (senhaDigitada == senha)
            //        {
            //            Console.WriteLine("LOGIN EFETUADO COM SUCESSO!");
            //            break;
            //        }
            //        count++;
            //    }
            //}

            ////Números primos
            //Console.WriteLine("Digite um limite: ");
            //int limite = Convert.ToInt32(Console.ReadLine());
            //int[] indices = new int[4];
            //indices[0] = 2;
            //indices[1] = 3;
            //indices[2] = 5;
            //indices[3] = 7;

            //for (int l = 1; l <= limite; l++) //Varendo todos os números até o limite
            //{
            //    bool primo = true;

            //    for (int i = 0; i < 4; i++) //Varrer todos os números até o limite informado pelo usuário
            //    {
            //        int resto = l % indices[i];

            //        if (l != indices[i] && resto == 0)
            //        {
            //            primo = false;
            //            break;
            //        }
            //    }

            //    if (primo)
            //        Console.WriteLine(l);
            //}


            ////Calculo de IMC
            //Console.WriteLine("Digite seu peso (Kg):");
            //int peso = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite altura (Kg):");
            //double altura = Convert.ToDouble(Console.ReadLine());

            //double imc = peso / (altura * altura);
            //string resultado = "";

            //if (imc < 17)
            //    resultado = "Muito abaixo do peso";

            //if (imc >= 17 && imc <= 18.49)
            //    resultado = "Abaixo do peso";

            //if (imc >= 18.50 && imc <= 24.99)
            //    resultado = "Peso normal";

            //if (imc >= 25 && imc <= 29.99)
            //    resultado = "Acima do peso";

            //if (imc >= 30 && imc <= 34.99)
            //    resultado = "Obesidade I";

            //if (imc >= 35 && imc <= 39.99)
            //    resultado = "Obesidade II (Severa)";

            //if (imc >= 40)
            //    resultado = "Obesidade III (Mórbida)";

            //Console.WriteLine(resultado);
        }
    }
}
