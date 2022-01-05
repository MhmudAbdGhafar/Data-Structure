using System;
using System.Collections.Generic;
using System.Text;

public class linkedList
{
    class Node
    {
        internal int value;
        internal Node next;

        public Node(int value)
        {
            this.value = value;
        }
    }
    private Node head;
    private Node tail;
    private int size;
    public void addLast(int value)
    {
        var newNode = new Node(value);
        if (isEmpty())
            head = tail = newNode;
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        size++;
    }

    public void addFirst(int value)
    {
        var newNode = new Node(value);
        if (isEmpty())
            head = tail = newNode;
        else
        {
            newNode.next = head;
            head = newNode;
        }

        size++;
    }

    public int indexOf(int item)
    {
        int index = 0;
        var current = head;
        while(current != null)
        {
            if (current.value == item)
                return index;
            current = current.next;
            index++;
        }
        return -1;
    }

    public void removeFirst()
    {
        if(isEmpty())
            throw new InvalidOperationException();

        size--;
        
        if (head == tail)
        {
            head = tail = null;
            return; 
        }           
        var temp = head;
        head = head.next;
        temp = null;

        
    }

    public void removeLast()
    {
        if (isEmpty())
            throw new InvalidOperationException();

        if (head == tail)
            head = tail = null;
        else{
            var previous = getPrevious();
            tail = previous;
            tail.next = null;
        }
        size--;
    }

    public bool contains(int item)
    {
        return indexOf(item) != -1;
    }

    public int Size()
    {
        return size;
    }

    public void reverse()
    {

        var previous = head;
        var current = head.next;
        while(current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        tail = head;
        tail.next = null;
        head = previous;
    }

    public int getThKNodeFromTheEnd(int k)
    {
        if (isEmpty() || k <= 0)
            throw new InvalidOperationException();

        var firstPointer = head;
        var secondPointer = head;
        for (int i = 0; i < k - 1; i++)
        {
            secondPointer = secondPointer.next;
            if (secondPointer == null)
                throw new InvalidOperationException();
        }
        while(secondPointer.next != null)
        {
            secondPointer = secondPointer.next;
            firstPointer = firstPointer.next;
        }
        return firstPointer.value;
    }

    public void printMiddle()
    {
        if (isEmpty())
            throw new InvalidOperationException();

        var firstPointer = head;
        var secondPointer = head;
        while(secondPointer != tail && secondPointer.next != tail)
        {
            firstPointer = firstPointer.next;
            secondPointer = secondPointer.next.next;
        }

        if (secondPointer != tail)
        {
            var firstMiddle = firstPointer.value;
            var secondMiddle = firstPointer.next.value;

            Console.WriteLine("first middle is {0}, second middle is {1}", firstMiddle, secondMiddle);
        }
        else
            Console.WriteLine("middle is {0}", firstPointer.value);
    }

    public bool hasLoop()
    {
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
                return true;
        }

        return false;
    }
    public  linkedList createWithLoop()
    {
        var list = new linkedList();
        list.addLast(10);
        list.addLast(20);
        list.addLast(30);

        // Get a reference to 30
        var node = list.head;

        list.addLast(40);
        list.addLast(50);

        // Create the loop
        list..next = node;

        return list;
    }

    public int[] toArray()
    {
        int[] array = new int[size];
        int index = 0;
        for (Node current = head; current != null; current = current.next)
            array[index++] = current.value;

        return array;
    }
    private bool isEmpty()
    {
        return head == null;
    }
    private Node getPrevious()
    {
        var previous = head;
        while (previous.next != tail)
            previous = previous.next;
        return previous;
    }
}

