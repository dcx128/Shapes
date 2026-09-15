using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Quadrilaterals;

/// <summary>
/// Реализует отображение выпуклого четырёхугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class ConvexQuadrilateral(Point point) : RectangleBase(point, size: new(30, 30), TopPointPosition.Undefined, randomLastPoint: false);