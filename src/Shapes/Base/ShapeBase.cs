using System;
using System.Drawing;
using Shapes.Shapes.Interfaces;

namespace Shapes.Shapes.Base;

/// <summary>
/// Базовая реализация отображения фигуры, реализует <see cref="IShape"/>
/// </summary>
/// <param name="point">Центральная точка фигуры</param>
/// <param name="size">Размер фигуры</param>
public abstract class ShapeBase(Point point, Size size) : IShape
{
    /// <summary>
    /// Генератор случайных чисел
    /// </summary>
    protected static readonly Random random = new();

    /// <inheritdoc/>
    public Point Location { get; } = new(point.X - size.Width / 2, point.Y - size.Height / 2);

    /// <inheritdoc/>
    public Size Size { get; } = size;

    /// <inheritdoc/>
    public abstract void DrawInto(Graphics g);
}