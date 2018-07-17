/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/design-linked-list/
    Submission  - https://leetcode.com/submissions/detail/164177799/
    Details
        Status: Accepted
        Submitted: July 16, 2018
        53/53 test cases passed
        Runtime: 188ms
        Notes: "Your runtime beats 95.07 % of csharp submissions."
 */

using System;

namespace DesignLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.AddAtHead(1);
            list.AddAtTail(3);
            list.AddAtIndex(1, 5);
            list.DeleteAtIndex(2);
            Console.WriteLine("Size is " + list.Size());
            list.AddAtHead(14);
            Console.WriteLine("Size is " + list.Size());
            list.PrintAllValues();
            Console.WriteLine(list.Get(1));
            Console.WriteLine("Tail: " + list.getTail().getValue());
            Console.WriteLine("Head: " + list.getHead().getValue());
        }
    }

    /**
    * Your MyLinkedList object will be instantiated and called as such:
    * MyLinkedList obj = new MyLinkedList();
    * int param_1 = obj.Get(index);
    * obj.AddAtHead(val);
    * obj.AddAtTail(val);
    * obj.AddAtIndex(index,val);
    * obj.DeleteAtIndex(index);
    */
    public class MyLinkedList {

        /** Initialize your data structure here. */
        private Node head;
        private Node tail;
        private int size;

        public MyLinkedList() {
            head = tail = null;
            size = 0;
        }
        
        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index) {
            if(index >= size || index < 0) return -1;
            else{
                Node tempNode = getNode(index);
                return tempNode == null ? -1 : tempNode.getValue();
            }
        }

        public Node getHead(){
            return head;
        }

        public Node getTail(){
            return tail;
        }

        public Node getNode(int index) {
            if(index >= size || index < 0) return null;
            else if(index == (size - 1)) return tail;
            else if(index >= size / 2) return findNodeAtIndexFromTail(index);
            else return findNodeAtIndexFromHead(index);
        }

        private Node findNodeAtIndexFromHead(int index) {
            Node ret = null;
            int tempIndex = 0;
            Node currentNode = head;
            while(currentNode != null && tempIndex <= index) {
                ret = currentNode;
                currentNode = currentNode.getNext();
                ++tempIndex;
            }
            return ret;
        }

        private Node findNodeAtIndexFromTail(int index) {
            Node ret = null;
            int tempIndex = (size - 1);
            Node currentNode = tail;
            while(tempIndex >= index && currentNode != null) {
                ret = currentNode;
                currentNode = currentNode.getPrevious();
                --tempIndex;
            }
            return ret;
        }
        
        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val) {
            if(head == null) {
                if(tail == null){
                    head = new Node(val, null, null);
                    tail = head;
                }
                else{
                    head = new Node(val, tail, null);
                }
            }
            else {
                Node temp = new Node(val, head, null);
                head = temp;
            }
            if(head.getNext() != null) head.getNext().setPrevious(head);
            ++size;
        }
        
        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val) {
            if(tail == null) {
                
                if(head == null){
                    tail = new Node(val, null, null);
                    head = tail;
                }
                else{
                    tail = new Node(val, null, head);
                }
            }
            else {
                Node temp = new Node(val, null, tail);
                tail = temp;
            }
            if(tail.getPrevious() != null) tail.getPrevious().setNext(tail);
            ++size;
        }
        
        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val) {
            if(index == size) AddAtTail(val);
            else if( index < size) {
                Node NodeToInsert = new Node(val, null, null);
                Node currentNode = getNode(index);

                NodeToInsert.setNext(currentNode);
                if(currentNode != null) {
                    NodeToInsert.setPrevious(currentNode.getPrevious());
                    if(currentNode.getPrevious() != null) {
                        currentNode.getPrevious().setNext(NodeToInsert);
                    }
                    currentNode.setPrevious(NodeToInsert);
                }
                ++size;                
            }
        }
        
        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index) {
            if(index < size && index >= 0) {

                Node NodeToDelete = getNode(index);
                if(NodeToDelete == tail) {
                    if(tail.getPrevious() != null) tail = tail.getPrevious();
                    tail.setNext(null);
                }
                else if(NodeToDelete == head) {
                    if(head.getNext() != null) head = head.getNext();
                    head.setPrevious(null);
                }
                else if(NodeToDelete != null) {
                    Node Previous = NodeToDelete.getPrevious();
                    Node Next = NodeToDelete.getNext();
                    if(Previous != null) {
                        Previous.setNext(Next);
                    }
                    if(Next != null) {
                        Next.setPrevious(Previous);
                    }
                }

                --size;
            }
        }

        public int Size(){
            return size;
        }

        public void PrintAllValues(){
            string temp = "";
            int index = 0;
            Node currentNode = head;
            while(currentNode != null){
                temp += "[" + currentNode.getValue() + " @" + index + "]" + "\t";
                currentNode = currentNode.getNext();
                ++index;
            }
            Console.WriteLine(temp);
        }
    }

    public class Node {
        int value;
        Node next;
        Node prev;

        public Node(int val, Node n, Node p){
            value = val;
            next = n;
            prev = p;
        }

        public void setNext(Node n){
            next = n;
        }

        public void setPrevious(Node p){
            prev = p;
        }

        public void setValue(int i){
            value = i;
        }

        public int getValue(){
            return value;
        }

        public Node getNext(){ return next; }
        public Node getPrevious(){ return prev; }
        
    }
}
