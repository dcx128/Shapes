using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Triangles;

/// <summary>
/// Реализует отображение прямоугольного треугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class RightAngledTriangle(Point point) : TriangleBase(point, size: new(30, 30), TopPointPosition.Left);