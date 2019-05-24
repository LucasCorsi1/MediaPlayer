using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMediaPlayer
{


    class ListaEncadeada<T>
    {
        public Node<T> head { get; private set; }
        public Node<T> end { get; private set; }
        public int qtde { get; private set; }
        public ListaEncadeada()
        {
            this.end = null;
            this.head = null;
            this.qtde = 0;
        }

        /* Retorna se a lista está vazia ou não*/
      
        /* Retorna a quantidade de elementos da lista */
        public int count
        {
            get { return this.qtde; }
        }
        /* Remove o primeiro elemento da lista.*/
       
        /* Remove o último elemento da lista. */
       
        /* Deleta um elemento da lista recebendo como parametro o próprio elemento */
        public void DeleteNode(object data)
        {
            if (head.Proximo == data)
            {
                head = head.Proximo;
            }
            else
            {
                Node <T>removed = Find(data);
                if (removed.Proximo != null)
                    removed.Proximo = removed.Proximo.Proximo;
            }
        }

        /* Procurra o item da lista de acordo com o parametro recebido */
        private Node<T> Find(object data)
        {
            Node<T> n = head;
            while (n.Proximo != null)
            {
                if (n.Proximo != data)
                {
                    n = n.Proximo;
                }
                else
                    return n;
            }
            return n;
        }

     

        public void InsertLast(T temp)
        {

            //Cria o nó com os valores que serão recebidos
            Node<T> newNode = new Node<T>(temp);
            //Novo nó recebe o valor 
            //Verifica se é o primeiro
            if (head == null)
            {
                head = newNode;
                end = newNode;
            }
            else
            {
                //Adiciona ao próximo da lista o novo valor
                end.Proximo = newNode;
            }
            //Adiciona a calda o novo valor
            end = newNode;
            qtde++;
        }

    }
}
