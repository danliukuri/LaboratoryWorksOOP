#include "SinglyLinkedList.h"
#include <iostream>

Node* SinglyLinkedList::GetLastNode()
{
    Node* lastNode = head;
    while (lastNode->GetNext() != nullptr)
        lastNode = lastNode->GetNext();
    return lastNode;
}

void SinglyLinkedList::AddLast(float value)
{
    Node* newNode = new Node(value);
    if (head == nullptr)
        head = newNode;
    else
    {
        Node* lastNode = GetLastNode();
        lastNode->SetNext(newNode);
    }
}
void SinglyLinkedList::Remove(float value)
{
    Node* previous = nullptr;
    Node* current = head;
    if (current != nullptr && current->GetData() == value)
        head = current->GetNext();
    else
    {
        while (current != nullptr && current->GetData() != value)
        {
            previous = current;
            current = current->GetNext();
        }
        if (current == nullptr)
            throw new std::exception("There is no such element");
        previous->SetNext(current->GetNext());
    }
}

int SinglyLinkedList::FindTheNumberOfElementsLargerFor(float value)
{
    int number = 0;
    Node* current = head;
    while (current != nullptr)
    {
        if (current->GetData() > value)
            number++;
        current = current->GetNext();
    }
    return number;
}
void SinglyLinkedList::RemoveElementsSmallerFor(float value)
{
    Node* current = head;
    while (current != nullptr)
    {
        if (current->GetData() < value)
            Remove(current->GetData());
        current = current->GetNext();
    }
}