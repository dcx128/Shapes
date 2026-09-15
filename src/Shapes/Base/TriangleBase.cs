using System.Drawing;

namespace Shapes.Shapes.Base;

/// <summary>
/// Реализует отображение треугольника, расширяет <see cref="LinesShapeBase"/>
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
/// <param name="size">Размер фигуры</param>
/// <param name="topPointPosition">Возможное положение верхней точки фигуры</param>
public class TriangleBase(Point point, Size size, TopPointPosition topPointPosition) : LinesShapeBase(point, size, points:
[
    new(topPointPosition switch
    {
        TopPointPosition.Left   => 0,
        TopPointPosition.Middle => size.Width / 2,
        _                       => random.Next(size.Width)
    }, 0),
    new(0, size.Height - 1),
    new(size.Width - 1, size.Height - 1)
]);