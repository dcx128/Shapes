using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Shapes.Shapes.Interfaces;

namespace Shapes;

/// <summary>
/// Элемент управления для отображения фигур, расширяет <see cref="UserControl"/>
/// </summary>
public class ShapeControl : UserControl
{
    /// <summary>
    /// Фигура для отображения
    /// </summary>
    private readonly IShape shape;

    /// <summary>
    /// Инициализирует новый экземпляр типа <see cref="ShapeControl"/>
    /// </summary>
    /// <param name="shape">Фигура для отображения</param>
    public ShapeControl(IShape shape) : base()
    {
        this.shape = shape;

        SetStyle(ControlStyles.AllPaintingInWmPaint
            | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.ResizeRedraw
            | ControlStyles.UserPaint, true);

        Location = shape.Location;
        Size = shape.Size;
    }

    /// <inheritdoc/>
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (!VisualStyleRenderer.IsSupported)
        {
            return;
        }

        try
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            shape.DrawInto(g);
        }
        catch (Exception)
        {
            base.OnPaint(e);
        }
    }
}