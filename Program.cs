// TDE 03

          // 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

                    // Encontre o maior dentre 3 números:
                    // Primeiro Número : 65465
                    // Segundo Número : 64658
                    // Terceiro Número : 65464
                    // O primeiro número : 65465 é o maior


                    // Código ↓↓↓

                    // Console.WriteLine("Digite um número");
                    // int num1 = Convert.ToInt32(Console.ReadLine());
                    // Console.WriteLine("Digite um outro número");
                    // int num2 = Convert.ToInt32(Console.ReadLine());
                    // Console.WriteLine("Digite um ultimo número");
                    // int num3 = Convert.ToInt32(Console.ReadLine());

                    // Console.WriteLine($"\nPrimeiro número: {num1} \nSegundo número: {num2} \nTerceiro numero: {num3} \n");

                    // if(num1 > num2 && num1 > num3)
                    // {
                    // Console.WriteLine($"Primeiro numero: {num1} é o maior");
                    // }
                    // else if(num2 > num1 && num2 > num3)
                    // {
                    //           Console.WriteLine($"Segundo numero: {num2} é o maior");
                    // }
                    // else if(num3 > num1 && num3 > num1)
                    // {
                    //           Console.WriteLine($"Terceiro numero: {num3} é o maior");
                    // }
                    // else{
                    //           Console.WriteLine($"Os três números são iguais");
                    // }

 // -------------------------------------------------------------------------------------------------------------------------------------------------------------------

          // 2- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 

                    // while, do-while e for.
                    // Os 10 primeiros números naturais são :
                    // 1 2 3 4 5 6 7 8 9 10
                    // A soma dos números é : 55

                    // Código ↓↓↓

                    // int count = 1;
                    // int soma = 0;

                    //while
                              // while(count <= 10)
                              // {
                              //           soma += count;
                              //           count++;
                              // }

                    // do while
                              // do
                              // {
                              //           soma += count;
                              //           count++;
                              // }
                              // while(count <= 10);

                    // for

                              // for(int i=0; i<=10;i++)
                              // {
                              //           soma +=i;
                              // }
                    

                    // Console.WriteLine($"A soma dos numeros naturais é: {soma}");

// -------------------------------------------------------------------------------------------------------------------------------------------------------------------

          // 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado 

                    // - Verifique se o número é maior que zero e emita uma mensagem
                    // - Considere a tabela de multiplicação de 1 até 10
                    // - Após exibir a tabela torne a solicitar outro número 
                    // - Para sair do loop defina uma condição de saída 
                    // Dica: Use os loop while e for e para sair a instrução break;

                    // while(true)
                    // {
                    //           Console.WriteLine("Digite um numero natural para montarmos uma tabuada:");
                    //           int numero = Convert.ToInt32(Console.ReadLine());

                    //           for(int i=1;i<=10;i++)
                    //           {
                    //                     Console.WriteLine($"{numero} x {i} = {numero*i}");
                    //           }

                    //           Console.WriteLine($"\nTabela do numero {numero} completa.");

                    //           Console.WriteLine("\nDeseja countinuar?(S/N)");
                    //           string? resp = Console.ReadLine().ToLower();

                    //           if(resp == "s")
                    //           {
                    //                     countinue;
                    //           }
                    //           else if(resp == "n")
                    //           {
                    //                     break;
                    //           }
                    //           else
                    //           {
                    //                     Console.WriteLine("Não entendi sua resposta, vamos countinuar");
                    //                     countinue;
                    //           }

                    // }


// -------------------------------------------------------------------------------------------------------------------------------------------------------------------

          // 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:

                    // - Incrementando 2 em cada passo
                    // - Incrementando 1 em cada passo 
                    // - Com e loop infinito (use "break" e "countinue")


                    // int count = 10;


                    // // do while

                    //           do
                    //           {
                    //                     if(count % 2 == 0)
                    //                     {
                    //                               if(count == 16)
                    //                               {
                    //                                         count++;
                    //                                         continue;
                    //                               }
                    //                               else
                    //                               {
                    //                                         Console.WriteLine($"countanto {count}");
                    //                               }
                    //                     }
                    //                     count++;                 
                    //           }
                    //           while(count <= 20);


                    // // for

                    //           for(int i =10;i<=20;i+=2)
                    //           {
                    //                     if(i==16)
                    //                     {
                    //                               continue;
                    //                     }
                    //                     Console.WriteLine($"countando {i}");
                    //           }

                    //           Console.WriteLine("Fim do looping");

                    // // while

                    //           while(true)
                    //           {
                    //                     if(count % 2 == 0)
                    //                     {
                    //                               if(count == 16)
                    //                               {
                    //                                         count++;
                    //                                         continue;
                    //                               }
                    //                               else
                    //                               {
                    //                                         Console.WriteLine($"countanto {count}");
                    //                               }
                    //                     }
                    //                     count++;
                    //                     if(count == 20)
                    //                     {
                    //                               break;
                    //                     } 
                    //           }


