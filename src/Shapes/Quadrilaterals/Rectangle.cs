using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Quadrilaterals;

/// <summary>
/// Реализует отображение прямоугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class Rectangle(Point point) : RectangleBase(point, size: new(50, 30), TopPointPosition.Left, randomLastPoint: false);