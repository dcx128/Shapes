using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Triangles;

/// <summary>
/// Реализует отображение разностороннего треугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class ScaleneTriangle(Point point) : TriangleBase(point, size: new(30, 30), TopPointPosition.Undefined);