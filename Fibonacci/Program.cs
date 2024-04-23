int pos, penultimo = -1, atual, ultimo = 1;
    
Console.WriteLine("Informe a posição limite: ");
pos= int.Parse(Console.ReadLine());


    for (int i = 0; i < pos; i++)
    {
        atual = penultimo + ultimo;
        Console.WriteLine(atual);
        penultimo = ultimo;
        ultimo = atual;
    }
