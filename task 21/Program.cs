// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве. 
    double Promt(string message)
    {
      Console.WriteLine(message);
      string str = Console.ReadLine() ?? String.Empty;
      double result = Convert.ToDouble(str);
      return result;
    }

    double [] FillCoordinatePoint (string messageCoordinatePoint)
    {
      Console.WriteLine (messageCoordinatePoint);
      double x = Promt ("Enter your point x");
      double y = Promt ("Enter your point y");
      double z = Promt ("Enter your point y");
      double [] coordinatePoint = {x, y, z};
      return coordinatePoint;
    }

    double CoordinateDifference3D(double [] coordinatePointIn1, double [] coordinatePointIn2)
    {
      double result = 0;
      for (int i = 0; i < coordinatePointIn1.Length; i++)
      {
        result = result + Math.Pow((coordinatePointIn2[i] - coordinatePointIn1[i]), 2);
      }
      result = Math.Round(Math.Sqrt(result), 3);

      return result;
    }

   Console.WriteLine($"Your difference 3D-coordinate = {CoordinateDifference3D(FillCoordinatePoint ("Enter your second 3D-coordinate:"), FillCoordinatePoint ("Enter your second 3D-coordinate:"))}");
