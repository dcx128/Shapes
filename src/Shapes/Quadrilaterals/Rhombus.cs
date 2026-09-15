using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Quadrilaterals;

/// <summary>
/// Реализует отображение ромба
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class Rhombus(Point point) : RectangleBase(point, size: new(30, 50), TopPointPosition.Middle, randomLastPoint: false);