﻿using System.Net.Http;
using System.Threading.Tasks;

namespace CaelumStellaCSharp.http
{
    public interface IHttpResponseMessageClient
    {
        Task<HttpResponseMessage> GetHttpResponseMessage(string url);
        HttpResponseMessage GetHttpResponseMessageAsync(string url);
    }
}