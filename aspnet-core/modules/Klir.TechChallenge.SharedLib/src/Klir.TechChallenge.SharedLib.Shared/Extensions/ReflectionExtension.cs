

namespace Klir.TechChallenge.SharedLib.Shared.Extensions
{
    /// <summary>
    /// rflection 
    /// </summary>
    public static class ReflectionExtension
    {
        /// <summary>
        /// get property value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Item"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static string GetPropertyValue<T>(this T Item, string propertyName)
        {
            return Item.GetType().GetProperty(propertyName).GetValue(Item, null).ToString();
        }
    }
}
