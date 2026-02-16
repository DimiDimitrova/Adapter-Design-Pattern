using System.Reflection;

namespace SauceDemo
{
    public static class EnumExtensionscs
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attribute = field?.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>();

            return attribute?.Description ?? value.ToString();
        }
    }
}
