using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Kata
{
    public class DLinkedList
    {

        public class DLinkNode
        {
            public String Value;
            public DLinkNode next, prev;

            public DLinkNode(String Value)
            {
               this.Value = Value;
            }

            
        }

        public DLinkNode Head,Tail;
        public int Size { get; private set; }

        public void Add(String value)
        {
            DLinkNode NewNode = new DLinkNode(value);

            if(Size == 0)
            {
                Head = Tail = NewNode;
                Size++;
                return;
            }

            Tail.next = NewNode;
            NewNode.prev = Tail;
            Tail = NewNode;
            Size++;

            return;
        }

        public String FindNode(String value)
        {
            DLinkNode cur = Head;

            for (int i = 0; i < Size; i++)
            {
                if (cur.Value == value)
                {
                    return cur.Value;
                }
                else
                {
                    cur = cur.next;
                }
            }
           
            return null;   
        }

        public void Delete(String Value)
        {
            DLinkNode cur = Head;

            for (int i = 0; i < Size; i++)
            {
                if (cur.Value == Value)
                {
                    if (i == 0)
                    {
                        Head = Head.next;

                        if (Size != 1)
                            cur.next.prev = null;
                        else
                            Tail = null;

                        Size--;
                        return;
                    }

                    if (i == Size - 1)
                    {
                        Tail = Tail.prev;
                        cur.prev.next = null;
                        Size--;
                        return;
                    }

                    cur.prev.next = cur.next;
                    cur.next.prev = cur.prev;
                    Size--;
                    return;
                }
                else
                {
                    cur = cur.next;
                }
            }

        }


        override public String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            DLinkNode cur = Head;
            while (cur != null)
            {
                if (cur != Head)
                    sb.Append(", ");
                sb.Append(cur.Value);
                cur = cur.next;
            }
            sb.Append(")");
            return sb.ToString();
        }

        public void Preprend(DLinkedList L)
        {
            if (L.Size == 0)
                return;

           if(this.Size == 0)
            {
                this.Head = L.Head;
                this.Tail = L.Tail;
                this.Size = L.Size;

                L.Head = L.Tail = null;
                L.Size = 0;

                return;
            }

            L.Tail.next = Head;
            this.Head.prev = Tail;
            this.Head = L.Head;
            this.Size += L.Size;

            L.Head = L.Tail = null;
            L.Size = 0;

        }


    }
}
