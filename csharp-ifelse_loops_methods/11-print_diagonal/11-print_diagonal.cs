using System;

class Line
{
    public static void PrintDiagonal(int length){

        string str = "";
        for (int i = 0; i <= length; i++)
        {
            str += "_";
        }

        return str;
    }
}