// -------------------------------------------------------------------------------------------------------------------------------------------------------------------

          // 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
          // O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
          // Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

          // Console.WriteLine("Digite um numero inteiro: ");
          // int num = Convert.ToInt32(Console.ReadLine());
          // int fatorial = num;

          // for(int i = num; i>1;i--)
          // {
          //           fatorial  *= (i-1);
          // }          
 
          // Console.WriteLine($"O fatorial de {num} é: {fatorial}");

// -------------------------------------------------------------------------------------------------------------------------------------------------------------------

          // 6 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

          // Modelo de saída
          // 2 x 1 = 2
          // 2 x 2 = 4
          // 2 x 3 = 6
          // 2 x 4 = 8
          // 2 x 5 = 10
          // 2 x 6 = 12
          // 2 x 7 = 14
          // 2 x 8 = 16
          // 2 x 9 = 18
          // 2 x 10 = 20
          // 3 x 1 = 3
          // 3 x 2 = 6
          // 3 x 3 = 9
          // 3 x 4 = 12
          // 3 x 5 = 15
          // 3 x 6 = 18
          // 3 x 7 = 21
          // 3 x 8 = 24
          // 3 x 9 = 27
          // 3 x 10 = 30

          // for(int i =2;i<=6;i++)
          // {
          //           for(int c = 1;c<=10;c++)
          //           {
          //                     Console.WriteLine($"{i} x {c} = {i*c}");
          //           }
          //           Console.WriteLine("\n");
          // }

// -------------------------------------------------------------------------------------------------------------------------------------------------------------------

          //7 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
          // um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
          // instrução switch, break e default em um loop infinito e defina uma condição de saida.)

          // while(true)
          // {
          //           Console.WriteLine("Digite a nota de um aluno");
          //           int num = Convert.ToInt32(Console.ReadLine());

          //           switch(num)
          //           {
          //                     case 10:
          //                               Console.WriteLine("O aluno tirou A++");
          //                     break;
          //                     case 9:
          //                               Console.WriteLine("O aluno tirou A");
          //                     break;
          //                     case 8:
          //                     case 7:
          //                               Console.WriteLine("O aluno tirou B");
          //                     break;
          //                     case 6:
          //                               Console.WriteLine("O aluno tirou C");
          //                     break;
          //                     case 5:
          //                               Console.WriteLine("O aluno tirou E");
          //                     break;
          //                    default:
          //                               Console.WriteLine("O aluno tirou F");
          //                     break;
          //           }

          //           Console.WriteLine("Gostaria de verificar a nota de outro aluno?(S/N)");
          //           string resp =Console.ReadLine().ToLower();

          //           if(resp == "s")
          //           {
          //                     continue;
          //           }
          //           else if(resp == "n")
          //           {
          //                     break;
          //           }
          //           else
          //           {
          //                     Console.WriteLine("Desculpe, não entendi que digitou, vamos novamente");
          //           }
          // }



// -------------------------------------------------------------------------------------------------------------------------------------------------------------------


          // 8 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
          // inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
          // quando isso ocorrer exibir uma mensagem de alerta

          int num1, num2;

          Console.WriteLine("Digite um numero");
          num1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Digite a operação a ser feita ( + , - , * , / )");
          char oper = Convert.ToChar(Console.ReadLine());

          Console.WriteLine("Digite o segundo numero");
          num2 = Convert.ToInt32(Console.ReadLine());

          switch(oper)
          {
                    case '+':
                              Console.WriteLine($"A soma de {num1} + {num2} é = {num1 + num2}");
                    break;
                    case '-':
                              Console.WriteLine($"A subtração de {num1} - {num2} é = {num1 - num2}");
                    break;
                    case '*':
                              double mult = num1 * num2;
                              Console.WriteLine($"A multiplicação de {num1} * {num2} é = {mult}");
                    break;
                    case '/':
                              if(num2 == 0)
                              {
                                        Console.WriteLine("Não existe divisão por zero");
                              }
                              else{
                                        double div = num1 /num2;
                                        Console.WriteLine($"A divisão de {num1} / {num2} é = {div}");         
                              }
                    break;
          }