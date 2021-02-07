using Newtonsoft.Json;
using System.Text.Json;

namespace ExtensionCore
{
    public static class JsonExtension
    {
        #region System.Text.Json

        /// <summary>
        /// Converte o Objeto em JSON usando a dll 'System.Text.Json' (Microsoft .NetCore)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string ToSerializeJsonTextJson<T>(this T objeto) where T : class
        {
            return System.Text.Json.JsonSerializer.Serialize(objeto, new JsonSerializerOptions() { WriteIndented = true }); ;
        }

        /// <summary>
        /// Converte o JSON usando a dll 'System.Text.Json' (Microsoft .NetCore), 
        /// onde está configurado para não diferenciar maiúsculas de minúsculas durante a desserialização.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T ToDeserializeJsonTextJson<T>(this string json) where T : class
        {
            return string.IsNullOrEmpty(json) ? null :
                System.Text.Json.JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        #endregion System.Text.Json

        #region Newtonsoft.Json

        /// <summary>
        /// Converte o Objeto em JSON usando a dll 'Newtonsoft.Json'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static string ToSerializeJsonNewtonsoft<T>(this T objeto) where T : class
        {
            return JsonConvert.SerializeObject(objeto);
        }

        /// <summary>
        /// Converte o Objeto em JSON usando a dll 'Newtonsoft.Json'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <param name="ignoreLoop"></param>
        /// <returns></returns>
        public static string ToSerializeJsonNewtonsoft<T>(this T objeto, bool ignoreLoop) where T : class
        {
            if (ignoreLoop)
            {
                JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                return JsonConvert.SerializeObject(objeto, jsonSerializerSettings);
            }

            return JsonConvert.SerializeObject(objeto);
        }

        /// <summary>
        /// Converte o JSON usando a dll 'Newtonsoft.Json'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T ToDeserializeJsonNewtonsoft<T>(this string json) where T : class
        {
            return string.IsNullOrEmpty(json) ? null : JsonConvert.DeserializeObject<T>(json);
        }

        #endregion Newtonsoft.Json
    }
}
