using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Fastchannel.HttpClient.Bradesco
{
    public static class HelperExtensions
    {
        public static string ToJson<T>(this T o)
            where T : class
        {
            //Create a stream to serialize the object to.  
            var ms = new MemoryStream();
            var dataContractSerializerSettings = new DataContractJsonSerializerSettings
            {
                EmitTypeInformation = EmitTypeInformation.Never,
                UseSimpleDictionaryFormat = true
            };

            // Serializer the User object to the stream.  
            var ser = new DataContractJsonSerializer(typeof(T), dataContractSerializerSettings);
            ser.WriteObject(ms, o);
            var json = ms.ToArray();
            ms.Close();

            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        public static T FromJson<T>(this string json)
            where T : class, new()
        {
            var deserializedUser = new T();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var ser = new DataContractJsonSerializer(deserializedUser.GetType());
            deserializedUser = ser.ReadObject(ms) as T;
            ms.Close();
            return deserializedUser;
        }

        public static string ToBradescoPercentFormat(this decimal dc)
        {
            return dc.ToString(Constants.PERCENTUAL_FORMAT_NNNDDDDD, new CultureInfo("en-US")).Replace(".", string.Empty);
        }

        public static DateTime? FromBradescoDateTimeString(this string str)
        {
            return !string.IsNullOrWhiteSpace(str) ? (DateTime?)DateTime.Parse(str) : null;
        }
    }
}
