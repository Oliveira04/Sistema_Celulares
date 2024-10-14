﻿namespace Sistema_Celulares;

public abstract class Smartphone
 {
     public string Numero { get; set; }
     

     public Smartphone(string numero)
     {
         Numero = numero;
        
     }

     public void Ligar()
     {
         Console.WriteLine("Ligando...");
     }

     public void ReceberLigacao()
     {
         Console.WriteLine("Recebendo ligação...");
     }

     public abstract void InstalarAplicativo(string nomeApp);
     public abstract void Receber_Ligacao();
 }

 
