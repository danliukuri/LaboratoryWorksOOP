#pragma once

class Shape
{
public:
    virtual double GetArea() = 0;
    virtual double GetPerimeter() = 0;
};

class Triangle : public Shape
{
public:
    Triangle(double coordinates[3][2]);
    ~Triangle();
    double GetArea() override;
    double GetPerimeter() override;
private:
    double** coordinates;
};

class Circle : public Shape
{
public:
    Circle(double radius);
    double GetArea() override;
    double GetPerimeter() override;
private:
    double radius;
};