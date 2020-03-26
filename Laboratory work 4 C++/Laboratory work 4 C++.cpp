#include <iostream>
#include "Square.h"

int main()
{
    Square k1 = Square();

   //for (int i = 0; i < 4; i++)
    //    for (int j = 0; j < 2; j++)
      //      std::cout << k1.GetCoordinates()[i][j];


   double coordS2[4][2] = { { 0, 2 }, { 2, 2 }, { 2, 0 }, { 0, 0 } };
   Square k2 = Square(coordS2);

   //for (int i = 0; i < 4; i++)
     //  for (int j = 0; j < 2; j++)
       //    std::cout << k2.GetCoordinates()[i][j];

   double a2 = k2.Area();
   double p2 = k2.Perimeter();

   Square k3 = k2 + 5;
   double a3 = k3.Area();

   Square k4 = k3 / k2;
   double a4 = k4.Area();
}