using Fastchannel.HttpClient.Bradesco;
using Fastchannel.HttpClient.Bradesco.RestClient.Enumerators;
using Fastchannel.HttpClient.Bradesco.RestClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;

namespace Fastchannel.HttpClient.Bradesco.RestClient.Models
{
    [DataContract]
    internal class Request
    {
        public Request()
        {
            Parameters = new List<IParameter>();
        }

        public Request(HttpMethod httpMethod, string resource) : this()
        {
            Resource = resource;
            Method = httpMethod;
        }

        [DataMember]
        public string Resource { get; set; }
        [IgnoreDataMember]
        public HttpMethod Method { get; set; }
        [DataMember]
        public List<IParameter> Parameters { get; set; }
        [DataMember(Name = "Method")]
        internal string MethodAsString { get => Method.ToString(); private set { } }

        public int? TimeoutInSeconds { get; set; }

        internal Request AddAuthorization(string merchantId, string secureKey)
        {
            var decodedString = $"{merchantId}:{secureKey}";

            var bytes = Encoding.UTF8.GetBytes(decodedString);
            var encodedString = Convert.ToBase64String(bytes);

            Parameters.Add(new Parameter
            {
                Type = ParameterType.Header,
                Name = "Authorization",
                Value = $"Basic {encodedString}"
            });

            return this;
        }

        internal Request AddBody(string content)
        {
            Parameters.Add(new Parameter
            {
                Name = "body",
                Value = content,
                Type = ParameterType.RequestBody
            });

            return this;
        }

        internal Request AddBody(object obj)
        {
            return AddBody(obj.ToJson());
        }

        internal Request AddCookie(string name, string value)
        {
            Parameters.Add(new Parameter
            {
                Name = name,
                Value = value,
                Type = ParameterType.Cookie
            });

            return this;
        }

        internal Request AddQueryStringParameter(string name, string value)
        {
            Parameters.Add(new Parameter
            {
                Name = name,
                Value = value,
                Type = ParameterType.QueryString
            });

            return this;
        }
    }
}
