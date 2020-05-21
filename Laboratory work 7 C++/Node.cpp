#include "Node.h"

Node::Node(float value)
{
	data = value;
	next = nullptr;
}
float Node::GetData()
{
	return data;
}
Node* Node::GetNext()
{
	return next;
}
void Node::SetNext(Node* value)
{
	next = value;
}