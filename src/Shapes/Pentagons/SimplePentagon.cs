using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Pentagons;

/// <summary>
/// Реализует отображение простого пятиугольника
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class SimplePentagon(Point point) : PentagonBase(point, size: new(50, 50));