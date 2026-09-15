using System.Linq;

namespace Shapes.Extensions;

/// <summary>
/// Предоставляет методы расширения для <see cref="string"/>
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Проверить что указанное значение <paramref name="value"/> содержится хотя бы в одном из значений <paramref name="values"/>
    /// </summary>
    /// <param name="value">Целевое значение, вхождение которого необходимо проверить</param>
    /// <param name="values">Множество значений в которых будет проверяться вхождение</param>
    public static bool ContainsAny(this string value, params string[] values) => values.Any(value.Contains);
}