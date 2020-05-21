#pragma once
#include "Node.h"

class SinglyLinkedList
{
public:
    Node* GetLastNode();
    void AddLast(float value);
    void Remove(float value);
    int FindTheNumberOfElementsLargerFor(float value);
    void RemoveElementsSmallerFor(float value);
private:
    Node* head;
};