using System.Drawing;

namespace Shapes.Shapes.Interfaces;

/// <summary>
/// Определяет методы и свойства для отображения фигуры
/// </summary>
public interface IShape
{
    /// <summary>
    /// Получает центральную точку фигуры
    /// </summary>
    Point Location { get; }

    /// <summary>
    /// Получает размер фигуры
    /// </summary>
    Size Size { get; }

    /// <summary>
    /// Отображает фигуру на указанной поверхности рисования GDI+
    /// </summary>
    /// <param name="g">Поверхность рисования GDI+</param>
    void DrawInto(Graphics g);
}