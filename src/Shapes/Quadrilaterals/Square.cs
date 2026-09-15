using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Quadrilaterals;

/// <summary>
/// Реализует отображение квадрата
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class Square(Point point) : RectangleBase(point, size: new(30, 30), TopPointPosition.Left, randomLastPoint: false);