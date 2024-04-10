            int opcao;

            do
            {
                do
                {

                    Console.WriteLine("=========Qual Exercicio Voce Deseja Ver?=========");
                    Console.WriteLine("0 - SAIR");
                    Console.WriteLine("1 - EX1");
                    Console.WriteLine("2 - EX2");
                    Console.WriteLine("3 - EX3");
                    Console.WriteLine("4 - EX4");
                    Console.WriteLine("5 - EX5");
                    Console.WriteLine("6 - EX6");
        opcao = int.Parse(Console.ReadLine());

                } while (opcao < 0 || opcao > 7);

                switch (opcao)
                 {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema!");
                        break;

                    case 1:

                    Console.WriteLine("Executando o ex1");
                    int n;
                    int contador = 1;

                    Console.WriteLine("Até q número deseja contar?");
                    n = int.Parse(Console.ReadLine());
                    do
                    {

                        Console.WriteLine("{0}", contador);
                        contador++;
                    } while (contador <= n);
                    break;

                case 2:
                    Console.WriteLine("Executando o ex2");
                    int i, numero;

                    Console.WriteLine("digite um numero");
                    numero = int.Parse(Console.ReadLine());
                    i = 1;
                    do
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                        i++;
                    } while (i <= numero);
                    break;
                case 3:
                    Console.WriteLine("Executando o ex3");
                    int p, numer;

                    Console.WriteLine("digite um numero menor que 1000");
                    numer = int.Parse(Console.ReadLine());
                    p = 1;
                    do
                    {

                        if (p == 1000 || p % 2 == 0)
                        {
                            Console.WriteLine(p);
                        }
                        p++;

                    } while (p <= numer);

                    break;
                case 4:
                    Console.WriteLine("\nExecutando o EX5\n");
                    int Num2, contar = 1;
                    do
                    {
                 Console.WriteLine("Digite um número descobrir seus divisores exatos:");
                    Num2 = int.Parse(Console.ReadLine());
                    } while (Num2 <= 0);
                    do
                    {
                         contar++;
                        if (Num2 % contar == 0)
                        {
                        Console.WriteLine("Os divisores do número escolhido são:{0}", contar);
                        }
                    }
                      while (contar <= Num2);
                    break;
                case 5:
                    int cont = 1;
                    int maior, menor;

                    Console.Write($"Digite o {cont}º número: ");
                    int r = int.Parse(Console.ReadLine());

                    maior = r;
                    menor = r;

                    cont++;

            do
                
            {
                Console.Write($"Digite o {cont}º número: ");
                r = int.Parse(Console.ReadLine());

                     if (r > maior)
                     {
                    maior = r;
                     }

                     if (r < menor)
                     {
                    menor = r;
                     }

                     cont++;
            }while (cont <= 10) ;

                    Console.WriteLine($"O maior número digitado foi: {maior}");
                    Console.WriteLine($"O menor número digitado foi: {menor}");
                     break;
                case 6:
                    int somaPares = 0;
                    int somaImpares = 0;

                    Console.WriteLine("Digite uma sequência de números inteiros (digite 0 para parar):");

                    int o;
            do
            {
                    o = int.Parse(Console.ReadLine());

                    if (o != 0)
                    {
                    if (o % 2 == 0)
                    {
                        somaPares += o;
                    }
                    else
                    {
                        somaImpares += o;
                    }
                    }

            } while (o != 0);

                    Console.WriteLine($"A soma dos números pares é: {somaPares}");
                    Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");
                    break;


    }
            } while (opcao != 0);
                
            
        
            


                        

       
