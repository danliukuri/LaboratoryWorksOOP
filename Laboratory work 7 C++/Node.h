#pragma once
class Node
{
public:
    float GetData();
    Node* GetNext();
    void SetNext(Node* value);
    Node(float value);
private:
    float data;
    Node* next;
};