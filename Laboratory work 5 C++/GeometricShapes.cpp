#include "GeometricShapes.h"
#include <iostream>
#include <math.h>

Triangle::Triangle(double coordinates[3][2])
{
    this->coordinates = new double* [3];
    for (int i = 0; i < 3; i++)
        this->coordinates[i] = new double[2];
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 2; j++)
            this->coordinates[i][j] = coordinates[i][j];
}
Triangle::~Triangle()
{
    for (int i = 0; i < 3; i++)
        delete[] coordinates[i];
    delete[] coordinates;
}
double Triangle::GetArea()
{
    return abs(0.5 * (coordinates[0][0] * coordinates[0][1] - coordinates[0][1] * coordinates[1][0] + coordinates[1][0] * coordinates[2][1] -
                      coordinates[1][1] * coordinates[2][0] + coordinates[2][0] * coordinates[0][1] - coordinates[2][1] * coordinates[0][0]));
}
double Triangle::GetPerimeter()
{
    return sqrt(pow(coordinates[0][0] - coordinates[1][0], 2) + pow(coordinates[0][1] - coordinates[1][1], 2)) +
           sqrt(pow(coordinates[1][0] - coordinates[2][0], 2) + pow(coordinates[1][1] - coordinates[2][1], 2)) +
           sqrt(pow(coordinates[2][0] - coordinates[0][0], 2) + pow(coordinates[2][1] - coordinates[0][1], 2));
}

Circle::Circle(double radius)
{
    if (radius <= 0)
        throw std::exception("This is not a circle");
    this->radius = radius;
}
double Circle::GetArea()
{
    return pow(radius, 2);
}
double Circle::GetPerimeter()
{
    return 2 * 3.1415926535897931 * radius;
}