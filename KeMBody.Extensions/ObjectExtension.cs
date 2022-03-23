using System.Reflection;

namespace KeMBody.Extensions
{
    public static class ObjectExtension
    {
        /// <summary>
        /// Wywołanie metody z instancji obiektu.
        /// </summary>
        public static object InvokeToMethod(this object source, string name, params object[] parameters)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
            var methodInfo = source.GetType().GetMethod(name, bindFlags);
            return methodInfo.Invoke(source, parameters);
        }

        /// <summary>
        /// Konwersja jawna typów.
        /// </summary>
        public static T ConvertTo<T>(this object source)
        {
            return (T)source;
        }
    }
}
