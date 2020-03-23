#include "Square.h"
#include <math.h>
#include <iostream>

Square::Square()
{
    double defaultCoord[4][2] = { { 0, 1 }, { 1, 1 }, { 1, 0 }, { 0, 0 } };
    
    coordinatesSquare = new double* [4];
    for (int i = 0; i < 4; i++)
        coordinatesSquare[i] = new double[2];
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 2; j++)
            coordinatesSquare[i][j] = defaultCoord[i][j];
}
Square::~Square()
{
   for (int i = 0; i < 4; i++)
       delete[] coordinatesSquare[i];
   delete[] coordinatesSquare;
}
Square::Square(double coordinatesSquare[4][2])
{
    this->coordinatesSquare = new double* [4];
    for (int i = 0; i < 4; i++)
        this->coordinatesSquare[i] = new double[2];
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 2; j++)
            this->coordinatesSquare[i][j] = coordinatesSquare[i][j];
}
Square::Square(double area)
{
    double l =  sqrt(area);
    double defaultCoord[4][2] = { { 0, l }, { l, l }, { l, 0 }, { 0, 0 } };
    coordinatesSquare = new double* [4];
    for (int i = 0; i < 4; i++)
        coordinatesSquare[i] = new double[2];
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 2; j++)
            coordinatesSquare[i][j] = defaultCoord[i][j];
}
Square::Square(const Square& other)
{
    if (coordinatesSquare != nullptr)
        this->~Square();
    coordinatesSquare = new double* [4];
    for (int i = 0; i < 4; i++)
        coordinatesSquare[i] = new double[2];
    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 2; j++)
            coordinatesSquare[i][j] = other.coordinatesSquare[i][j];
}

double Square::Area()
{
    double vecLength[2] = { coordinatesSquare[1][0] - coordinatesSquare[0][0], coordinatesSquare[1][1] - coordinatesSquare[0][1] };
    double length = sqrt(pow(vecLength[0], 2) + pow(vecLength[1], 2));
    return pow(length, 2);
}
double Square::Perimeter()
{
    double vecLength[2] = { coordinatesSquare[1][0] - coordinatesSquare[0][0], coordinatesSquare[1][1] - coordinatesSquare[0][1] };
    double length = sqrt(pow(vecLength[0], 2) + pow(vecLength[1], 2));
    return length * 4;
}
double** Square::GetCoordinates()
{
    return coordinatesSquare;
}

Square Square:: operator +(int squareUnits)
{
    double l = (sqrt(this->Area() + squareUnits) - sqrt(this->Area())) / 2;
    Square newsq = Square(*this);

    newsq.coordinatesSquare[0][0] -= l;
    newsq.coordinatesSquare[0][1] += l;
    newsq.coordinatesSquare[1][0] += l;
    newsq.coordinatesSquare[1][1] += l;
    newsq.coordinatesSquare[2][0] += l;
    newsq.coordinatesSquare[2][1] -= l;
    newsq.coordinatesSquare[3][0] -= l;
    newsq.coordinatesSquare[3][1] -= l;

    return newsq;
}
Square Square:: operator /(Square other)
{
    Square newsq = Square(this->Area() / other.Area());
    return newsq;
}



