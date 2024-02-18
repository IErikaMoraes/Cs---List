namespace listascsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaramos um lista para ser usada
            //(LISTAS TBM SÃO CLASSES)
            List<int> numeros = new List<int>();

            //adcionamos elementos a lista por ordem de chegada
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            //Inserir um elemenento numa posição específica
            numeros.Insert(1, 15);

            //Verificar se um elemento está presente na lista
            bool contem15 = numeros.Contains(15);

            //Encontrar a posição de um elemento na lista
            int posicao20 = numeros.IndexOf(20);

            //Ordenar a lista em ordem crescente
            numeros.Sort();

            //Remover um elemento de uma posição especíica
            numeros.RemoveAt(2);

            //Remover o primeiro elemento que apareça que tenha certo valor
            numeros.Remove(10);

            //Obter o tamanho da lista
            int tamanho = numeros.Count;

            //Iterar e imprimir lista
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }


            //Iterar e IMPRIMIR lista
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //-----------------------------------------

            //Em C# não pode criar um array vazio diretamente, mas você pode criar um array com tamanho
            //ajustável ou flexível usando uma lista e, em seguida, convertendo-a para um array. 

            //Essa abordagem permite criar um "array flexível" que pode ser dinamicamente modificado
            //usando métodos da lista antes de ser convertido em um array.

            // Criação de uma lista vazia de inteiros
            List<int> lista = new List<int>();

            // Adiciona elementos à lista
            lista.Add(5);
            lista.Add(10);
            lista.Add(20);

            // Converte a lista para um array
            int[] array = lista.ToArray();

            // Exibe o array
            Console.WriteLine("Array criado a partir da lista:");
            ExibirArray(array);

        }


        //Função:
        static void ExibirArray(int[] array)
        {
            foreach (var elemento in array)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

    }
}