using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Triangles;

/// <summary>
/// Реализует отображение тупоугольного треугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class ObtuseTriangle(Point point) : TriangleBase(point, size: new(50, 30), TopPointPosition.Undefined);