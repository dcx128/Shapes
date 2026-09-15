using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Triangles;

/// <summary>
/// Реализует отображение равнобедренного треугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class IsoscelesTriangle(Point point) : TriangleBase(point, size: new(30, 50), TopPointPosition.Middle);