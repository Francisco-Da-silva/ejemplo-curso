using System;

namespace TPFinal_sarfernandez
{
    class Program
    {
        static void Main(string[] args)
        {

        //Trabajo Práctico
        //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

        //a. El mayor de los números pares.
        //b. La cantidad de números impares.
        //c. El menor de los números primos.

        //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

         int  n, maxpares=0 , conpar = 0 ,conimpar=0, menorprimo=0; 
         Console.WriteLine("ingrese la lista de numeros , al finalizar ingrese 0(cero )");
         n = int.Parse(Console.ReadLine());
         while(n != 0)
         {
             n = int.Parse(Console.ReadLine());  
             if(n % 2 == 0){
                     conpar ++;
                           

                     if(conpar== 0 )
                      maxpares = n ;
                      else if ( maxpares< n)
                       n = maxpares ;
                  
                            
                            
             }else {
                  conimpar++ ;

                   }

            if (primo(n)){
                menorprimo = n ;
                if (n < menorprimo)
                menorprimo = n ; 


            }


         }
            Console.WriteLine("El mayor de los numero pares es "+ maxpares );
            Console.WriteLine("La cantidad de numeros impares es  "+ conimpar );
            Console.WriteLine("El menor de los numeros primos es "+  menorprimo);
            


            


        }
          
         static bool primo(int n ){
        
         int con =0;
               for(int y = 1; y <= n; y++)
               {
                    if(n % y == 0 )
                     con++;
               }     
             
           if ( con == 2)
                 return true ; 
               else 
                 return false ; 
        



    }
    }
}

