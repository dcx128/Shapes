using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Shapes.Extensions;
using Shapes.Shapes.Circles;
using Shapes.Shapes.Pentagons;
using Shapes.Shapes.Quadrilaterals;
using Shapes.Shapes.Triangles;

namespace Shapes;

/// <summary>
/// Реализует логику главной экранной формы
/// </summary>
public partial class MainForm : Form
{
    /// <summary>
    /// Общее кол-во типов фигур
    /// </summary>
    private readonly int figuresCount = Assembly
        .GetExecutingAssembly()
        .GetTypes()
        .Where(t => t.Namespace.ContainsAny(
        [
            nameof(Shapes.Circles),
            nameof(Shapes.Triangles),
            nameof(Shapes.Quadrilaterals),
            nameof(Shapes.Pentagons),
        ]))
        .Count();

    /// <summary>
    /// Генератор случайных чисел
    /// </summary>
    private readonly Random random = new();

    /// <summary>
    /// Инициализирует новый экземпляр типа <see cref="MainForm"/>
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Обрабатывает событие клика на главной экранной форме
    /// </summary>
    /// <param name="sender">Источник события</param>
    /// <param name="e">Данные события</param>
    private void DrawRandomShape(object sender, MouseEventArgs e) => Controls.Add(new ShapeControl(random.Next(figuresCount) switch
    {
        11     => new SimplePentagon(e.Location),
        10     => new SimpleQuadrilateral(e.Location),
        9      => new ConvexQuadrilateral(e.Location),
        8      => new Rhombus(e.Location),
        7      => new Rectangle(e.Location),
        6      => new Square(e.Location),
        5      => new ObtuseTriangle(e.Location),
        4      => new RightAngledTriangle(e.Location),
        3      => new ScaleneTriangle(e.Location),
        2      => new IsoscelesTriangle(e.Location),
        1      => new EquilateralTriangle(e.Location),
        0 or _ => new Circle(e.Location)
    }));
}