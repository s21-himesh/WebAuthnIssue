// Stratus 21 Addition

namespace Fido2NetLib.Serialization
{
    using System.Text.Json;

    public static class FidoSerializer
    {
        private static readonly FidoModelSerializerContext context = new FidoModelSerializerContext();

        public static T Deserialize<T>(string json) where T : class
        {
            var deserializedObject = JsonSerializer.Deserialize(json, typeof(T), context);
            return (T)deserializedObject;
        }

        public static string Serialize<T>(string json) where T : class
        {
            var serializedObject = JsonSerializer.Serialize(json, typeof(T), context);
            return serializedObject;
        }
    }
}
