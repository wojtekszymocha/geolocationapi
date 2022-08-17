namespace GeolocationLibrary
{
    public static class IpStackUrlBuilder
    {
        private const string AccessTokenQueryParam = "?access_key=";

        public static string BuildUrl(string url, string ip, string accessToken)
        {
            return url + Consts.EndpointSepartor + ip + AccessTokenQueryParam + accessToken;
        }
    }
}