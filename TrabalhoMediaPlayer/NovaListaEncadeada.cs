using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMediaPlayer
{
    class NovaListaEncadeada<T>
    {
        public Node<T> head { get; private set; }
        public Node<T> end { get; private set; }
        public int qtde { get; private set; }
        public NovaListaEncadeada()
        {
            this.end = null;
            this.head = null;
            this.qtde = 0;
        }

        public bool IsEmpty
        {
            get { return this.qtde == 0; }
        }
        public int count
        {
            get { return this.qtde; }
        }

        /*

        public void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(item);
                this.end = this.head;
            }
            else
            {
                Node<T> newItem = new Node<T>(item, end);
                this.end = newItem;
            }
            qtde++;
        }

        public void Remove(T item)
        {
            int currentIndex = 0;
            Node<T> currentItem = this.head;
            Node<T> prevItem = null;
            while (currentItem != null)
            {
                if ((currentItem.Item != null &&
                currentItem.Item.Equals(item)) ||
                (currentItem.Item == null) && (item == null))
                {
                    break;
                }
                prevItem = currentItem;
                currentItem = currentItem.Proximo;
                currentIndex++;
            }
            if (currentItem != null)
            {
                qtde--;
                if (count == 0)
                {
                    this.head = null;
                }
                else if (prevItem == null)
                {
                    this.head = currentItem.Proximo;
                    this.head.Anterior = null;
                }
                else if (currentItem == end)
                {
                    currentItem.Anterior.Proximo = null;
                    this.end = currentItem.Anterior;
                }
                else
                {
                    currentItem.Anterior.Proximo = currentItem.Proximo;
                    currentItem.Proximo.Anterior = currentItem.Anterior;
                }
            }
        }*/
    }
}
