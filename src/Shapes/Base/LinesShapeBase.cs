using System.Drawing;
using System.Linq;

namespace Shapes.Shapes.Base;

/// <summary>
/// Реализует отображение фигуры из отрезков, расширяет <see cref="ShapeBase"/>
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
/// <param name="size">Размер фигуры</param>
/// <param name="points">Точки фигуры</param>
public class LinesShapeBase(Point point, Size size, Point[] points) : ShapeBase(point, size)
{
    /// <inheritdoc/>
    public override void DrawInto(Graphics g) => g.DrawLines(Pens.Red, [.. points.Append(points[0])]);
}