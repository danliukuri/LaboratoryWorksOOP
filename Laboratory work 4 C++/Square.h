#pragma once
class Square
{
public:
    Square();
    ~Square();
    Square(double coordinatesSquare[4][2]);
    Square(double area);
    Square(const Square& other);

    double Area();
    double Perimeter();
    double** GetCoordinates();

    Square operator +(int squareUnits);
    Square operator /(Square sq);
private:
    double **coordinatesSquare;
};