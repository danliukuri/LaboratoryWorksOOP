#include<iostream>
#include "SinglyLinkedList.h"

int main()
{
    SinglyLinkedList list = SinglyLinkedList();
    list.AddLast(1.6f);
    list.AddLast(1.9f);
    list.AddLast(2.3f);
    list.AddLast(2.6f);
    list.AddLast(7.5f);
    list.AddLast(10.5f);
    list.AddLast(10.9f);
    list.AddLast(11.5f);
    list.AddLast(99.9f);

    list.RemoveElementsSmallerFor(2.6f);
    list.Remove(2.6f);

    int num = list.FindTheNumberOfElementsLargerFor(10.5f);
}