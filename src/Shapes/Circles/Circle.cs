using System.Drawing;
using Shapes.Shapes.Base;

namespace Shapes.Shapes.Circles;

/// <summary>
/// Реализует отображение окружности
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
public class Circle(Point point) : ShapeBase(point, new(30, 30))
{
    /// <inheritdoc/>
    public override void DrawInto(Graphics g) => g.DrawArc(Pens.Red, 0, 0, Size.Width - 1, Size.Height - 1, 0, 360);
}