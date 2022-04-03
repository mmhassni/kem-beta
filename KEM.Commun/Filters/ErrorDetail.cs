using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Commun.Filters
{
    public class ErrorDetail
    {

        public string Url
        {
            get => _url;
            set => AffectInitialUrl(value);
        }

        public HttpStatusCode CodeHttp
        {
            get => _codeHttp;
            set
            {
                if (value == HttpStatusCode.OK)
                {
                    throw new InvalidEnumArgumentException();
                }
                _codeHttp = value;
            }
        }

        public string CodeMessage { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string[] Parametres { get; set; } = Array.Empty<string>();

        private HttpStatusCode _codeHttp;

        private string _url = string.Empty;

        public bool FunctionalError { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Url: ").AppendLine(Url);
            sb.Append("Code Http: ").Append(CodeHttp).AppendLine();
            sb.Append("Code message: ").AppendLine(CodeMessage);
            sb.Append("Description: ").AppendLine(Description);
            sb.Append("Functional Error: ").AppendLine(FunctionalError.ToString());
            return sb.ToString();
        }

        private void AffectInitialUrl(string absoluteUri)
        {
            if (string.IsNullOrWhiteSpace(Url))
            {
                _url = absoluteUri;
            }
        }



    }
}
