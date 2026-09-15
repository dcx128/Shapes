using System.Drawing;

namespace Shapes.Shapes.Base;

/// <summary>
/// Реализует отображение четырёхугольника, расширяет <see cref="LinesShapeBase"/>
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
/// <param name="size">Размер фигуры</param>
/// <param name="topPointPosition">Возможное положение верхней точки фигуры</param>
/// <param name="randomLastPoint">Последняя точка фигуры в произвольном месте</param>
public class RectangleBase(Point point, Size size, TopPointPosition topPointPosition, bool randomLastPoint) : LinesShapeBase(point, size, points: topPointPosition switch
{
    TopPointPosition.Left =>
    [
        new(0, 0),
        new(0, size.Height - 1),
        new(size.Width - 1, size.Height - 1),
        randomLastPoint ? new(random.Next(size.Width), random.Next(size.Height)) : new(size.Width - 1, 0)
    ],

    TopPointPosition.Middle =>
    [
        new(size.Width / 2, 0),
        new(0, size.Height / 2),
        new(size.Width / 2, size.Height - 1),
        randomLastPoint ? new(random.Next(size.Width), random.Next(size.Height)) : new(size.Width - 1, size.Height / 2)
    ],

    _ =>
    [
        new(random.Next(size.Width), 0),
        new(0, random.Next(size.Height)),
        new(random.Next(size.Width), size.Height - 1),
        randomLastPoint ? new(random.Next(size.Width), random.Next(size.Height)) : new(size.Width - 1, random.Next(size.Height))
    ]
});