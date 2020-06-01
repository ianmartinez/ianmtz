using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace ianmtz
{
    /// <summary>
    /// Analyze the user agent for compatibility.
    /// </summary>
    public class Browser
    {
        private readonly HttpRequest Request;

        /// <summary>
        /// Create a browser object from a HttpRequest.
        /// </summary>
        /// 
        /// <param name="Request">The request.</param>
        public Browser(HttpRequest Request)
        {
            this.Request = Request;
        }

        /// <summary>
        /// Get the user agent string.
        /// </summary>
        public string UserAgent
        {
            get
            {
                return Request.Headers[HeaderNames.UserAgent];
            }
        }

        /// <summary>
        /// If the browser in the user agent string identifies as Internet Explorer.
        /// </summary>
        public bool IsIE
        {
            get
            {
                if (UserAgent == null)
                    return false;

                return UserAgent.ToLower().Contains("msie") || UserAgent.ToLower().Contains("trident");
            }
        }
    }
}
