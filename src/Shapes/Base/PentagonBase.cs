using System.Drawing;

namespace Shapes.Shapes.Base;

/// <summary>
/// Реализует отображение пятиугольника, расширяет <see cref="LinesShapeBase"/>
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
/// <param name="size">Размер фигуры</param>
public class PentagonBase(Point point, Size size) : LinesShapeBase(point, size, points:
[
    new(random.Next(size.Width), random.Next(size.Height)),
    new(random.Next(size.Width), random.Next(size.Height)),
    new(random.Next(size.Width), random.Next(size.Height)),
    new(random.Next(size.Width), random.Next(size.Height)),
    new(random.Next(size.Width), random.Next(size.Height))
]);